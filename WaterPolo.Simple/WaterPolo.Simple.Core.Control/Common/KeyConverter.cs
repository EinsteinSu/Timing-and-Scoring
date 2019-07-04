using DevExpress.Mvvm.UI;
using System.Windows.Input;

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
            Key pressedKey = ((KeyEventArgs)args).Key;
            return pressedKey;
        }
        #endregion
    }
}
