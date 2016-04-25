using Infrastructure;
using System;

namespace Contracts
{
    /// <summary>
    /// Provides basic methods to encrypt and decrypt any given text.
    /// </summary>
    public interface ICryptographyAlgorithm
    {
        /// <summary>
        /// Event to represent an progress of action.
        /// </summary>
        event Action ProgressUpdate;

        /// <summary>
        /// Encrypts any given text.
        /// </summary>
        /// <param name="textToEncrypt">Text to encrypt</param>
        /// <returns>Encrypted text</returns>
        string[] Encrypt(string[] textToEncrypt);

        /// <summary>
        /// Decrypts any given text.
        /// </summary>
        /// <param name="textToDecrypt">Text to decrypt.</param>
        /// <param name="keyToDecryptWith">A set of keys with which the text will be decrypted.</param>
        /// <returns>Decrypted text.</returns>
        string[] Decrypt(string[] textToDecrypt, Key[] keyToDecryptWith);

        /// <summary>
        /// Returns a key chain.
        /// </summary>
        /// <returns>Key array.</returns>
        Key[] KeyChain { get; }

        /// <summary>
        /// Returns an int representation of the lenght for maximum key value.
        /// </summary>
        int KeyStrength { get; }
    }
}
