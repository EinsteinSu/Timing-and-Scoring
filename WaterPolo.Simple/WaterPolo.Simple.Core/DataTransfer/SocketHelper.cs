using log4net;
using System;
using System.Net.Sockets;
using System.Text;

namespace WaterPolo.Simple.Core.DataTransfer
{
    public static class SocketHelper
    {
        private static readonly ILog Log = LogManager.GetLogger("SocketHelper");
        public static void SendMessage(string ipAddress, int port, string message, int compacity)
        {
            try
            {
                var client = new TcpClient(ipAddress, port);
                var data = Encoding.Unicode.GetBytes(message);
                var stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                
                data = new byte[compacity];
                var bytes = stream.Read(data, 0, data.Length);
                var responseData = Encoding.Unicode.GetString(data, 0, bytes);
                Console.WriteLine(responseData);
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
