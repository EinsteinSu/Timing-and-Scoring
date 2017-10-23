using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Net;

namespace SocketPublic
{
    public class SocketListening
    {
        public SocketListening(int port)
        {
            sb = new StringBuilder();
            RegistPort(port);
            RECORD = string.Format("Channel registered successfully,Start listening!");
            StartListening();
        }

        public Socket s { get; set; }
        public IPAddress ip { get; set; }

        //注册Socket
        public void RegistPort(int port)
        {
            try
            {
                IPHostEntry ipHost = Dns.Resolve(Dns.GetHostName());
                ip = ipHost.AddressList[0];
                IPEndPoint ipe = new IPEndPoint(ip, port);
                s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//创建一个Socket类
                s.Bind(ipe);
                s.Listen(0);
                RECORD = string.Format("Channel registered successfully!");
            }
            catch (ArgumentNullException e)
            {
                RECORD = string.Format("error:{0}", e);
            }
            catch (SocketException e)
            {
                RECORD = string.Format("Socket error:{0}", e);
            }
        }

        public delegate void ProcessMessageCallback(string msg);
        public event ProcessMessageCallback ProcessMessage;
        public void Listening()
        {
            try
            {

                while (true)
                {
                    Socket temp = s.Accept();//为新建连接创建新的Socket。
                    string recvStr = "";
                    byte[] recvBytes = new byte[1024];
                    int bytes;
                    bytes = temp.Receive(recvBytes, recvBytes.Length, 0);//从客户端接受信息
                    recvStr += Encoding.ASCII.GetString(recvBytes, 0, bytes);
                    try
                    {
                        if (ProcessMessage != null)
                            ProcessMessage(recvStr);
                    }
                    catch (Exception ex)
                    {
                        RECORD = "Error:" + ex.Message;
                    }
                    RECORD = recvStr;
                    temp.Close();
                }
            }
            catch (ArgumentNullException e)
            {
                RECORD = string.Format("Error:{0}", e);
            }
            catch (SocketException e)
            {
                RECORD = string.Format("Socket error:{0}", e);
            }
        }

        #region 记录信息
        public StringBuilder sb { get; set; }
        public delegate void NewMessageCallback(string msg);
        public event NewMessageCallback NewMessage;
        private string _Record;
        /// <summary>
        /// Record
        /// </summary>
        public string RECORD
        {
            get { return _Record; }
            set
            {
                _Record = value;
                sb.Append(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ":" + _Record);
                if (NewMessage != null)
                    NewMessage(DateTime.Now.ToString("HH:mm:ss") + ":" + _Record);
            }
        }
        #endregion


        Thread th;
        public void StartListening()
        {
            th = new Thread(Listening);
            th.Start();
            RECORD = string.Format("Start Listening.");
        }

        public void StopListening()
        {
            if (th != null)
                th.Abort();
            s.Close();
            RECORD = "End listening.";
        }

        public void Dispose()
        {
            StopListening();
            if (s != null)
                s.Close();
        }
    }
}
