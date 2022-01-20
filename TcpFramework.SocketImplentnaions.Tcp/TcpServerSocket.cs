﻿using System.Net;
using System.Net.Sockets;
using TcpFramework.Sockets;

namespace TcpFramework.SocketImplentnaions.Tcp
{
    public class TcpServerSocket : IServerListeningSocket
    {
        private readonly TcpListener _server;

        public TcpServerSocket(IPAddress addr, int port)
        {
            _server = new TcpListener(addr, port);
        }

        public ISocket AcceptClient()
        {
            var client = _server.AcceptTcpClient();

            return new TcpSocket(client);
        }

        public void Start()
        {
            _server.Start();
        }

        public void Stop()
        {
            _server.Stop();
        }
    }
}
