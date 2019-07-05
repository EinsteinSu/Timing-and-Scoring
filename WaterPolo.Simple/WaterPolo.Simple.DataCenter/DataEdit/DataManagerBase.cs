using DevExpress.Mvvm;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.DataCenter.DataEdit
{
    public abstract class DataManagerBase : ViewModelBase, IDataManager
    {
        private object _currentItem;
        protected WaterPoloDataContext Context = new WaterPoloDataContext();


        public abstract void Add(object Item);

        public abstract void Edit();


        public object CurrentItem
        {
            get => _currentItem;
            set { SetProperty(ref _currentItem, value, () => CurrentItem); }
        }

        public abstract object GetItemSource();

        public virtual void Save()
        {
            Context.SaveChanges();
        }

        public virtual void Import(string path)
        {
        }

        public void Export(string fileName)
        {
        }

        public abstract object NewItem();

        public abstract void Delete();
    }
}