using System.Windows;
using DevExpress.Mvvm;

namespace Demostration.DevExpress.MVVM.Test
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _test;

        public MainWindowViewModel()
        {
            ShowDocumentCommand = new DelegateCommand<DocumentType>(ExecuteMethod, RaiseCanExecute, false);
            Enabled = true;
        }

        public DelegateCommand<DocumentType> ShowDocumentCommand { get; set; }

        public IMessageBoxService MessageBoxService => GetService<IMessageBoxService>();

        public bool Enabled { get; set; }


        public string Test
        {
            get => _test;
            set => SetProperty(ref _test, value, "Test");
        }

        private void ExecuteMethod(DocumentType documentType)
        {
            var result =
                MessageBoxService.Show("Want to save your change?", "Document", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                Test = "True";
            }
        }

        private bool RaiseCanExecute(DocumentType type)
        {
            return Enabled;
        }
    }

    public enum DocumentType
    {
        Text,
        Data
    }
}