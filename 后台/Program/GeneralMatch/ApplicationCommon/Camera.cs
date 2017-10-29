using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Forms;

namespace ApplicationCommon
{
    public class Camera
    {
        private const int WM_USER = 0x400;
        private const int WS_CHILD = 0x40000000;
        private const int WS_VISIBLE = 0x10000000;
        private const int WM_CAP_START = WM_USER;
        private const int WM_CAP_STOP = WM_CAP_START + 68;
        private const int WM_CAP_DRIVER_CONNECT = WM_CAP_START + 10;
        private const int WM_CAP_DRIVER_DISCONNECT = WM_CAP_START + 11;
        private const int WM_CAP_SAVEDIB = WM_CAP_START + 25;
        private const int WM_CAP_CUTIMAGE = 0x41e;        //剪切当前图像
        private const int WM_CAP_GRAB_FRAME = WM_CAP_START + 60;
        private const int WM_CAP_SEQUENCE = WM_CAP_START + 62;
        private const int WM_CAP_FILE_SET_CAPTURE_FILEA = WM_CAP_START + 20;
        private const int WM_CAP_SEQUENCE_NOFILE = WM_CAP_START + 63;
        private const int WM_CAP_SET_OVERLAY = WM_CAP_START + 51;
        private const int WM_CAP_SET_PREVIEW = WM_CAP_START + 50;
        private const int WM_CAP_SET_CALLBACK_VIDEOSTREAM = WM_CAP_START + 6;
        private const int WM_CAP_SET_CALLBACK_ERROR = WM_CAP_START + 2;
        private const int WM_CAP_SET_CALLBACK_STATUSA = WM_CAP_START + 3;
        private const int WM_CAP_SET_CALLBACK_FRAME = WM_CAP_START + 5;
        private const int WM_CAP_SET_SCALE = WM_CAP_START + 53;
        private const int WM_CAP_SET_PREVIEWRATE = WM_CAP_START + 52;
        private const int WM_CAP_DLG_VIDEOFORMAT = WM_CAP_START + 41;
        private const int WM_CAP_DLG_VIDEOSOURCE = WM_CAP_START + 42;
        private const int WM_CAP_DLG_VIDEODISPLAY = WM_CAP_START + 43;
        private const int WM_CAP_DLG_VIDEOCOMPRESSION = WM_CAP_START + 46;

        private IntPtr hWndC;
        private bool bStat = false;

        private IntPtr mControlPtr;
        private int mWidth;
        private int mHeight;
        private int mLeft;
        private int mTop;

        /// <summary>
        /// 初始化摄像头
        /// </summary>
        /// <param name="handle">控件的句柄</param>
        /// <param name="left">开始显示的左边距</param>
        /// <param name="top">开始显示的上边距</param>
        /// <param name="width">要显示的宽度</param>
        /// <param name="height">要显示的长度</param>
        public Camera(IntPtr handle, int left, int top, int width, int height)
        {
            mControlPtr = handle;
            mWidth = width;
            mHeight = height;
            mLeft = left;
            mTop = top;
        }

        [DllImport("avicap32.dll")]
        //private static extern IntPtr capCreateCaptureWindowA(byte[] lpszWindowName, int dwStyle, int x, int y, int nWidth, int nHeight, IntPtr hWndParent, int nID);
        private static extern IntPtr capCreateCaptureWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszWindowName, int dwStyle, int x, int y, int nWidth, int nHeight, IntPtr hWndParent, int nID);

        [DllImport("avicap32.dll")]
        private static extern int capGetVideoFormat(IntPtr hWnd, IntPtr psVideoFormat, int wSize);

        [DllImport("User32.dll")]
        private static extern bool SendMessage(IntPtr hWnd, int wMsg, int wParam, long lParam);

