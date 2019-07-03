using DevExpress.Mvvm;
using System.Windows;

namespace WaterPolo.Simple.DataCenter.DataEdit.EditWindow
{
    public abstract class EditWindowViewModelBase<T, TC> : ViewModelBase, IDialogWindow where TC : FrameworkElement, new()
    {
        protected readonly TC content;
        public T Data { get; set; }
        public EditWindowViewModelBase(T data)
        {
            Data = data;
            content = new TC { DataContext = this };
        }

        public abstract string Title { get; }
        public virtual FrameworkElement Content => content;
        protected abstract string Check();

        public virtual bool Confirm()
        {
            if (!string.IsNullOrEmpty(Check()))
            {
                MessageBox.Show(Check());
                return false;
            }

            return true;
        }

        public virtual bool Cancel()
        {
            return true;
        }
    }
}