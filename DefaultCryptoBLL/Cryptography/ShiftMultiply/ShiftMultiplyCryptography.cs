using DefaultCryptoBLL.Cryptography.Factory;
using DefaultCryptoBLL.Cryptography.Interfaces;
using DefaultCryptoBLL.Cryptography.Key;
using DefaultCryptoBLL.Cryptography.ShiftUp;
using System;

namespace DefaultCryptoBLL.Cryptography.ShiftMultiply
{
    /// <summary>
    /// Provides machanism to encrypt and decrypt any given text using Multiply cryptography.
    /// </summary>
    public class ShiftMultiplyCryptography : IShiftCryptography
    {
        #region Events

        public event Action ProgressUpdate;

        #endregion

        #region Members

        private static readonly int MaxKeyValue = 92;
        private readonly IEncryptionAlgorithm _encryptor;
        private readonly IDecryptionAlgorithm _decryptor;

        #endregion

        #region Properties

        public Infrastructure.Key[] KeyChain { get; set; }

        #endregion

        #region Constructor

        public ShiftMultiplyCryptography()
        {
            _encryptor = EncryptionAlgorithmFactory.CreateInstance(typeof(ShiftUpEncryption)); // My encryption algorithm 
            _decryptor = DecryptionAlgorithmFactory.CreateInstance(typeof(ShiftUpDecryption)); // My decryption algorithm

            _encryptor.ProgressUpdate += ProgressUpdated;
            _decryptor.ProgressUpdate += ProgressUpdated;
        }

        #endregion

        #region Public methods

        public string[] Decrypt(string[] textToDecrypt, Infrastructure.Key[] keyToDecryptWith)
        {
            string[] decrypted = _decryptor.Decrypt(textToDecrypt, keyToDecryptWith);
            return decrypted;
        }

        public string[] Encrypt(string[] textToEncrypt)
        {
            KeyChain = new Infrastructure.Key[] { KeyGenerator.CreateInstance(MaxKeyValue) };
            string[] encrypted = _encryptor.Encrypt(textToEncrypt, KeyChain);
            return encrypted;
        }

        public int KeyStrength { get { return (int)Math.Floor(Math.Log10(MaxKeyValue) + 1); } }

        public override int GetHashCode()
        {
            return 2;
        }

        #endregion

        #region Private methods

        private void ProgressUpdated()
        {
            ProgressUpdate?.Invoke();
        }

        #endregion
    }
}
