using System.Data.Entity;
using System.Windows;
using DevExpress.Mvvm;
using Newtonsoft.Json;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.DataCenter.DataEdit
{
    public abstract class DataManagerBase : ViewModelBase, IDataManager
    {
        private object _currentItem;
        protected WaterPoloDataContext Context = new WaterPoloDataContext();


        public abstract void Add(object item);

        public virtual void Edit(object item)
        {
            Context.Entry(item).State = EntityState.Modified;
            Context.SaveChanges();
        }


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
        public virtual void Copy()
        {
            if (CurrentItem != null)
            {
                var data = JsonConvert.SerializeObject(CurrentItem, Formatting.None, new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
                Clipboard.SetText(data);
            }
        }

        public virtual void Paste()
        {
            var data = ConvertDataFromText(Clipboard.GetText());
            Add(data);
        }

        protected abstract object ConvertDataFromText(string data);

        public abstract void Delete();
    }
}