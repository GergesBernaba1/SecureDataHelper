using System;
using System.Security.Cryptography;
using System.Text;

namespace SecureDataHelper.KeyDerivation
{
    public static class KeyDerivationHelper
    {
        // Derives a key from a password using PBKDF2
        public static string DeriveKey(string password, string salt, int iterations = 10000, int keySize = 32)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, Encoding.UTF8.GetBytes(salt), iterations, HashAlgorithmName.SHA256))
            {
                byte[] key = pbkdf2.GetBytes(keySize);
                return Convert.ToBase64String(key);
            }
        }
    }
}