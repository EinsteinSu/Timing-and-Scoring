using System;
using System.Net.Sockets;
using System.Text;
using log4net;

namespace SocketPublic
{
    public static class UdpSend
    {
        private static UdpClient _vrsUdp;
        private static readonly ILog Log = LogManager.GetLogger("UdpSend");

        public static bool SendMessage(string ipAddress, int port, byte[] bs)
        {
            try
            {
                if (_vrsUdp == null)
                    _vrsUdp = new UdpClient(10001);
                _vrsUdp.DontFragment = false;
                _vrsUdp.Send(bs, bs.Length, ipAddress, port);
                Log.Debug($"Send message to {ipAddress}:{port} ({bs.ToHexString()})");
                return true;
            }
            catch
            {
                return false;
            }
        }


        public static bool SendMessage(this Machine machine, byte[] bs)
        {
            return SendMessage(machine.IPAddress, machine.Port, bs);
        }
    }

    public class Machine
    {
        public string IPAddress { get; set; }

        public int Port { get; set; }
    }

    public static class HexHelper
    {

        public static string ToHexString(this byte[] hex)
        {
            if (hex == null) return null;
            if (hex.Length == 0) return string.Empty;
            var s = new StringBuilder();
            foreach (var b in hex)
            {
                s.Append(b.ToString("x2"));
            }
            return s.ToString();
        }


        public static byte[] ToHexBytes(this string hex)
        {

            if (hex == null) return null;
            if (hex.Length == 0) return new byte[0];
            int l = hex.Length / 2;
            var b = new byte[l];
            for (int i = 0; i < l; ++i)
            {
                b[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return b;
        }


        public static bool EqualsTo(this byte[] bytes, byte[] bytesToCompare)
        {

            if (bytes == null && bytesToCompare == null) return true; // ?

            if (bytes == null || bytesToCompare == null) return false;
            if (object.ReferenceEquals(bytes, bytesToCompare)) return true;
            if (bytes.Length != bytesToCompare.Length) return false;
            for (int i = 0; i < bytes.Length; ++i)
            {
                if (bytes[i] != bytesToCompare[i]) return false;
            }
            return true;
        }

    }
}