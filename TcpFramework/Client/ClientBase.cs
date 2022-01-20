using log4net;
using System;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization;
using TcpFramework.Sockets;

namespace TcpFramework.Client
{
    public abstract class ClientBase
    {
        protected readonly ISocketOrchestraor _socketOrchestrator;
        protected readonly ILog _logger;
        protected readonly IFormatter _formatter;
        protected ISocket _socket;
        protected ClientBase(ISocketOrchestraor socketOrchestrator, IFormatter formatter)
        {
            _socketOrchestrator = socketOrchestrator;
            _logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
            _formatter = formatter;
        }

        public void Connect(IPEndPoint endPoint)
        {
            try
            {
                _logger.Info($"Connecting to {endPoint}");
                _socket = _socketOrchestrator.Connect(endPoint);
                _logger.Debug("Connected");
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                throw;
            }
        }

        public abstract void Run();

        public void Close()
        {
            _socket.Close();
        }
    }
}
