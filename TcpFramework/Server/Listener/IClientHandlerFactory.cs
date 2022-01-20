using TcpFramework.Sockets;

namespace TcpFramework.Server.Listener
{
    public interface IClientHandlerFactory
    {
        ClientHandlerBase Create(ISocket socket);
    }
}
