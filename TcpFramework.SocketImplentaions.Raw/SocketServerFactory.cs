using System.Net;
using TcpFramework.Sockets;

namespace TcpFramework.SocketImplentaions.Raw
{
    public class SocketServerFactory : ServerListeningSocketFactoryBase
    {
        public override IServerListeningSocket Create(IPAddress address, int port)
        {
            return new SocketServer(address, port);
        }
    }
}
