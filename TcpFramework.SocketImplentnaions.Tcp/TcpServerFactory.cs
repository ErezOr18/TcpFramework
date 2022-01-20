using System.Net;
using TcpFramework.Sockets;

namespace TcpFramework.SocketImplentnaions.Tcp
{
    public class TcpServerFactory : ServerListeningSocketFactoryBase
    {
        public override IServerListeningSocket Create(IPAddress address, int port)
        {
            return new TcpServerSocket(address, port);
        }
    }
}
