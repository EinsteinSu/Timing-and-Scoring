using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;
using System.IO;

namespace ApplicationCommon
{
    public static class DirectoryHelper
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public IntPtr iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        }
        /// <summary>
        /// 返回系统设置的图标
        /// </summary>
        /// <param name="pszPath">文件路径 如果为""  返回文件夹的</param>
        /// <param name="dwFileAttributes">0</param>
        /// <param name="psfi">结构体</param>
        /// <param name="cbSizeFileInfo">结构体大小</param>
        /// <param name="uFlags">枚举类型</param>
        /// <returns>-1失败</returns>
        [DllImport("shell32.dll")]
        public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref   SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);
        public enum SHGFI
        {
            SHGFI_ICON = 0x100,
            SHGFI_LARGEICON = 0x0,
            SHGFI_USEFILEATTRIBUTES = 0x10
        }
        /// <summary>
        /// 获取文件图标 zgke@sina.com qq:116149
        /// </summary>
        /// <param name="p_Path">文件全路径</param>
        /// <returns>图标</returns>
        public static Icon GetFileIcon(string p_Path)
        {
            SHFILEINFO _SHFILEINFO = new SHFILEINFO();
            IntPtr _IconIntPtr = SHGetFileInfo(p_Path, 0, ref _SHFILEINFO, (uint)Marshal.SizeOf(_SHFILEINFO), (uint)(SHGFI.SHGFI_ICON | SHGFI.SHGFI_LARGEICON | SHGFI.SHGFI_USEFILEATTRIBUTES));
            if (_IconIntPtr.Equals(IntPtr.Zero)) return null;
            Icon _Icon = System.Drawing.Icon.FromHandle(_SHFILEINFO.hIcon);
            return _Icon;
        }
        /// <summary>
        /// 获取文件夹图标  zgke@sina.com qq:116149
        /// </summary>
        /// <returns>图标</returns>
        public static Icon GetDirectoryIcon()
        {
            SHFILEINFO _SHFILEINFO = new SHFILEINFO();
            IntPtr _IconIntPtr = SHGetFileInfo(@"", 0, ref _SHFILEINFO, (uint)Marshal.SizeOf(_SHFILEINFO), (uint)(SHGFI.SHGFI_ICON | SHGFI.SHGFI_LARGEICON));
            if (_IconIntPtr.Equals(IntPtr.Zero)) return null;
            Icon _Icon = System.Drawing.Icon.FromHandle(_SHFILEINFO.hIcon);
            return _Icon;
        }


        /// <summary>
        /// 获取程序当前运行的目录名称
        /// </summary>
        /// <returns></returns>
        public static String RunDirectory
        {
            get
            {
                return System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            }
        }

        /// <summary>
        /// 数据文件路径
        /// </summary>
        /// <returns></returns>
        public static String DataDirectory
        {
            get
            {
                string path = string.Format(@"{0}\Data\", RunDirectory);
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                return string.Format(@"{0}\Data\", RunDirectory);
            }
        }

        /// <summary>
        /// 临时文件路径
        /// </summary>
        /// <returns></returns>
        public static String TempDirectory
        {
            get
            {
                string path = string.Format(@"{0}\Temp\", RunDirectory);
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                return string.Format(@"{0}\Temp\", RunDirectory);
            }
        }

        /// <summary>
        /// 日志文件路径
        /// </summary>
        /// <returns></returns>
        public static String LogDirectory
        {
            get
            {
                string path = string.Format(@"{0}\Logs\", RunDirectory);
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                return string.Format(@"{0}\Logs\", RunDirectory);
            }
        }

        /// <summary>
        /// 音效文件路径
        /// </summary>
        /// <returns></returns>
        public static String SoundDirectory
        {
            get
            {
                string path = string.Format(@"{0}\Sound\", RunDirectory);
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                return string.Format(@"{0}\Sound\", RunDirectory);
            }
        }

        /// <summary>
        /// 报表文件路径
        /// </summary>
        /// <returns></returns>
        public static String ReportDirectory
        {
            get
            {
                string path = string.Format(@"{0}\Report\", RunDirectory);
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                return string.Format(@"{0}\Report\", RunDirectory);
            }
        }

        /// <summary>
        /// 图片文件路径
        /// </summary>
        /// <returns></returns>
        public static String ImageDirectory
        {
            get
            {
                string path = string.Format(@"{0}\Images\", RunDirectory);
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                return string.Format(@"{0}\Images\", RunDirectory);
            }
        }

        /// <summary>
        /// 错误文件路径
        /// </summary>
        /// <returns></returns>
        public static String ErrorDirectory
        {
            get
            {
                string path = string.Format(@"{0}\Errors\", RunDirectory);
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                return string.Format(@"{0}\Errors\", RunDirectory);
            }
        }

        /// <summary>
        /// 错误文件路径
        /// </summary>
        /// <returns></returns>
        public static String BackupDirectory
        {
            get
            {
                string path = string.Format(@"{0}\Backup\", RunDirectory);
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                return string.Format(@"{0}\Backup\", RunDirectory);
            }
        }

        /// <summary>
        /// 用户UI路径
        /// </summary>
        /// <returns></returns>
        public static String UserInterfaceDirectory
        {
            get
            {
                string path = string.Format(@"{0}\UserInterface\", RunDirectory);
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                return string.Format(@"{0}\UserInterface\", RunDirectory);
            }
        }

        /// <summary>
        /// 广播历史路径
        /// </summary>
        public static String BroadCastDirectory
        {
            get
            {
                string path = string.Format(@"{0}\BroadCasts\", LogDirectory);
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                return string.Format(@"{0}\BroadCasts\", LogDirectory);
            }
        }

        public static String UpdateDirectory
        {
            get
            {
                string path = string.Format(@"{0}\Update\", RunDirectory);
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                return string.Format(@"{0}\Update\", RunDirectory);
            }
        }

        public static String HelpDirectory
        {
            get
            {
                string path = string.Format(@"{0}\Help\", RunDirectory);
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                return string.Format(@"{0}\Help\", RunDirectory);
            }
        }

        public static string GetFilePath(string fileName)
        {
            return Path.GetDirectoryName(fileName);
        }

        public static string GetFileName(string fileName)
        {
            return Path.GetFileName(fileName);
        }

        public static string GetFileNameUnExtension(string fileName)
        {
            return Path.GetFileName(fileName).Substring(0, Path.GetFileName(fileName).LastIndexOf('.'));
        }
    }
}
