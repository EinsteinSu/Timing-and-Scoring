using DevExpress.Xpf.Grid;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.DataCenter.DataEdit
{
    public abstract class DataManagerBase1 
    {
        protected readonly WaterPoloDataContext Context;
        protected readonly GridControl Grid;
        private object _currentItem;

        public DataManagerBase1(WaterPoloDataContext context, GridControl grid)
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
        public void Edit()
        {
            throw new System.NotImplementedException();
        }

        public object CurrentItem
        {
            get => _currentItem;
            set => _currentItem = value;
        }

        public object GetItemSource()
        {
            throw new System.NotImplementedException();
        }

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

        public void Delete()
        {
            throw new System.NotImplementedException();
        }
    }
}