using System;
using System.Security.Cryptography;

namespace SecureDataHelper.Random
{
    public static class SecureRandomHelper
    {
        // Generates a cryptographically secure random string
        public static string GenerateSecureRandomString(int length)
        {
            byte[] randomBytes = new byte[length];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomBytes);
            }
            return Convert.ToBase64String(randomBytes);
        }

        // Generates a cryptographically secure random number
        public static int GenerateSecureRandomNumber(int minValue, int maxValue)
        {
            using (var rng = RandomNumberGenerator.Create())
            {
                byte[] randomBytes = new byte[sizeof(int)];
                rng.GetBytes(randomBytes);
                int randomNumber = BitConverter.ToInt32(randomBytes, 0);
                return Math.Abs(randomNumber % (maxValue - minValue)) + minValue;
            }
        }
    }
}