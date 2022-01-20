
using log4net;
using System.Reflection;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using TcpFramework.Sockets;

namespace TcpFramework.Server.Listener
{
    public abstract class ClientHandlerBase
    {
        protected readonly ISocket _socket;
        protected ILog _log;
        protected readonly IFormatter _formatter;
        public ClientHandlerBase(ISocket socket, IFormatter formatter)
        {
            _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
            _socket = socket;
            _formatter = formatter;
        }


        public abstract Task HandleClient();

    }
}
