using System.Windows;
using DevExpress.Mvvm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Demostration.DevExpress.MVVM.Test.UnitTest
{
    [TestClass]
    public class MVVMTest
    {
        [TestMethod]
        public void MessageBoxTest()
        {
            var serviceIsCalled = false;
            var viewModel = new MainWindowViewModel();
            var service = new Mock<IMessageBoxService>(MockBehavior.Strict);
            service.Setup(foo => foo.Show(
                "Want to save your change?", "Document", MessageBoxButton.YesNo)).Returns((string text, string caption,
                MessageBoxButton button) =>
            {
                serviceIsCalled = true;
                return MessageBoxResult.Yes;
            });
            ((ISupportServices)viewModel).ServiceContainer.RegisterService(service.Object);
            viewModel.ShowDocumentCommand.Execute(DocumentType.Text);
            Assert.IsTrue(serviceIsCalled);
        }
    }
}