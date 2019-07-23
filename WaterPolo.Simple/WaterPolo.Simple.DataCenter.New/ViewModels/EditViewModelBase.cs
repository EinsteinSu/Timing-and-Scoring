using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.DataCenter.New.ViewModels
{
    public abstract class EditViewModelBase<T>
    {
        protected WaterPoloDataContext Context;

        public EditViewModelBase()
        {
            Refresh();
        }

        public virtual T CurrentItem { get; set; }

        public virtual ObservableCollection<T> Items { get; set; }

        public virtual void Refresh()
        {
            Context = new WaterPoloDataContext();
            var dep = new DependencyObject();
            if (!DesignerProperties.GetIsInDesignMode(dep))
            {
                RefreshItems();
            }
        }

        public bool CanRefresh()
        {
            return !Context.HasChanged();
        }

        public abstract void Add();

        public virtual void Remove()
        {
            if (CurrentItem != null)
            {
                RemoveItem();
            }
        }

        protected abstract void RemoveItem();

        public bool CanRemove()
        {
            return CurrentItem != null;
        }

        public virtual void Save()
        {
            Context.SaveChanges();
        }

        public bool CanSave()
        {
            return Context.HasChanged();
        }


        protected abstract void RefreshItems();
    }
}