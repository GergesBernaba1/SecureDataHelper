using System;

namespace SecureDataHelper.Configuration
{
    public static class ConfigurationHelper
    {
        // Encrypts a configuration value using AES
        public static string EncryptConfigurationValue(string value, string key)
        {
            return Encryption.AesEncryption.Encrypt(value, key);
        }

        // Decrypts a configuration value using AES
        public static string DecryptConfigurationValue(string encryptedValue, string key)
        {
            return Encryption.AesEncryption.Decrypt(encryptedValue, key);
        }
    }
}