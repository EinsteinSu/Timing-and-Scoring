using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using log4net;

namespace SocketPublic
{
    public class SocketSend
    {
        private static readonly ILog Log = LogManager.GetLogger("SocketSend");

        public static bool SendMessage(string ipAddress, int port, string message)
        {
            try
            {
                Log.Debug($"Trying to send {message} to {ipAddress}({port} )");
                var ip = IPAddress.Parse(ipAddress);
                var ipe = new IPEndPoint(ip, port); //把ip和端口转化为IPEndPoint实例
                var s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); //创建一个Socket
                Log.Debug($"Connecting to server {ipe}");
                s.Connect(ipe);
                var bs = Encoding.ASCII.GetBytes(message);
                s.Send(bs, bs.Length, 0);
                s.Close();
                Log.Debug($"Connection closed {ipe}");
                return true;
            }
            catch (Exception ex)
            {
                Log.Error($"Could not send message to {ipAddress}({port}). cause {ex.Message}");
                return false;
            }
        }
    }
}