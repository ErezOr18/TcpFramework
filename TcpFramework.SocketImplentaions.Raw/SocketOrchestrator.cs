using System.Net;
using System.Net.Sockets;
using TcpFramework.Sockets;

namespace TcpFramework.SocketImplentaions.Raw
{
    public class TcpSocketOrchestrator : ISocketOrchestraor
    {

        public ISocket Connect(IPEndPoint endPoint)
        {

            var client = new Socket(SocketType.Stream, ProtocolType.Tcp);
            client.Connect(endPoint);
            return new RawSocket(client);
        }
    }
}
