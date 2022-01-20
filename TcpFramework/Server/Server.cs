using log4net;
using System;
using System.Reflection;
using System.Threading.Tasks;
using TcpFramework.Server.Listener;
using TcpFramework.Sockets;

namespace TcpFramework.Server
{
    public class Server : IListener
    {
        protected readonly IClientHandlerFactory _clientHandlerFactory;
        protected readonly IServerListeningSocket _listeningSocket;
        protected readonly ILog _logger;

        public Server(int port, IClientHandlerFactory clientHandlerFactory, IServerListeningSocket listeningSocket)
        {
            _clientHandlerFactory = clientHandlerFactory;
            _logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
            _listeningSocket = listeningSocket;
        }

        public virtual async Task StartListening()
        {
            try
            {
                _listeningSocket.Start();
                await Task.Run(() =>
                {
                    while (true)
                    {
                        _logger.Debug("Waiting For Client...");
                        var client = _listeningSocket.AcceptClient();
                        _logger.Info($"New Client Connected {client}");
                        var handler = _clientHandlerFactory.Create(client);
                        Task.Run(async () =>
                        {
                            try
                            {
                                await handler.HandleClient();
                            }
                            catch (Exception ex)
                            {
                                _logger.Error(ex);
                            }
                        });
                    }
                });
            }
            catch (Exception e)
            {
                _logger.Error("Error", e);
            }
            finally
            {
                _listeningSocket.Stop();
            }
        }
    }
}
