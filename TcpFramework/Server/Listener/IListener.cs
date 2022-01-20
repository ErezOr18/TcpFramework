using System.Threading.Tasks;

namespace TcpFramework.Server.Listener
{
    public interface IListener
    {
        Task StartListening();
    }
}
