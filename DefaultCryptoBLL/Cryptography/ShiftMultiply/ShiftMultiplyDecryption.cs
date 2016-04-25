using DefaultCryptoBLL.Cryptography.Interfaces;
using System;
using System.Text;

namespace DefaultCryptoBLL.Cryptography.ShiftMultiply
{
    /// <summary>
    /// Provides machanism to decrypt any given text using Multiply decryption.
    /// </summary>
    internal class ShiftMultiplyDecryption : IDecryptionAlgorithm
    {
        #region Events

        public event Action ProgressUpdate;

        #endregion

        #region Public methods

        public string[] Decrypt(string[] textToDecrypt, Infrastructure.Key[] keyToDecryptWith)
        {
            string[] decryptedText = new string[textToDecrypt.Length];
            for (int i = 0; i < textToDecrypt.Length; i++)
            {
                decryptedText[i] = EncryptIndividualString(textToDecrypt[i], keyToDecryptWith);
                ProgressUpdate?.Invoke();
            }
            return decryptedText;
        }

        #endregion

        #region Private methods

        private string EncryptIndividualString(string textToEncrypt, Infrastructure.Key[] keyToEncrypt)
        {
            int key = keyToEncrypt[0].KeyModel;
            StringBuilder builder = new StringBuilder();
            CharFormatter charFormatter = new CharFormatter();

            foreach (char sign in textToEncrypt.ToCharArray())
            {
                builder.Append(charFormatter.FormatNewChar(Convert.ToInt32(sign), key, CharFormatter.Operator.Devide));
            }
            return builder.ToString();

        }

        #endregion
    }
}
