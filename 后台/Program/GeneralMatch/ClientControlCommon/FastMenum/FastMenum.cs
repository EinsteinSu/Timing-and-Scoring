using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientControlCommon
{
    public class FastMenum
    {
        public FastMenum()
        {

        }

        public FastMenum(string guid)
        {
            _FunctionGuid = guid;
            _UserGuid = ClientCommon.SystemUsers.ONUSERS.GUID;
        }


        private string _UserGuid;
        /// <summary>
        /// UserGuid
        /// </summary>
        public string USERGUID
        {
            get { return _UserGuid; }
            set { _UserGuid = value; }
        } 

        private string _FunctionGuid;
        /// <summary>
        /// FunctionGuids
        /// </summary>
        public string FUNCTIONGUID
        {
            get { return _FunctionGuid; }
            set { _FunctionGuid = value; }
        }

        private static List<FastMenum> _OnFastMenum;
        /// <summary>
        /// OnFastMenum
        /// </summary>
        public static List<FastMenum> ONFASTMENUM
        {
            get
            {
                if (_OnFastMenum == null)
                {
                    _OnFastMenum = new List<FastMenum>();
                    string filePath = string.Format("{0}/{1}", ApplicationCommon.DirectoryHelper.DataDirectory, "FastMenum.xml");
                    if (System.IO.File.Exists(filePath))
                        _OnFastMenum = (List<FastMenum>)ApplicationCommon.XmlHelper.LoadXml(filePath, typeof(List<FastMenum>));
                }
                return _OnFastMenum;
            }
            set
            {
                _OnFastMenum = value;
                string filePath = string.Format("{0}/{1}", ApplicationCommon.DirectoryHelper.DataDirectory, "FastMenum.xml");
                ApplicationCommon.XmlHelper.SaveXml(filePath, _OnFastMenum, typeof(List<FastMenum>));
            }
        }

        public static void Add(string guid)
        {
            if (!IsHave(guid))
            {
                _OnFastMenum.Add(new FastMenum(guid));
                ONFASTMENUM = ONFASTMENUM;
            }
            else
                System.Windows.Forms.MessageBox.Show("该功能已经存在！");
        }

        public static void Delete(string guid)
        {
            var c = from data in ONFASTMENUM
                    where data.FUNCTIONGUID == guid && data.USERGUID == ClientCommon.SystemUsers.ONUSERS.GUID
                    select data;
            if (c.Count() > 0)
                ONFASTMENUM.Remove(c.ToList()[0]);
        }

        public static bool IsHave(string guid)
        {
            var c = from data in ClientCommon.Functions.ONFUNCTIONS
                    from fast in ONFASTMENUM
                    where data.GUID == guid && fast.FUNCTIONGUID == guid && fast.USERGUID == ClientCommon.SystemUsers.ONUSERS.GUID
                    select data;
            if (c.Count() > 0)
                return true;
            return false;
        }

        public void Load()
        {
            string filePath = string.Format("{0}/{1}", ApplicationCommon.DirectoryHelper.DataDirectory, "FastMenum.xml");
            if (System.IO.File.Exists(filePath))
                _OnFastMenum = (List<FastMenum>)ApplicationCommon.XmlHelper.LoadXml(filePath, typeof(List<FastMenum>));
        }
    }
}
