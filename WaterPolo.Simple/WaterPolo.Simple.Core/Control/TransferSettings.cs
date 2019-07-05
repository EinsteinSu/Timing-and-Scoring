using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;

namespace WaterPolo.Simple.Core.Control
{
    public class TransferSettings : ViewModelBase
    {
        private string _ipAddress;
        private int _port;

        public string IpAddress
        {
            get => _ipAddress;
            set => SetProperty(ref _ipAddress, value, () => IpAddress);
        }

        public int Port
        {
            get => _port;
            set => SetProperty(ref _port, value, () => Port);
        }
    }
}
