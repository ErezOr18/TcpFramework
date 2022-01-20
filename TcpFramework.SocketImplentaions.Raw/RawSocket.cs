using System.Net.Sockets;
using TcpFramework.Sockets;

namespace TcpFramework.SocketImplentaions.Raw
{
    public class RawSocket : ISocket
    {
        private readonly Socket _client;

        public RawSocket(Socket client)
        {
            _client = client;
        }

        public bool CanRead()
        {
            return _client.Available > 0;
        }

        public void Close()
        {
            _client.Close();
        }

        public int Receive(byte[] buffer)
        {
            return _client.Receive(buffer);
        }

        public void Send(byte[] data)
        {
            _client.Send(data);
        }
    }
}
