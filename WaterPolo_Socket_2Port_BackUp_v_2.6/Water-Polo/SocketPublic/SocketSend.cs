using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace SocketPublic
{
    public class SocketSend
    {
        public static bool SendMessage(string ipAddress, string message)
        {
            try
            {
                int port = 1000;
                IPAddress ip = IPAddress.Parse(ipAddress);
                IPEndPoint ipe = new IPEndPoint(ip, port);//把ip和端口转化为IPEndPoint实例
                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//创建一个Socket
                Console.WriteLine("Conneting...");
                s.Connect(ipe);//连接到服务器
                byte[] bs = Encoding.ASCII.GetBytes(message);
                s.Send(bs, bs.Length, 0);//发送测试信息
                s.Close();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Scoket error:" + ex.Message);
                return false;
            }
        }

        public static bool SendMessage(string ipAddress, int port, string message)
        {
            try
            {
                IPAddress ip = IPAddress.Parse(ipAddress);
                IPEndPoint ipe = new IPEndPoint(ip, port);//把ip和端口转化为IPEndPoint实例
                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//创建一个Socket
                Console.WriteLine("Conneting...");
                s.Connect(ipe);//连接到服务器
                byte[] bs = Encoding.ASCII.GetBytes(message);
                s.Send(bs, bs.Length, 0);//发送测试信息
                s.Close();
                return true;
            }
            catch //(Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show("Scoket error:" + ex.Message);
                return false;
            }
        }
    }
}
