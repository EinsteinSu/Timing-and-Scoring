using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using CsvHelper;
using DevExpress.Office.Utils;
using Newtonsoft.Json;
using WaterPolo.Simple.DataAccess;
using WaterPolo.Simple.DataCenter.DataEdit.DataImportExport;

namespace WaterPolo.Simple.DataCenter.DataEdit
{
    public class TeamEdit : DataManagerBase
    {
        public override void Add(object item)
        {
            Context.Teams.Add((Team)item);
            Context.SaveChanges();
        }

        public override object GetItemSource()
        {
            return Context.Teams.ToList();
        }

        public override object NewItem()
        {
            var team = new Team { DisplayName = "CHN" };
            return team;
        }

        protected override object ConvertDataFromText(string data)
        {
            return JsonConvert.DeserializeObject<Team>(data);
        }

        public override void Import(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                using (var csv = new CsvReader(reader))
                {
                    var list = csv.GetRecords<TeamIO>();
                    foreach (var teamIO in list)
                    {
                        var team = new Team { Name = teamIO.Name, DisplayName = teamIO.DisplayName };
                        Context.Teams.Add(team);
                    }

                    Context.SaveChanges();
                }
            }
        }

        public override void Export(string fileName)
        {
            var list = new List<TeamIO>();
            foreach (var item in Context.Teams.ToList())
            {
                list.Add(new TeamIO
                {
                    Name = item.Name,
                    DisplayName = item.DisplayName
                });
            }
            using (var writer = new StreamWriter(fileName))
            {
                using (var csv = new CsvWriter(writer))
                {
                    csv.WriteRecords(list);
                }
            }
        }

        public override void Copy()
        {
            if (CurrentItem is Team item)
            {
                var team = new Team
                {
                    Name = item.Name,
                    DisplayName = item.DisplayName,
                    Flag = item.Flag
                };
                var data = JsonConvert.SerializeObject(team);
                Clipboard.SetText(data);
            }
        }

        public override void Delete()
        {
            if (CurrentItem is Team team)
            {
                Context.Teams.Remove(team);
                Context.SaveChanges();
            }
        }
    }
}