using Infrastructure;
using System;

namespace Contracts
{
    /// <summary>
    /// Provides abstract functionality to encrypt and decrypt files.
    /// </summary>
    public interface IFileCryptographer
    {
        #region Events

        event Action BadKeyFileRead;
        event Action EncryptionStarted;
        event Action<string,string> EncryptionEnded;
        event Action DecryptionStarted;
        event Action<string> DecryptionEnded;
        event Action<int> ProgressUpdate;

        #endregion

        #region Abstract methods

        /// <summary>
        /// Provided text file to read directory, will read the file, encrypt and save to specified location encrypted text and key.
        /// </summary>
        /// <param name="originalFilePath">Plain text file to be encrypted directory.</param>
        /// <param name="outputFilePath">Encrypted file to be saved directory.</param>
        /// <param name="keyPath">Key file to be saved directory.</param>
        TimeSpan EncryptFile(ICryptography cryptographyModel);

        /// <summary>
        /// Provided text file to read directory, will read the file, decrypt and save to specified location decrypted text and key.
        /// </summary>
        /// <param name="encryptedFilePath">Encrypted text file to be decrypted directory.</param>
        /// <param name="outputFilePath">Decrypted file to be saved directory.</param>
        /// <param name="keyPath">Key file to be read and be used to dycrypt directory.</param>
        TimeSpan DecryptFile(ICryptography cryptographyModel);

        /// <summary>
        /// Resets the object to initialized state.
        /// </summary>
        void ResetToDefult();
        
        #endregion
    }
}
