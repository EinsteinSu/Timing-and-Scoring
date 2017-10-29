using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoteCommon
{
    [Serializable]
    public class SystemRelease : ApplicationCommon.IXmlHelper
    {
        #region attributes
        private string _Release;
        /// <summary>
        /// Release
        /// </summary>
        public string RELEASE
        {
            get { return _Release; }
            set { _Release = value; }
        }

        private string _FileName;
        /// <summary>
        /// FileName
        /// </summary>
        public string FILENAME
        {
            get { return _FileName; }
            set { _FileName = value; }
        }

        private string _Remarks;
        /// <summary>
        /// Remarks
        /// </summary>
        public string REMARKS
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }
        #endregion

        private static List<SystemRelease> _OnRelease;
        /// <summary>
        /// OnRelease
        /// </summary>
        public static List<SystemRelease> ONRELEASE
        {
            get
            {
                if (_OnRelease == null)
                {
                    _OnRelease = new List<SystemRelease>();
                    string path = ApplicationCommon.DirectoryHelper.DataDirectory + "Releases.xml";
                    if (System.IO.File.Exists(path))
                        _OnRelease = (List<SystemRelease>)ApplicationCommon.XmlHelper.LoadXml(path, typeof(List<SystemRelease>));
                }
                return _OnRelease;
            }
            set
            {
                _OnRelease = value;
                ApplicationCommon.XmlHelper.SaveXml(ApplicationCommon.DirectoryHelper.DataDirectory + "Releases.xml", _OnRelease, typeof(List<SystemRelease>));
            }
        }


        public string FilePath
        {
            get { return ApplicationCommon.DirectoryHelper.DataDirectory; }
        }

        public string FileName
        {
            get { return "Releases"; }
        }

        public static SystemRelease MaxRelease
        {
            get
            {
                var r = from data in ONRELEASE
                        orderby double.Parse(data.RELEASE) descending
                        select data;
                return r.ToList()[0];
            }
        }

        public void Load()
        {
            string path = ApplicationCommon.DirectoryHelper.DataDirectory + "Releases.xml";
            if (System.IO.File.Exists(path))
                _OnRelease = (List<SystemRelease>)ApplicationCommon.XmlHelper.LoadXml(path, typeof(List<SystemRelease>));
        }
    }
}
