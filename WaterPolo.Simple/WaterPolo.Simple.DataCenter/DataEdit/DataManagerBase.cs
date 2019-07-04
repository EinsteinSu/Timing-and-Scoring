using DevExpress.Xpf.Grid;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.DataCenter.DataEdit
{
    public abstract class DataManagerBase : IDataManager
    {
        protected readonly WaterPoloDataContext Context;
        protected readonly GridControl Grid;

        public DataManagerBase(WaterPoloDataContext context, GridControl grid)
        {
            Context = context;
            Grid = grid;
        }

        public virtual void Refresh()
        {
            if (Grid != null)
            {
                Grid.ItemsSource = null;
                Grid.ItemsSource = GetList();
            }
        }

        public abstract void Add();

        public virtual void Save()
        {
            Context.SaveChanges();
        }

        public abstract void Import(string path);
        public abstract void Export(string fileName);

        public virtual void AddAndRefresh()
        {
            Add();
            Save();
            Refresh();
        }

        protected abstract object GetList();
    }
}