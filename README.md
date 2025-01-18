SecureDataHelper
SecureDataHelper is a .NET library designed to simplify cryptographic operations in your applications. It provides easy-to-use methods for encryption, decryption, hashing, key derivation, digital signatures, file encryption, configuration management, and secure random number generation.

Features
AES Encryption: Symmetric encryption for fast and secure data encryption.

RSA Encryption: Asymmetric encryption for secure key exchange and data encryption.

Hashing: SHA-256 and salted hashing for secure password storage.

Key Derivation: PBKDF2 for securely deriving keys from passwords.

Digital Signatures: Sign and verify data using RSA.

File Encryption: Encrypt and decrypt files using AES.

Configuration Management: Securely store and retrieve sensitive configuration values.

Secure Random Number Generation: Generate cryptographically secure random numbers.

Installation
You can install the library via NuGet:

bash
Copy
dotnet add package SecureDataHelper
Or add it directly to your .csproj file:

xml
Copy
<PackageReference Include="SecureDataHelper" Version="1.0.0" />
Run HTML
Usage
1. AES Encryption
Encrypt and decrypt data using AES.

csharp
Copy
using SecureDataHelper.Encryption;
using SecureDataHelper.Utilities;

// Generate an AES key
string key = KeyGenerator.GenerateAesKey();

// Encrypt data
string originalText = "Hello, World!";
string encryptedText = AesEncryption.Encrypt(originalText, key);

// Decrypt data
string decryptedText = AesEncryption.Decrypt(encryptedText, key);

Console.WriteLine($"Original: {originalText}");
Console.WriteLine($"Encrypted: {encryptedText}");
Console.WriteLine($"Decrypted: {decryptedText}");
2. RSA Encryption
Encrypt and decrypt data using RSA.

csharp
Copy
using SecureDataHelper.Encryption;

// Generate an RSA key pair
var (publicKey, privateKey) = RsaEncryption.GenerateKeyPair();

// Encrypt data
string originalText = "Hello, World!";
string encryptedText = RsaEncryption.Encrypt(originalText, publicKey);

// Decrypt data
string decryptedText = RsaEncryption.Decrypt(encryptedText, privateKey);

Console.WriteLine($"Original: {originalText}");
Console.WriteLine($"Encrypted: {encryptedText}");
Console.WriteLine($"Decrypted: {decryptedText}");
3. Hashing
Compute SHA-256 hashes and salted hashes.

csharp
Copy
using SecureDataHelper.Hashing;

// Compute a SHA-256 hash
string input = "Hello, World!";
string hash = HashHelper.ComputeSha256Hash(input);

// Compute a salted hash
string salt = SaltedHashHelper.GenerateSalt();
string saltedHash = SaltedHashHelper.ComputeSaltedHash(input, salt);

Console.WriteLine($"Hash: {hash}");
Console.WriteLine($"Salted Hash: {saltedHash}");
4. Key Derivation
Derive a secure key from a password using PBKDF2.

csharp
Copy
using SecureDataHelper.KeyDerivation;
using SecureDataHelper.Hashing;

// Generate a salt
string salt = SaltedHashHelper.GenerateSalt();

// Derive a key
string password = "my_password";
string derivedKey = KeyDerivationHelper.DeriveKey(password, salt);

Console.WriteLine($"Derived Key: {derivedKey}");
5. Digital Signatures
Sign and verify data using RSA.

csharp
Copy
using SecureDataHelper.DigitalSignatures;
using SecureDataHelper.Encryption;

// Generate an RSA key pair
var (publicKey, privateKey) = RsaEncryption.GenerateKeyPair();

// Sign data
string data = "Hello, World!";
string signature = DigitalSignatureHelper.SignData(data, privateKey);

// Verify signature
bool isValid = DigitalSignatureHelper.VerifySignature(data, signature, publicKey);

Console.WriteLine($"Signature Valid: {isValid}");
6. File Encryption
Encrypt and decrypt files using AES.

csharp
Copy
using SecureDataHelper.File;
using SecureDataHelper.Utilities;

// Generate an AES key
string key = KeyGenerator.GenerateAesKey();

// Encrypt a file
FileEncryptionHelper.EncryptFile("document.txt", "document.enc", key);

// Decrypt a file
FileEncryptionHelper.DecryptFile("document.enc", "document_decrypted.txt", key);
7. Configuration Management
Securely store and retrieve sensitive configuration values.

csharp
Copy
using SecureDataHelper.Configuration;
using SecureDataHelper.Utilities;

// Generate an AES key
string key = KeyGenerator.GenerateAesKey();

// Encrypt a configuration value
string connectionString = "Server=myServer;Database=myDB;User Id=myUser;Password=myPass;";
string encryptedValue = ConfigurationHelper.EncryptConfigurationValue(connectionString, key);

// Decrypt a configuration value
string decryptedValue = ConfigurationHelper.DecryptConfigurationValue(encryptedValue, key);

Console.WriteLine($"Original: {connectionString}");
Console.WriteLine($"Encrypted: {encryptedValue}");
Console.WriteLine($"Decrypted: {decryptedValue}");
8. Secure Random Number Generation
Generate cryptographically secure random numbers and strings.

csharp
Copy
using SecureDataHelper.Random;

// Generate a secure random string
string randomString = SecureRandomHelper.GenerateSecureRandomString(32);

// Generate a secure random number
int randomNumber = SecureRandomHelper.GenerateSecureRandomNumber(1000, 9999);

Console.WriteLine($"Random String: {randomString}");
Console.WriteLine($"Random Number: {randomNumber}");
Contributing
Contributions are welcome! If you'd like to contribute, please follow these steps:

Fork the repository.

Create a new branch for your feature or bugfix.

Make your changes and write tests.

Submit a pull request.

License
This project is licensed under the MIT License. See the LICENSE file for details.

Support
If you have any questions, issues, or feature requests, please open an issue on the GitHub repository.

Acknowledgments
Built with ❤️ by Gerges Bernaba.

Inspired by the need for simple and secure cryptographic operations in .NET applications.

Enjoy using SecureDataHelper! If you find it useful, please consider giving it a ⭐ on GitHub. 😊
