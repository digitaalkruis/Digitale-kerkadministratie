using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace DigitaalKruisGlobal
{
    public static class DKGlobal
    {
        public static string GenerateSalt(int length)
        {
            byte[] salt = new byte[length];
            var cryptoRandomNumberGen = new RNGCryptoServiceProvider();
            cryptoRandomNumberGen.GetBytes(salt);
            return Convert.ToBase64String(salt).Substring(0, length);
        }
    }
}
