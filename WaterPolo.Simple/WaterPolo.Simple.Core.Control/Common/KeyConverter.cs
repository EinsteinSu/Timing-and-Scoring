using System.Windows.Input;
using DevExpress.Mvvm.UI;

namespace WaterPolo.Simple.Core.Control.Common
{
    public class KeyConverter : IEventArgsConverter
    {
        #region IEventArgsConverter Members

        //public object Convert(object args)
        //{
        //    Key pressedKey = ((KeyEventArgs)args).Key;
        //    return pressedKey;
        //}

        object IEventArgsConverter.Convert(object sender, object args)
        {
            //throw new NotImplementedException();
            var pressedKey = ((KeyEventArgs) args).Key;
            return pressedKey;
        }

        #endregion
    }
}