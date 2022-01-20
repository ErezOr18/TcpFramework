using System.Net;

namespace TcpFramework.Sockets
{
    public interface ISocketOrchestraor
    {
        public ISocket Connect(IPEndPoint endPoint);
    }
}
