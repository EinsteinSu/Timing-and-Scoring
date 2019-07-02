﻿using System.Linq;
using DevExpress.Xpf.Grid;
using WaterPolo.Simple.DataAccess;
using WaterPolo.Simple.DataCenter.DataEdit.EditWindow;

namespace WaterPolo.Simple.DataCenter.DataEdit
{
    public class ScheduleEdit : DataManagerBase
    {
        public ScheduleEdit(WaterPoloDataContext context, GridControl grid) : base(context, grid)
        {
        }

        public override void Add()
        {
            var schedule = new Schedule { DisplayName = "New Schedule" };
            var vm = new ScheduleEditViewModel(schedule, Context);
            if (vm.Show())
            {
                Context.Schedules.Add(schedule);
            }
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