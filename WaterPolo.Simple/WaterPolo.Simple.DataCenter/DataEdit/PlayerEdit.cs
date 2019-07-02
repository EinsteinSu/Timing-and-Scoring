using System.Linq;
using DevExpress.Xpf.Grid;
using WaterPolo.Simple.DataAccess;
using WaterPolo.Simple.DataCenter.DataEdit.EditWindow;

namespace WaterPolo.Simple.DataCenter.DataEdit
{
    public class PlayerEdit : DataManagerBase
    {
        public PlayerEdit(WaterPoloDataContext context, GridControl grid) : base(context, grid)
        {
        }
        public override void Add()
        {
            var player = new Player { DisplayName = "New Player" };
            var viewModel = new PlayerEditWindowViewModel(player, Context);
            if (viewModel.Show())
            {
                Context.Players.Add(player);
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
            return Context.Players.ToList();
        }
    }
}