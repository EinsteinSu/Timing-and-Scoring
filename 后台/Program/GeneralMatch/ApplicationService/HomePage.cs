using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;
using System.Runtime.Serialization.Formatters;
using System.Collections;
using System.Runtime.Remoting.Channels.Http;
using RemoteCommon;
using System.Runtime.Remoting;

namespace ApplicationService
{
    public partial class HomePage : ApplicationControlCommon.NotifyForm
    {
        public HomePage()
        {
            InitializeComponent();
            btInfo_Click(null, null);
            btBroadCast.Enabled = StartBroadCastService();
            if (btBroadCast.Enabled)
                infoctrl.SetText(string.Format("Http端口为{0}广播服务已开启。", ServicePort.ONSERVICEPORT.BROADCASTPORT));
            else
                infoctrl.SetText(string.Format("Http端口为{0}广播服务未能开启。", ServicePort.ONSERVICEPORT.BROADCASTPORT));
        }

        private void btInfo_Click(object sender, EventArgs e)
        {
            pcService.ShowControl(typeof(InfomationControl), DockStyle.Fill);
        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            pcService.ShowControl(typeof(SettingControl), DockStyle.Fill);
        }

        private void btBroadCast_Click(object sender, EventArgs e)
        {
            pcService.ShowControl(typeof(BroadCastControl), DockStyle.Fill);
        }

        public static BroadCastObj bcObj = null;

        public bool StartBroadCastService()
        {
            try
            {
                BinaryServerFormatterSinkProvider serverProvider = new BinaryServerFormatterSinkProvider();
                BinaryClientFormatterSinkProvider clientProvider = new BinaryClientFormatterSinkProvider();
                serverProvider.TypeFilterLevel = TypeFilterLevel.Full;

                IDictionary props = new Hashtable();
                props["port"] = ServicePort.ONSERVICEPORT.BROADCASTPORT;
                HttpChannel channel = new HttpChannel(props, clientProvider, serverProvider);
                ChannelServices.RegisterChannel(channel);

                #region 客户端订阅服务端事件

                bcObj = new BroadCastObj();
                ObjRef objRef = RemotingServices.Marshal(bcObj, "BroadCastMessage.soap");

                #endregion
                return true;
            }
            catch
            {
                return false;
            }
        }

        InfomationControl infoctrl;
        private void pcService_ShowControled(Control ctrl)
        {
            if (ctrl.GetType() == typeof(InfomationControl))
                infoctrl = ctrl as InfomationControl;
            gbFunctions.Text = ctrl.ToString();
        }

        private void btTools_Click(object sender, EventArgs e)
        {
            pcService.ShowControl(typeof(ToolsControl), DockStyle.Fill);
        }
    }
}
