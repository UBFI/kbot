using System.Runtime.InteropServices;

namespace myApp
{
    class Getcn
    {
        public static string MyCountry = "";
        [DllImport("kernel32.dll")]
        private static extern int GetLocaleInfo(uint Locale, uint LCType,
                                                [Out] System.Text.StringBuilder lpLCData, int cchData);

        private const uint LOCALE_SYSTEM_DEFAULT = 0x400;
        private const uint LOCALE_SABBREVCTRYNAME = 0x0007;


        private static string GetInfo(uint lInfo)
        {
            var lpLCData = new System.Text.StringBuilder(256);
            int ret = GetLocaleInfo(LOCALE_SYSTEM_DEFAULT, lInfo, lpLCData,
                                    lpLCData.Capacity);

            if (ret > 0)
            {
                return lpLCData.ToString().Substring(0, ret - 1);
            }
            return string.Empty;
        }

        public static void Get()
        {
            MyCountry = (GetInfo(LOCALE_SABBREVCTRYNAME));
        }
    }
}