using Infrastructure;
using System;

namespace DefaultCryptoBLL.Cryptography.Interfaces
{
    /// <summary>
    /// Provide basic mechanism to encrypt any given text.
    /// </summary>
    internal interface IEncryptionAlgorithm
    {
        /// <summary>
        /// Provided key chain, will encrypt any given text.
        /// </summary>
        /// <param name="textToEncrypt">Text to encrypt.</param>
        /// <param name="keyToEncryptWith">Key chain with which the text will be encrypted.</param>
        /// <returns></returns>
        string[] Encrypt(string[] textToEncrypt, Infrastructure.Key[] keyToEncryptWith);

        /// <summary>
        /// Event to represent an progress of action.
        /// </summary>
        event Action ProgressUpdate;
    }
}
