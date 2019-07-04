using System.Windows;

namespace WaterPolo.Simple.DataCenter.DataEdit.EditWindow
{
    public interface IDialogWindow
    {
        string Title { get; }

        FrameworkElement Content { get; }

        bool Confirm();

        bool Cancel();
    }

    public static class DialogWindowHelper
    {
        public static bool Show(this IDialogWindow context)
        {
            var window = new DialogWindow();
            window.DataContext = context;
            var result = window.ShowDialog();
            if (result.HasValue && result.Value) return true;

            return false;
        }
    }
}