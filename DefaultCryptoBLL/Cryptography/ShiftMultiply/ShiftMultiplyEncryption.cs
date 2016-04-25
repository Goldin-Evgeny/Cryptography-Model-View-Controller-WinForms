using DefaultCryptoBLL.Cryptography.Interfaces;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultCryptoBLL.Cryptography.ShiftMultiply
{
    /// <summary>
    /// Provides machanism to encrypt any given text using Multiply encryption.
    /// </summary>
    internal class ShiftMultiplyEncryption : IEncryptionAlgorithm
    {
        #region Events

        public event Action ProgressUpdate;

        #endregion

        #region Public methods

        public string[] Encrypt(string[] textToEncrypt, Infrastructure.Key[] keyToEncryptWith)
        {
            string[] encryptedText = new string[textToEncrypt.Length];
            for (int i = 0; i < textToEncrypt.Length; i++)
            {
                encryptedText[i] = EncryptIndividualString(textToEncrypt[i], keyToEncryptWith);
                ProgressUpdate?.Invoke();
            }
            return encryptedText;
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
                builder.Append(charFormatter.FormatNewChar(Convert.ToInt32(sign), key, CharFormatter.Operator.Multiply));
            }
            return builder.ToString();

        }

        #endregion
    }
}
