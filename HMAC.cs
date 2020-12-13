using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace RPSLS
{
    class HMAC
    {
        public static string Encode(string message, byte[] key)
        {
            HMACSHA256 myhmacsha256 = new HMACSHA256(key);
            byte[] byteArray = Encoding.ASCII.GetBytes(message);
            MemoryStream stream = new MemoryStream(byteArray);
            return myhmacsha256.ComputeHash(stream).Aggregate("", (s, e) => s + String.Format("{0:x2}", e), s => s).ToUpper();
        }

        public static string ByteToString(byte[] buff)
        {
            string sbinary = "";
            for (int i = 0; i < buff.Length; i++)
                sbinary += buff[i].ToString("X2");
            return sbinary;
        }
    }
}
