using System;
using System.Security.Cryptography;
using System.Text;

namespace Common
{
    public static class Crypto
    {
        public static string TripleDes(string connectionString)
        {
            byte[] keyArray;

            byte[] toEncryptArray = Convert.FromBase64String(connectionString);

            keyArray = UTF8Encoding.UTF8.GetBytes("4qBfOkPGebwSNMZzZw1DKaxH");

            var tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;


            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            tdes.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
        }
        public static string TripleDesEncrypt(string text)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(text);

            keyArray = UTF8Encoding.ASCII.GetBytes("4qBfOkPGebwSNMZzZw1DKaxH");
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

            tdes.Key = keyArray;

            tdes.Mode = CipherMode.ECB;

            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray =
              cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            tdes.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
    }
}
