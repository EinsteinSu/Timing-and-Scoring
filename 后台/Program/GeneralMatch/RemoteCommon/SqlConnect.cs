using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoteCommon
{
    public class SqlConnect : ApplicationCommon.IXmlHelper
    {
        #region attributes
        private string _IPAddress;
        /// <summary>
        /// IPAddress
        /// </summary>
        public string IPADDRESS
        {
            get { return _IPAddress; }
            set { _IPAddress = value; }
        }

        private string _DatabaseName;
        /// <summary>
        /// DatabaseName
        /// </summary>
        public string DATABASENAME
        {
            get { return _DatabaseName; }
            set { _DatabaseName = value; }
        }

        private string _UserName;
        /// <summary>
        /// UserName
        /// </summary>
        public string USERNAME
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        private string _PassWord;
        /// <summary>
        /// PassWord
        /// </summary>
        public string PASSWORD
        {
            get { return _PassWord; }
            set { _PassWord = value; }
        }
        private bool _ConnectType;
        /// <summary>
        /// ConnectType
        /// </summary>
        public bool CONNECTTYPE
        {
            get { return _ConnectType; }
            set { _ConnectType = value; }
        }

        private bool _isPort;
        /// <summary>
        /// isPort
        /// </summary>
        public bool ISPORT
        {
            get { return _isPort; }
            set { _isPort = value; }
        }

        private int _Port;
        /// <summary>
        /// Port
        /// </summary>
        public int PORT
        {
            get { return _Port; }
            set { _Port = value; }
        }
        #endregion


        private static SqlConnect _OnSqlConnect;
        /// <summary>
        /// OnSqlConnect
        /// </summary>
        public static SqlConnect ONSQLCONNECT
        {
            get
            {
                if (_OnSqlConnect == null)
                {
                    _OnSqlConnect = new SqlConnect();
                    _OnSqlConnect.Load();
                }
                return _OnSqlConnect;
            }
            set
            {
                _OnSqlConnect = value;
                ApplicationCommon.XmlHelper.SaveXml(_OnSqlConnect);
            }
        }


        public string FilePath
        {
            get { return ApplicationCommon.DirectoryHelper.DataDirectory; }
        }

        public string FileName
        {
            get { return "SqlConnect"; }
        }

        public void Load()
        {
            SqlConnect s = new SqlConnect();
            if (System.IO.File.Exists(ApplicationCommon.XmlHelper.GetFileName(s)))
                _OnSqlConnect = (SqlConnect)ApplicationCommon.XmlHelper.LoadXml(s);
        }

        public static String ConnectString
        {
            get
            {
                if (ONSQLCONNECT.CONNECTTYPE)
                {
                    return string.Format(@"Data Source=localhost;Initial Catalog={0};Integrated Security=True",ONSQLCONNECT.DATABASENAME);
                }
                else
                {
                    if (ONSQLCONNECT.ISPORT)
                        return string.Format("data source={0},{1};initial catalog={2};user id={3};password={4};", ONSQLCONNECT.IPADDRESS, ONSQLCONNECT.PORT,
                       ONSQLCONNECT.DATABASENAME, ONSQLCONNECT.USERNAME, ONSQLCONNECT.PASSWORD);
                    else
                        return string.Format("data source={0};initial catalog={1};user id={2};password={3};", ONSQLCONNECT.IPADDRESS,
                   ONSQLCONNECT.DATABASENAME, ONSQLCONNECT.USERNAME, ONSQLCONNECT.PASSWORD);

                }
            }
        }
    }
}
