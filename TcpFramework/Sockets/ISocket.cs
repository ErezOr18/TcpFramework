namespace TcpFramework.Sockets
{
    public interface ISocket
    {
        public int Receive(byte[] buffer);

        public void Send(byte[] data);
        public bool CanRead();

        public void Close();
    }
}
