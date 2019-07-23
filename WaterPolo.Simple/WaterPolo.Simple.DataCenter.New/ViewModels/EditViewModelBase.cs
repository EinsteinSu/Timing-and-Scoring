using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Windows;
using CsvHelper;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using WaterPolo.Simple.DataAccess;

namespace WaterPolo.Simple.DataCenter.New.ViewModels
{
    public abstract class EditViewModelBase<T, TIE> where T : new()
    {
        protected WaterPoloDataContext Context;
        protected ISaveFileDialogService SaveFileDialogService => this.GetService<ISaveFileDialogService>();
        protected IOpenFileDialogService OpenFileDialogService => this.GetService<IOpenFileDialogService>();
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

        public virtual void Add()
        {
            var data = new T();
            AddItem(data);
        }

        protected abstract void AddItem(T item);

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

        public virtual void Import()
        {
            if (OpenFileDialogService == null)
                return;
            OpenFileDialogService.Filter = "Csv Files (.csv)|*.csv|All Files (*.*)|*.*";
            OpenFileDialogService.FilterIndex = 1;
            var dialogResult = OpenFileDialogService.ShowDialog();
            if (!dialogResult)
                return;
            using (var reader = new StreamReader(OpenFileDialogService.GetFullFileName()))
            {
                using (var csv = new CsvReader(reader))
                {
                    var list = csv.GetRecords<TIE>();
                    foreach (var data in list)
                    {
                        AddItem(ConvertFromImportData(data));
                    }
                }
            }
        }

        protected abstract T ConvertFromImportData(TIE importData);

        protected abstract TIE ConvertToExportData(T data);

        public virtual void Export()
        {
            if (SaveFileDialogService == null)
                return;
            SaveFileDialogService.DefaultExt = "csv";
            SaveFileDialogService.DefaultFileName = "Export data";
            SaveFileDialogService.Filter = "Csv Files (.csv)|*.csv|All Files (*.*)|*.*";
            SaveFileDialogService.FilterIndex = 1;
            var dialogResult = SaveFileDialogService.ShowDialog();
            if (!dialogResult)
                return;
            var list = new List<TIE>();
            foreach (T item in Items)
            {
                list.Add(ConvertToExportData(item));
            }
            using (var writer = new StreamWriter(SaveFileDialogService.GetFullFileName()))
            {
                using (var csv = new CsvWriter(writer))
                {
                    csv.WriteRecords(list);
                }
            }
        }

        protected abstract void RefreshItems();
    }
}