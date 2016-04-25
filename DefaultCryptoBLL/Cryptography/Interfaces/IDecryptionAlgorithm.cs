using Infrastructure;
using System;

namespace DefaultCryptoBLL.Cryptography.Interfaces
{
    /// <summary>
    /// Provides basic mecanism to decrypt any text.
    /// </summary>
    internal interface IDecryptionAlgorithm
    {
        /// <summary>
        /// Provided key chain, will decrypt any gived text. 
        /// </summary>
        /// <param name="textToDecrypt">Text which will be decrypted.</param>
        /// <param name="keyToDecryptWith">Key chain with which the text will be decrypted.</param>
        /// <returns></returns>
        string[] Decrypt(string[] textToDecrypt, Infrastructure.Key[] keyToDecryptWith);

        /// <summary>
        /// Event to represent an progress of action.
        /// </summary>
        event Action ProgressUpdate;
    }
}
