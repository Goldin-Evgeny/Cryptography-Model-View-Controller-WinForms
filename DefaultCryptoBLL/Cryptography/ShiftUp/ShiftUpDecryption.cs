using DefaultCryptoBLL.Cryptography.Interfaces;
using DefaultCryptoBLL.Cryptography.Key;
using System;

namespace DefaultCryptoBLL.Cryptography.ShiftUp
{
    /// <summary>
    /// Provides machanism to decrypt any given text using ShiftUp cryptography.
    /// </summary>
    internal class ShiftUpDecryption : IDecryptionAlgorithm
    {
        #region Events

        public event Action ProgressUpdate;

        #endregion

        #region Public methods

        public string[] Decrypt(string[] textToDecrypt, Infrastructure.Key[] keyToDecryptWith)
        {
            Infrastructure.Key[] reverseKey = new Infrastructure.Key[] { ReverseKey(keyToDecryptWith) };
            ShiftUpEncryption shiftUpEncryption = new ShiftUpEncryption();
            shiftUpEncryption.ProgressUpdate += ShiftUpEncryption_ProgressUpdate;
            string[] decrypted = shiftUpEncryption.Encrypt(textToDecrypt, reverseKey);
            return decrypted;
        }

        private void ShiftUpEncryption_ProgressUpdate()
        {
            ProgressUpdate?.Invoke();
        }

        #endregion

        #region Private methods

        private static Infrastructure.Key ReverseKey(Infrastructure.Key[] keyToDecryptWith)
        {
            Infrastructure.Key keyModel = new KeyModel(keyToDecryptWith[0].KeyModel * -1);
            return keyModel;
        }

        #endregion
    }
}
