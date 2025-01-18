using System;
using System.Security.Cryptography;
using System.Text;

namespace SecureDataHelper.DigitalSignatures
{
    public static class DigitalSignatureHelper
    {
        // Signs data using a private key
        public static string SignData(string data, string privateKey)
        {
            using (RSA rsa = RSA.Create())
            {
                rsa.ImportFromPem(privateKey);
                byte[] signature = rsa.SignData(Encoding.UTF8.GetBytes(data), HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
                return Convert.ToBase64String(signature);
            }
        }

        // Verifies the signature of data using a public key
        public static bool VerifySignature(string data, string signature, string publicKey)
        {
            using (RSA rsa = RSA.Create())
            {
                rsa.ImportFromPem(publicKey);
                return rsa.VerifyData(Encoding.UTF8.GetBytes(data), Convert.FromBase64String(signature), HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
            }
        }
    }
}