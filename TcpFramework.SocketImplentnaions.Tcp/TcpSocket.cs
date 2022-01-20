﻿using System.Net.Sockets;
using TcpFramework.Sockets;

namespace TcpFramework.SocketImplentnaions.Tcp
{
    public class TcpSocket : ISocket
    {
        private readonly TcpClient _client;

        public TcpSocket(TcpClient client)
        {
            _client = client;
        }

        public bool CanRead()
        {
            return _client.GetStream().DataAvailable;
        }

        public void Close()
        {
            _client.GetStream().Close();
            _client.Close();
        }

        public int Receive(byte[] buffer)
        {
            return _client.GetStream().Read(buffer, 0, buffer.Length);
        }

        public void Send(byte[] data)
        {
            _client.GetStream().Write(data, 0, data.Length);
        }
    }
}
