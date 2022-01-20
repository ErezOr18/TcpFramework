using System.Net;
using System.Net.Sockets;
using TcpFramework.Sockets;

namespace TcpFramework.SocketImplentnaions.Tcp
{
    public class TcpSocketOrchestrator : ISocketOrchestraor
    {

        public ISocket Connect(IPEndPoint endPoint)
        {

            var client = new TcpClient();
            client.Connect(endPoint);
            return new TcpSocket(client);
        }
    }
}
