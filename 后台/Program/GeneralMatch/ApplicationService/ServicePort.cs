using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationService
{
    public class ServicePort : ApplicationCommon.IXmlHelper
    {
        private int _SystemPort;
        /// <summary>
        /// SystemPort
        /// </summary>
        public int SYSTEMPORT
        {
            get { return _SystemPort; }
            set { _SystemPort = value; }
        }

        private int _BroadCastPort;
        /// <summary>
        /// BroadCastPort
        /// </summary>
        public int BROADCASTPORT
        {
            get { return _BroadCastPort; }
            set { _BroadCastPort = value; }
        }


        private static ServicePort _OnServicePort;
        /// <summary>
        /// OnServicePort
        /// </summary>
        public static ServicePort ONSERVICEPORT
        {
            get
            {
                if (_OnServicePort == null)
                {
                    _OnServicePort = new ServicePort();
                    _OnServicePort.Load();
                }
                return _OnServicePort;
            }
            set
            {
                _OnServicePort = value;
                ApplicationCommon.XmlHelper.SaveXml(_OnServicePort);
            }
        }


        public string FilePath
        {
            get { return ApplicationCommon.DirectoryHelper.DataDirectory; }
        }

        public string FileName
        {
            get { return "ServicePort"; }
        }

        public void Load()
        {
            ServicePort s = new ServicePort();
            if (System.IO.File.Exists(ApplicationCommon.XmlHelper.GetFileName(s)))
                _OnServicePort = (ServicePort)ApplicationCommon.XmlHelper.LoadXml(s);

        }
    }
}
