using System;
using System.Linq;
using DevExpress.Xpf.Grid;
using WaterPolo.Simple.DataAccess;
using WaterPolo.Simple.DataCenter.DataEdit.EditWindow;

namespace WaterPolo.Simple.DataCenter.DataEdit
{
    public class TeamEdit : DataManagerBase
    {
        public TeamEdit(WaterPoloDataContext context, GridControl grid) : base(context, grid)
        {
        }

        public override void Add()
        {
            var team = new Team {DisplayName = "TAM"};
            var viewModel = new TeamEditWindowViewModel(team);
            if (viewModel.Show()) Context.Teams.Add(team);
        }

        public override void Import(string path)
        {
            throw new NotImplementedException();
        }

        public override void Export(string fileName)
        {
            throw new NotImplementedException();
        }

        protected override object GetList()
        {
            return Context.Teams.ToList();
        }
    }
}