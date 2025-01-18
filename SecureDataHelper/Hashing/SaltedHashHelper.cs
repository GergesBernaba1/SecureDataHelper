using System;
using System.Security.Cryptography;
using System.Text;

namespace SecureDataHelper.Hashing
{
    public static class SaltedHashHelper
    {
        // Generates a random salt
        public static string GenerateSalt(int size = 16)
        {
            byte[] salt = new byte[size];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return Convert.ToBase64String(salt);
        }

        // Computes a salted hash using SHA-256
        public static string ComputeSaltedHash(string input, string salt)
        {
            string saltedInput = input + salt;
            return HashHelper.ComputeSha256Hash(saltedInput);
        }
    }
}