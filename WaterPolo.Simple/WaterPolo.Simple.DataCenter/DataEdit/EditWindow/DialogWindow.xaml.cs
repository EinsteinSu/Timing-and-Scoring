using System.Windows;

namespace WaterPolo.Simple.DataCenter.DataEdit.EditWindow
{
    /// <summary>
    ///     Interaction logic for DialogWindow.xaml
    /// </summary>
    public partial class DialogWindow : Window
    {
        public DialogWindow()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is IDialogWindow context && context.Confirm())
            {
                DialogResult = true;
                Close();
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is IDialogWindow context && context.Cancel())
            {
                DialogResult = false;
                Close();
            }
        }
    }
}