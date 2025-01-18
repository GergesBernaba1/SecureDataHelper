using System;
using System.Security.Cryptography;
using System.Text;

namespace SecureDataHelper.Utilities
{
    public static class KeyGenerator
    {
        // Generates a secure random key for AES
        public static string GenerateAesKey(int keySize = 256)
        {
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = keySize;
                aes.GenerateKey();
                return Convert.ToBase64String(aes.Key);
            }
        }
    }
}