﻿using Common.Network;
using GameServer.Network;
using GameServer.Service;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using GameServer.Tool;
using GameServer.Model;
using System.Threading.Channels;
using System.Diagnostics;
using Common.Tool;
using System.Xml.Linq;
using Serilog;

namespace GameServer
{
    public class GameServer
    {
        private Socket _serverSocket;
        private LinkedList<NetChannel> _channels = new();
        private TimeWheel _connectionCleanupTimer;

        public GameServer(int port)
        {
            _serverSocket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _serverSocket.Bind(new IPEndPoint(IPAddress.Parse("0.0.0.0"), port));
        }

        public async Task Run()
        {
            Log.Information("[Server] 开启服务器");
            _serverSocket.Listen();
            _connectionCleanupTimer = new(1000);
            //_connectionCleanupTimer.Start();

            while (true)
            {
                var socket = await _serverSocket.AcceptAsync();
                Log.Information($"[Server] 客户端连接:{socket.RemoteEndPoint}");
                NetChannel channel = new(socket);
                OnNewChannelConnection(channel);
                Task.Run(channel.StartAsync);
            }
        }

        private void OnNewChannelConnection(NetChannel sender)
        {
            lock (_channels)
            {
                var node = _channels.AddLast(sender);
                sender.LinkedListNode = node;
            }

            sender.PacketReceived += OnPacketReceived;
            sender.ConnectionClosed += OnConnectionClosed;
            sender.LastActiveTime = DateTime.UtcNow.Ticks / TimeSpan.TicksPerMillisecond;

            _connectionCleanupTimer.AddTask(10000, (task) =>
            {
                var now = DateTime.UtcNow.Ticks / TimeSpan.TicksPerMillisecond; ;
                var duration = now - sender.LastActiveTime;
                if (duration > 10000)
                {
                    // sender已关闭也不会产生错误
                    sender.Close();
                }
                else
                {
                    _connectionCleanupTimer.AddTask(10000, task.Action);
                }
            });

            PlayerService.Instance.OnConnect(sender);
            SpaceService.Instance.OnConnect(sender);
        }

        private void OnConnectionClosed(object? sender, ConnectionClosedEventArgs e)
        {
            var channel = sender as NetChannel;
            Debug.Assert(channel != null);

            PlayerService.Instance.OnChannelClosed(channel);
            SpaceService.Instance.OnChannelClosed(channel);

            lock (_channels)
            {
                _channels.Remove(channel.LinkedListNode);
            }
        }

        private void OnPacketReceived(object? sender, PacketReceivedEventArgs e)
        {
            var channel = sender as NetChannel;
            Debug.Assert(channel != null);

            channel.LastActiveTime = DateTime.UtcNow.Ticks / TimeSpan.TicksPerMillisecond;

            PlayerService.Instance.HandleMessage(channel, e.Packet.Message);
            SpaceService.Instance.HandleMessage(channel, e.Packet.Message);
        }
    }
}
