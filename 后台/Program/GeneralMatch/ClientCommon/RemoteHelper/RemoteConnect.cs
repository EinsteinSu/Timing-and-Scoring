using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientCommon
{
    public class RemoteConnect:ApplicationCommon.IXmlHelper
    {
        #region attributes
        private string _IpAddress;
        /// <summary>
        /// IpAddress
        /// </summary>
        public string IPADDRESS
        {
            get { return _IpAddress; }
            set { _IpAddress = value; }
        }

        private int _BroadcastPort;
        /// <summary>
        /// BroadcastPort
        /// </summary>
        public int BROADCASTPORT
        {
            get { return _BroadcastPort; }
            set { _BroadcastPort = value; }
        }

        private int _ServicePort;
        /// <summary>
        /// ServicePort
        /// </summary>
        public int SERVICEPORT
        {
            get { return _ServicePort; }
            set { _ServicePort = value; }
        }
        #endregion

        private static RemoteConnect _OnRemote;
        /// <summary>
        /// OnService
        /// </summary>
        public static RemoteConnect ONREMOTE
        {
            get
            {
                if (_OnRemote == null)
                {
                    _OnRemote = new RemoteConnect();
                    _OnRemote.Load();
                }
                return _OnRemote;
            }
            set
            {
                _OnRemote = value;
                ApplicationCommon.XmlHelper.SaveXml(_OnRemote);
                RemoteUrl.RefreshUrl();
            }
        }


        public string FilePath
        {
            get { return ApplicationCommon.DirectoryHelper.DataDirectory; }
        }

        public string FileName
        {
            get { return "RemoteConnect"; }
        }

        public void Load()
        {
            RemoteConnect r = new RemoteConnect();
            if (System.IO.File.Exists(ApplicationCommon.XmlHelper.GetFileName(r)))
                _OnRemote = (RemoteConnect)ApplicationCommon.XmlHelper.LoadXml(r);
        }

        public static string GetRemoteUrl(string serviceName)
        {
            return String.Format("tcp://{0}:{1}/{2}", ONREMOTE.IPADDRESS, ONREMOTE.SERVICEPORT, serviceName);
        }

        public string BroadCastUrl
        {
            get
            {
                return String.Format("http://{0}:{1}/{2}", ONREMOTE.IPADDRESS, ONREMOTE.BROADCASTPORT, "BroadCastMessage.soap");
            }
        }
    }
}
