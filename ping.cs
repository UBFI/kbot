using System.Threading;

namespace myApp
{
    class PingSender 
    {
	
        static string PING = "PING ";
        private static Thread _pingSender;
	
        public static void Start (){

            _pingSender = new Thread(Run);
            _pingSender.Start();
		
        }

        public static void Run ()
        {
		
            while (true)
            {
                Program.Writer.WriteLine(PING + Program.Server);
                Thread.Sleep(15000);
            }

        }

    }
}