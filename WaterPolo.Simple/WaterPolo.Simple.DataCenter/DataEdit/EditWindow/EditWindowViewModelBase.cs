using System.Windows;

namespace WaterPolo.Simple.DataCenter.DataEdit.EditWindow
{
    public abstract class EditWindowViewModelBase<T, TC> : IDialogWindow where TC : FrameworkElement, new()
    {
        protected readonly TC content;
        protected T Data;
        public EditWindowViewModelBase(T data)
        {
            Data = data;
            content = new TC { DataContext = Data };
        }

        public virtual double Height => 300;

        public virtual double Width => 300;

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