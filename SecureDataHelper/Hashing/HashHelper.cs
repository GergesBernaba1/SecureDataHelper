using System;
using System.Security.Cryptography;
using System.Text;

namespace SecureDataHelper.Hashing
{
    public static class HashHelper
    {
        // Computes a SHA-256 hash of the input string
        public static string ComputeSha256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }
    }
}