        [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern bool DestroyWindow(int hndw);

        private void capDlgVideoFormat()
        {
            Boolean capDlgVideoFormat = SendMessage(hWndC, WM_CAP_DLG_VIDEOFORMAT, 0, 0);
        }

        private void capDlgVideoSource()
        {
            Boolean capDlgVideoSource = SendMessage(hWndC, WM_CAP_DLG_VIDEOSOURCE, 0, 0);
        }

        private void capDlgVideoDisplay()
        {
            Boolean capDlgVideoDisplay = SendMessage(hWndC, WM_CAP_DLG_VIDEODISPLAY, 0, 0);
        }

        private void capDlgVideoCompression()
        {
            Boolean capDlgVideoCompression = SendMessage(hWndC, WM_CAP_DLG_VIDEOCOMPRESSION, 0, 0);
        }

        /// <summary>
        /// 开始显示图像
        /// </summary>
        public void Start()
        {
            if (bStat)
                return;

            bStat = true;
            byte[] lpszName = new byte[100];

            //hWndC = capCreateCaptureWindowA(lpszName, WS_CHILD | WS_VISIBLE, mLeft, mTop, mWidth, mHeight, mControlPtr, 0);

            int intDevice = 0;
            string refDevice = intDevice.ToString();
            hWndC = capCreateCaptureWindowA(ref refDevice,
                1342177280,
                mLeft,
                mTop,
                mWidth,
                mHeight,
                mControlPtr,
                0);

            //Console.WriteLine("驱动:" + refDevice);

            if (SendMessage(hWndC, 0x40a, intDevice, 0))
            {
                //Console.WriteLine("摄像头正常");
            }
            else
            {

                //MessageBox.Show("未检测到摄像头");
                //throw new PCCameraException();
            }

            if (hWndC.ToInt32() != 0)
            {
                SendMessage(hWndC, WM_CAP_SET_CALLBACK_VIDEOSTREAM, 0, 0);
                SendMessage(hWndC, WM_CAP_SET_CALLBACK_ERROR, 0, 0);
                SendMessage(hWndC, WM_CAP_SET_CALLBACK_STATUSA, 0, 0);
                SendMessage(hWndC, WM_CAP_DRIVER_CONNECT, 0, 0);
                SendMessage(hWndC, WM_CAP_SET_SCALE, 1, 0);
                SendMessage(hWndC, WM_CAP_SET_PREVIEWRATE, 66, 0);
                SendMessage(hWndC, WM_CAP_SET_OVERLAY, 1, 0);
                SendMessage(hWndC, WM_CAP_SET_PREVIEW, 1, 0);
            }
            return;
        }

        /// <summary>
        /// 停止显示
        /// </summary>
        public void Stop()
        {
            SendMessage(hWndC, WM_CAP_DRIVER_DISCONNECT, 0, 0);
            bStat = false;
        }

        /// <summary>
        /// 抓图
        /// </summary>
        /// <param name="path">要保存文件的路径</param>
        public void GrabImage(string path)
        {
            try
            {
                IntPtr hBmp = Marshal.StringToHGlobalAnsi(path);

                //SendMessage(hWndC, WM_CAP_SAVEDIB, 0, hBmp.ToInt64()); //该方式无法控制保存图像格式

                SendMessage(hWndC, WM_CAP_CUTIMAGE, 0, 0);

                System.Windows.Forms.IDataObject dataObject = Clipboard.GetDataObject();

                if (dataObject.GetDataPresent(typeof(Bitmap)))
                {
                    Image img = (Image)dataObject.GetData(typeof(Bitmap));
                    img.Save(path, ImageFormat.Jpeg);
                }
            }
            catch (Exception exc)
            {
                //throw new CameraException(exc);
            }
        }

        public Byte[] GetPhoto()
        {
            try
            {
                string path = string.Format("{0}{1}",DirectoryHelper.TempDirectory, "Temp.jpg");
                GrabImage(path);
                Byte[] bt = BinaryHelper.FileToByte(path);
                //File.Delete(path);
                return bt;
            }
            catch { return null; }
        }

        /// <summary>
        /// 录像
        /// </summary>
        /// <param name="path">要保存avi文件的路径</param>
        public void Kinescope(string path)
        {
            IntPtr hBmp = Marshal.StringToHGlobalAnsi(path);
            SendMessage(hWndC, WM_CAP_FILE_SET_CAPTURE_FILEA, 0, hBmp.ToInt64());
            SendMessage(hWndC, WM_CAP_SEQUENCE, 0, 0);
        }

        /// <summary>
        /// 停止录像
        /// </summary>
        public void StopKinescope()
        {
            SendMessage(hWndC, WM_CAP_STOP, 0, 0);
        }


        /// <summary>
        /// 打开属性设置对话框，设置对比度、亮度等。
        /// (视频源对话框) 选择视频输入通道和视频图像的动态参数。
        /// </summary>
        public void ShowConfig()
        {
            SendMessage(hWndC, WM_CAP_DLG_VIDEOSOURCE, 0, 0);
        }
    }
}
