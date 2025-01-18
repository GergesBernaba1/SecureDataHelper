using System;
using System.IO;
using System.Security.Cryptography;

namespace SecureDataHelper.File
{
    public static class FileEncryptionHelper
    {
        // Encrypts a file using AES
        public static void EncryptFile(string inputFile, string outputFile, string key)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Convert.FromBase64String(key);
                aes.IV = new byte[16]; // Initialization Vector (IV) for simplicity

                using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))
                using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create))
                using (CryptoStream cryptoStream = new CryptoStream(fsOutput, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    fsInput.CopyTo(cryptoStream);
                }
            }
        }

        // Decrypts a file using AES
        public static void DecryptFile(string inputFile, string outputFile, string key)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Convert.FromBase64String(key);
                aes.IV = new byte[16]; // Initialization Vector (IV) for simplicity

                using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))
                using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create))
                using (CryptoStream cryptoStream = new CryptoStream(fsInput, aes.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    cryptoStream.CopyTo(fsOutput);
                }
            }
        }
    }
}