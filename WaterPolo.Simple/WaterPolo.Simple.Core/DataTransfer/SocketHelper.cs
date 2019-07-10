using System;
using System.Net.Sockets;
using System.Text;
using log4net;

namespace WaterPolo.Simple.Core.DataTransfer
{
    public static class SocketHelper
    {
        private static readonly ILog Log = LogManager.GetLogger("SocketHelper");

        public static void SendMessage(string ipAddress, int port, string message)
        {
            try
            {
                var client = new TcpClient(ipAddress, port);
                var data = Encoding.Unicode.GetBytes(message);
                var stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                Log.Debug($"send message to {ipAddress}:{port}");
                stream.Close();
                client.Close();
            }
            catch (SocketException ex)
            {
                Log.Error(ex);
            }
            catch (Exception e)
            {
                Log.Error(e);
                throw;
            }
        }
    }
}