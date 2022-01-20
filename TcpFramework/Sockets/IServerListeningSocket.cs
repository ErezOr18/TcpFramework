
namespace TcpFramework.Sockets
{
    public interface IServerListeningSocket
    {
        public ISocket AcceptClient();

        public void Start();

        public void Stop();
    }
}
