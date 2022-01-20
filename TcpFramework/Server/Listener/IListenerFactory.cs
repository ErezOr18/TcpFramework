namespace TcpFramework.Server.Listener
{
    public interface IListenerFactory
    {
        public IListener Create(int port);
    }
}
