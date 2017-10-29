using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RemoteCommon;
using System.Runtime.Remoting.Channels;
using System.Runtime.Serialization.Formatters;
using System.Collections;
using System.Runtime.Remoting.Channels.Http;
using System.Threading;
using System.Windows.Forms;

namespace ClientControlCommon
{
    public class BroadcastPanel : System.Windows.Forms.Panel
    {
        public BroadcastPanel()
        {
            this.BackgroundImage = Properties.Resources.BroadCast;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        }

        private EventWrapper wrapper = null;
        private IBroadCast watch = null;
        public void LoadBroadCast()
        {
            BinaryServerFormatterSinkProvider serverProvider = new BinaryServerFormatterSinkProvider();
            BinaryClientFormatterSinkProvider clientProvider = new BinaryClientFormatterSinkProvider();
            serverProvider.TypeFilterLevel = TypeFilterLevel.Full;

            IDictionary props = new Hashtable();
            props["port"] = 0;
            HttpChannel channel = new HttpChannel(props, clientProvider, serverProvider);
            ChannelServices.RegisterChannel(channel);

            watch = (IBroadCast)Activator.GetObject(
                typeof(IBroadCast), ClientCommon.RemoteConnect.ONREMOTE.BroadCastUrl);

            wrapper = new EventWrapper();
            wrapper.LocalBroadCastEvent += new BroadCastEventHandler(wrapper_LocalBroadCastEvent);
            watch.BroadCastEvent += new BroadCastEventHandler(wrapper.BroadCasting);
        }

        static int count = 0;
        void wrapper_LocalBroadCastEvent(string info)
        {
            count++;
            ClientCommon.LogWrite.WriteBroadcastLogs(string.Format("{0}：\r\n{1}", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), info));
            ShowBlink();
            ApplicationCommon.SoundHelper.PlaySound("message.wav");
        }

        public delegate void BlinkCallback();
        public void ShowBlink()
        {
            if (base.InvokeRequired)
            {
                BlinkCallback d = new BlinkCallback(ShowBlink);
                base.Invoke(d);
            }
            else
            {
                if (th == null)
                {
                    th = new Thread(Blink);
                    th.Start();
                }
            }
        }

        public void EndShow()
        {
            if (th != null)
                th.Abort();
            th = null;
            base.BackgroundImage = Properties.Resources.BroadCast;
        }

        public void CancelBroadCast()
        {
            try
            {
                watch.BroadCastEvent -= new BroadCastEventHandler(wrapper.BroadCasting);
            }
            catch { }
        }

        Thread th;
        public void Blink()
        {
            while (true)
            {
                if (base.BackgroundImage == null)
                    base.BackgroundImage = Properties.Resources.BroadCast;
                else
                    base.BackgroundImage = null;
                Thread.Sleep(300);
            }
        }

        ToolTip tt;
        bool bShow;
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (tt == null)
                tt = new ToolTip();
            string str = string.Empty;
            if (count > 0)
                str = string.Format("您有{0}条广播，未读取！", count);
            else
                str = string.Format("您无广播信息！");
            if (!bShow)
            {
                tt.SetToolTip(this, str);
                bShow = true;
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            bShow = false;
        }

        protected override void OnClick(EventArgs e)
        {
            BroadcastForm frm = new BroadcastForm();
            EndShow();
            frm.Show();
        }
    }
}
