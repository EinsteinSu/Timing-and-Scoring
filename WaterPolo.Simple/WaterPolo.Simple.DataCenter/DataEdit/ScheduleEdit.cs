using System.Linq;
using DevExpress.Xpf.Grid;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.DataCenter.DataEdit
{
    public class ScheduleEdit : DataManagerBase
    {
        public ScheduleEdit(WaterPoloDataContext context, GridControl grid) : base(context, grid)
        {
        }

        public override void Add()
        {
            var schedule = new Schedule {DisplayName = "New Schedule"};
            Context.Schedules.Add(schedule);
        }

        public override void Import(string path)
        {
            throw new System.NotImplementedException();
        }

        public override void Export(string fileName)
        {
            throw new System.NotImplementedException();
        }

        protected override object GetList()
        {
            return Context.Schedules.ToList();
        }
    }
}