using DefaultCryptoBLL.Cryptography.Factory;
using DefaultCryptoBLL.Cryptography.Interfaces;
using DefaultCryptoBLL.Cryptography.Key;
using System;

namespace DefaultCryptoBLL.Cryptography.ShiftUp
{
    /// <summary>
    /// Provides machanism to encrypt and decrypt any given text using ShiftUp cryptography.
    /// </summary>
    public class ShiftUpCryptography : IShiftCryptography
    {
        #region Events

        public event Action ProgressUpdate;

        #endregion

        #region Members

        private static readonly int MaxKeyValue = 52;
        private readonly IEncryptionAlgorithm _encryptor;
        private readonly IDecryptionAlgorithm _decryptor;

        #endregion

        #region Properties

        public Infrastructure.Key[] KeyChain { get; set; }

        #endregion

        #region Constructor

        public ShiftUpCryptography()
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

        public int KeyStrength { get { return (int)Math.Floor(Math.Log10(MaxKeyValue) + 1); } }

        public string[] Encrypt(string[] textToEncrypt)
        {
            KeyChain = new Infrastructure.Key[] { KeyGenerator.CreateInstance(MaxKeyValue) };
            string[] encrypted = _encryptor.Encrypt(textToEncrypt, KeyChain);
            return encrypted;
        }

        public override int GetHashCode()
        {
            return 1;
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
