using System.Collections.ObjectModel;
using System.Data.Entity;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using WaterPolo.Simple.DataAccess;
using WaterPolo.Simple.DataCenter.New.ViewModels.Models;

namespace WaterPolo.Simple.DataCenter.New.ViewModels
{
    [POCOViewModel]
    public class TeamCollectionEditViewModel : EditViewModelBase<Team, TeamIE>
    {
        public override Team CurrentItem { get; set; }

        public override ObservableCollection<Team> Items { get; set; }
        protected IDocumentManagerService DocumentManagerService => this.GetRequiredService<IDocumentManagerService>();

        public override void Add()
        {
            var team = new Team { Name = "New Team", DisplayName = "TAM" };
            Context.Teams.Add(team);
            CurrentItem = team;
        }

        protected override void AddItem(Team item)
        {
            Context.Teams.Add(item);
        }

        protected override void RemoveItem()
        {
            Context.Teams.Remove(CurrentItem);
        }

        protected override Team ConvertFromImportData(TeamIE importData)
        {
            return new Team
            {
                DisplayName = importData.DisplayName,
                Name = importData.Name
            };
        }

        protected override TeamIE ConvertToExportData(Team data)
        {
            return new TeamIE
            {
                DisplayName = data.DisplayName,
                Name = data.Name
            };
        }

        protected override void RefreshItems()
        {
            Context.Teams.Load();
            Items = Context.Teams.Local;
        }

        public void EditPlayers()
        {
            IDocument document = DocumentManagerService.FindDocument(parameter: CurrentItem, parentViewModel: this);

            if (document == null)
            {
                document = DocumentManagerService.CreateDocument(documentType: "PlayerCollectionEditView", parameter: CurrentItem, parentViewModel: this);
                document.Title = $"{CurrentItem.Name} Players";
            }
            document.Show();
        }
    }
}