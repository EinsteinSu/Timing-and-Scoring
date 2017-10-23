using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace SocketPublic
{
    public class UdpListening
    {
        UdpClient Service;
        IPEndPoint Ipe;
        public UdpListening(int port)
        {
            Service = new UdpClient(port);
            IPHostEntry ipHost = Dns.Resolve(Dns.GetHostName());
            IPAddress ip = ipHost.AddressList[0];
            IPEndPoint ipe = new IPEndPoint(ip, port);
            StartListening();
        }

        Thread th;
        public void StartListening()
        {
            th = new Thread(ListeningByThread);
            th.IsBackground = true;
            th.Start();
        }

        public void StopListening()
        {
            if (th != null)
                th.Abort();
        }

        public delegate void ProcessMessageCallback(string msg);
        public event ProcessMessageCallback ProcessMessage;
        private void ListeningByThread()
        {
            while (true)
            {
                byte[] bs = Service.Receive(ref Ipe);
                if(ProcessMessage !=null)
                 ProcessMessage(Encoding.ASCII.GetString(bs));
            }
        }
    }
}
