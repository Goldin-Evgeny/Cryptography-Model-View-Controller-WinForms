using DefaultCryptoBLL.Cryptography.Interfaces;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultCryptoBLL.Cryptography.ShiftUp
{
    /// <summary>
    /// Provides machanism to encrypt any given text using Repeat cryptography.
    /// </summary>
    internal class ShiftUpEncryption : IEncryptionAlgorithm
    {
        #region Events

        public event Action ProgressUpdate;

        #endregion

        #region Public methods

        public string[] Encrypt(string[] textToEncrypt, Infrastructure.Key[] keyToEncrypt)
        {
            string[] encryptedText = new string[textToEncrypt.Length];
            for (int i = 0; i < textToEncrypt.Length; i++)
            {
                encryptedText[i] = EncryptIndividualString(textToEncrypt[i], keyToEncrypt);
                ProgressUpdate?.Invoke();
            }
            return encryptedText;
        }

        #endregion

        #region Private methods

        CharFormatter _charFormatter = new CharFormatter();

        private string EncryptIndividualString(string textToEncrypt, Infrastructure.Key[] keyToEncrypt)
        {
            int key = keyToEncrypt[0].KeyModel;
            StringBuilder builder = new StringBuilder();
            

            foreach (char sign in textToEncrypt.ToCharArray())
            {
                builder.Append(_charFormatter.FormatNewChar(Convert.ToInt32(sign), key, CharFormatter.Operator.Add));
            }
            return builder.ToString();

        }

        #endregion
    }
}
