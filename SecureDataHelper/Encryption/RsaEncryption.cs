using System;
using System.Security.Cryptography;
using System.Text;

namespace SecureDataHelper.Encryption
{
    public static class RsaEncryption
    {
        // Encrypts a string using RSA public key
        public static string Encrypt(string plainText, string publicKey)
        {
            using (RSA rsa = RSA.Create())
            {
                rsa.ImportFromPem(publicKey);
                byte[] encryptedData = rsa.Encrypt(Encoding.UTF8.GetBytes(plainText), RSAEncryptionPadding.OaepSHA256);
                return Convert.ToBase64String(encryptedData);
            }
        }

        // Decrypts a string using RSA private key
        public static string Decrypt(string cipherText, string privateKey)
        {
            using (RSA rsa = RSA.Create())
            {
                rsa.ImportFromPem(privateKey);
                byte[] decryptedData = rsa.Decrypt(Convert.FromBase64String(cipherText), RSAEncryptionPadding.OaepSHA256);
                return Encoding.UTF8.GetString(decryptedData);
            }
        }

        // Generates a new RSA key pair
        public static (string PublicKey, string PrivateKey) GenerateKeyPair()
        {
            using (RSA rsa = RSA.Create())
            {
                string publicKey = rsa.ExportSubjectPublicKeyInfoPem();
                string privateKey = rsa.ExportPkcs8PrivateKeyPem();
                return (publicKey, privateKey);
            }
        }
    }
}