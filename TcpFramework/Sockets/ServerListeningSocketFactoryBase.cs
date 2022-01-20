using System.Net;

namespace TcpFramework.Sockets
{
    public abstract class ServerListeningSocketFactoryBase
    {
        public abstract IServerListeningSocket Create(IPAddress address, int port);
    }
}
