using System;

namespace myApp
{
    class GetOs
    {
        private static string OSVersionNoRevision(Version ver)
        {
            return ver.Major + "." + ver.Minor + "." + ver.Build;
        }

        public static void Get()
        {
            OperatingSystem os = Environment.OSVersion;

            switch (OSVersionNoRevision(os.Version))
            {
                case "4.1.2222":
                    Program.Osprefix = "98";
                    break;

                case "4.1.2600":
                    Program.Osprefix = "98SE";
                    break;

                case "4.9.3000":
                    Program.Osprefix = "ME";
                    break;

                case "5.0.2195":
                    Program.Osprefix = "2000";
                    break;

                case "5.1.2600":
                case "5.2.3790":
                    Program.Osprefix = "XP";
                    break;

                case "6.0.6000":
                case "6.0.6001":
                case "6.0.6002":
                    Program.Osprefix = "Vista";
                    break;

                case "6.1.7600":
                    Program.Osprefix = "Win7";
                    break;

                default:
                    Program.Osprefix = "Unknown";
                    break;
            }
        }
    }
}