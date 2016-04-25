using DefaultCryptoBLL.Cryptography.Factory;
using DefaultCryptoBLL.Cryptography.Interfaces;
using DefaultCryptoBLL.Cryptography.Key;
using DefaultCryptoBLL.Cryptography.ShiftUp;
using Infrastructure;

namespace DefaultCryptoBLL.Cryptography
{
    internal class TypeCryptographyAlgorithm
    {

        private readonly IEncryptionAlgorithm _encryptor;
        private readonly IDecryptionAlgorithm _decryptor;

        public TypeCryptographyAlgorithm()
        {
            _encryptor = EncryptionAlgorithmFactory.CreateInstance(typeof(ShiftUpEncryption)); // My encryption algorithm 
            _decryptor = DecryptionAlgorithmFactory.CreateInstance(typeof(ShiftUpDecryption)); // My decryption algorithm
        }

        public string[] Decrypt(string[] textToDecrypt, Infrastructure.Key[] keyToDecryptWith)
        {
            string[] decrypted = _decryptor.Decrypt(textToDecrypt, keyToDecryptWith);
            return decrypted;
        }

        public string[] Encrypt(string[] textToEncrypt, Infrastructure.Key[] keyChain)
        {
            string[] encrypted = _encryptor.Encrypt(textToEncrypt, keyChain);
            return encrypted;
        }
    }
}
