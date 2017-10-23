using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace SocketPublic
{
    public static class UdpSend
    {
        public static bool SendMessage(string ipAddress, int port, string message,int myPort)
        {
            try
            {
                UdpClient s = new UdpClient(myPort);
                s.DontFragment = false;
                byte[] bs = Encoding.ASCII.GetBytes(message);
                s.Send(bs, bs.Length, ipAddress, port);
                s.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool SendMessage(string ipAddress, int port, string message)
        {
            try
            {
                UdpClient s = new UdpClient(10000);
                s.DontFragment = false;
                byte[] bs = Encoding.ASCII.GetBytes(message);
                s.Send(bs, bs.Length, ipAddress, port);
                s.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

       static UdpClient vrsUdp;
        public static bool SendMessage(string ipAddress, int port, byte[] bs)
        {
            try
            {
                if (vrsUdp == null)
                    vrsUdp = new UdpClient(10001);
                vrsUdp.DontFragment = false;
                vrsUdp.Send(bs, bs.Length, ipAddress, port);
                //s.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool SendMessage(string ipAddress, int port, byte[] bs, int myPort)
        {
            try
            {
                UdpClient s = new UdpClient(myPort);
                s.DontFragment = false;
                s.Send(bs, bs.Length, ipAddress, port);
                s.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
