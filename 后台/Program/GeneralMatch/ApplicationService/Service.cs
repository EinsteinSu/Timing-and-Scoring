using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Runtime.Remoting;
using System.Collections;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Serialization.Formatters;

namespace ApplicationService
{
    public class Service : ApplicationCommon.IXmlHelper
    {
        #region attributes
        private string _serviceName;
        /// <summary>
        /// serviceName
        /// </summary>
        public string SERVICENAME
        {
            get { return _serviceName; }
            set { _serviceName = value; }
        }

        private string _serviceDes;
        /// <summary>
        /// serviceDes
        /// </summary>
        public string SERVICEDES
        {
            get { return _serviceDes; }
            set { _serviceDes = value; }
        }

        private bool _bService;
        /// <summary>
        /// bService
        /// </summary>
        public bool BSERVICE
        {
            get { return _bService; }
            set { _bService = value; }
        }

        private string _dll;
        /// <summary>
        /// dll
        /// </summary>
        public string DLL
        {
            get { return _dll; }
            set { _dll = value; }
        }

        private string _modle;
        /// <summary>
        /// module
        /// </summary>
        public string MODLE
        {
            get { return _modle; }
            set { _modle = value; }
        }

        private bool _bStart;
        /// <summary>
        /// bStart
        /// </summary>
        public bool BSTART
        {
            get { return _bStart; }
            set { _bStart = value; }
        }

        public bool RegistService()
        {
            try
            {
                if (BSTART)
                {
                    Assembly ass = Assembly.LoadFile(String.Format(@"{0}\{1}", ApplicationCommon.DirectoryHelper.RunDirectory, DLL));
                    Type tp = ass.GetType(MODLE);
                    RemotingConfiguration.RegisterWellKnownServiceType(tp, SERVICENAME, WellKnownObjectMode.SingleCall);

                    #region SqlService
                    if (SERVICENAME == "SqlService")
                    {
                        RemoteCommon.SqlManager sm = new RemoteCommon.SqlManager();
                        try
                        {
                            sm.GetDataTable("select * from sysfiles");
                        }
                        catch
                        {
                            return false;
                        }
                        finally
                        {
                            sm.Dispose();
                        }
                    }
                    #endregion

                    return true;
                }
            }
            catch
            {
                return false;
            }
            return false;
        }
        #endregion

        public string FilePath
        {
            get { return ApplicationCommon.DirectoryHelper.DataDirectory; }
        }

        public string FileName
        {
            get { return "Services"; }
        }

        private static List<Service> _OnServices;
        /// <summary>
        /// OnServices
        /// </summary>
        public static List<Service> ONSERVICES
        {
            get
            {
                if (_OnServices == null)
                {
                    _OnServices = new List<Service>();
                    string path = string.Format(@"{0}\{1}", ApplicationCommon.DirectoryHelper.DataDirectory, "Services.xml");
                    if (System.IO.File.Exists(path))
                        _OnServices = (List<Service>)ApplicationCommon.XmlHelper.LoadXml(path, typeof(List<Service>));
                }
                return _OnServices;
            }
            set
            {
                _OnServices = value;
                ApplicationCommon.XmlHelper.SaveXml(string.Format(@"{0}\{1}", ApplicationCommon.DirectoryHelper.DataDirectory, "Services.xml"), _OnServices);
            }
        }

        public void Load()
        {
            _OnServices = new List<Service>();
            string path = string.Format(@"{0}\{1}", ApplicationCommon.DirectoryHelper.DataDirectory, "Services.xml");
            if (System.IO.File.Exists(path))
                _OnServices = (List<Service>)ApplicationCommon.XmlHelper.LoadXml(path, typeof(List<Service>));
        }

        public static bool RegistChannel()
        {
            try
            {
                IDictionary ht = new Hashtable();
                ht["port"] = ServicePort.ONSERVICEPORT.SYSTEMPORT;
                BinaryServerFormatterSinkProvider serverProv = new BinaryServerFormatterSinkProvider();
                serverProv.TypeFilterLevel = TypeFilterLevel.Full;
                BinaryClientFormatterSinkProvider clientProv = new BinaryClientFormatterSinkProvider();
                TcpChannel chan = new TcpChannel(ht, clientProv, serverProv);
                ChannelServices.RegisterChannel(chan, false);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}： \r\n功能：{1}", _serviceName,_serviceDes);
        }
    }
}
