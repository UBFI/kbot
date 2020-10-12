using System;
using System.Security.Cryptography;
using System.Text;

namespace myApp
{
    class Fuck
    {
        public static string a(string b, string c, bool d)
        {
            byte[] keyArray;
            byte[] toEncryptArray = Convert.FromBase64String(b);

            if (d)
            {
                var hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(c));
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(c);

            var tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return UTF8Encoding.UTF8.GetString(resultArray);
        }
    }
}