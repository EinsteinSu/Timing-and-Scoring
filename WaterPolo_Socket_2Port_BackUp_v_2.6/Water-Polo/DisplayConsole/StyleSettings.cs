using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace DisplayConsole
{
    public class StyleSettings : ApplicationCommon.IXmlHelper
    {
        private string _BibNumberFont = FontToString(Fonts.DefaultFont);
        /// <summary>
        /// 号码字体
        /// </summary>
        public string BIBNUMBERFont
        {
            get { return _BibNumberFont; }
            set { _BibNumberFont = value; }
        }

        private string _NameFont = FontToString(Fonts.DefaultFont);
        /// <summary>
        /// 姓名字体
        /// </summary>
        public string NAMEFont
        {
            get { return _NameFont; }
            set { _NameFont = value; }
        }

        private string _FoulsFont = FontToString(Fonts.DefaultFont);
        /// <summary>
        /// 犯规字体
        /// </summary>
        public string FOULSFont
        {
            get { return _FoulsFont; }
            set { _FoulsFont = value; }
        }

        private string _SeriousFont = FontToString(Fonts.DefaultFont);
        /// <summary>
        /// 严重犯规字体
        /// </summary>
        public string SERIOUSFont
        {
            get { return _SeriousFont; }
            set { _SeriousFont = value; }
        }

        private string _SecondsFont = FontToString(Fonts.DefaultFont);
        /// <summary>
        /// 20秒字体
        /// </summary>
        public string SECONDSFont
        {
            get { return _SecondsFont; }
            set { _SecondsFont = value; }
        }

        private string _BibNumberColor = ColorToString(Color.Black);
        /// <summary>
        /// 号码颜色
        /// </summary>
        public string BIBNUMBERCOLOR
        {
            get { return _BibNumberColor; }
            set { _BibNumberColor = value; }
        }

        private string _NameColor = ColorToString(Color.Black);
        /// <summary>
        /// 姓名颜色
        /// </summary>
        public string NAMECOLOR
        {
            get { return _NameColor; }
            set { _NameColor = value; }
        }

        private string _FoulsColor = ColorToString(Color.Black);
        /// <summary>
        /// 犯规颜色
        /// </summary>
        public string FOULSCOLOR
        {
            get { return _FoulsColor; }
            set { _FoulsColor = value; }
        }

        private string _SeriousColor = ColorToString(Color.Black);
        /// <summary>
        /// 严重犯规颜色
        /// </summary>
        public string SERIOUSCOLOR
        {
            get { return _SeriousColor; }
            set { _SeriousColor = value; }
        }


        private string _SecondsColor = ColorToString(Color.Black);
        /// <summary>
        /// 20秒颜色
        /// </summary>
        public string SECONDSCOLOR
        {
            get { return _SecondsColor; }
            set { _SecondsColor = value; }
        }

        private static StyleSettings _OnSettings;
        /// <summary>
        /// 20秒颜色
        /// </summary>
        public static StyleSettings ONSETTINGS
        {
            get
            {
                if (_OnSettings == null)
                {
                    _OnSettings = new StyleSettings();
                    _OnSettings.Load();
                }
                return _OnSettings;
            }
            set
            {
                _OnSettings = value;
                ApplicationCommon.XmlHelper.SaveXml(_OnSettings);
            }
        }

        public string FileName
        {
            get { return "Style"; }
        }

        public string FilePath
        {
            get { return ApplicationCommon.DirectoryHelper.DataDirectory; }
        }

        public void Load()
        {
            StyleSettings s = new StyleSettings();
            if (System.IO.File.Exists(ApplicationCommon.XmlHelper.GetFileName(s)))
                _OnSettings = (StyleSettings)ApplicationCommon.XmlHelper.LoadXml(s);
        }

        public static string FontToString(Font f)
        {
            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Font));
            string fontString = tc.ConvertToString(f);
            return fontString;
        }

        public static Font StringToFont(string str)
        {
            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Font));
            Font f = (Font)tc.ConvertFromString(str);
            return f;
        }

        public static string ColorToString(Color c)
        {
            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Color));
            string colorString = tc.ConvertToString(c);
            return colorString;
        }

        public static Color StringToColor(string str)
        {
            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Color));
            Color c = (Color)tc.ConvertFromString(str);
            return c;
        }
    }
}
