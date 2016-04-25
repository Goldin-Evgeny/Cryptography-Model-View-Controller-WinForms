using DefaultCryptoBLL.Cryptography.Interfaces;
using DefaultCryptoBLL.Cryptography.ShiftMultiply;
using DefaultCryptoBLL.Cryptography.ShiftUp;
using System;
using System.Collections.Generic;

namespace DefaultCryptoBLL.Cryptography.Factory
{
    /// <summary>
    /// Provides methods dealing with creating an decryption instances.
    /// </summary>
    internal static class DecryptionAlgorithmFactory
    {
        #region Class variable

        private static readonly Dictionary<Type, IDecryptionAlgorithm> DecryptionAlgorithmCollection = GetAlgorithmCollection();

        #endregion

        #region Private class methods

        private static Dictionary<Type, IDecryptionAlgorithm> GetAlgorithmCollection()
        {
            Dictionary<Type, IDecryptionAlgorithm> collection =
                new Dictionary<Type, IDecryptionAlgorithm>
                {
                    {typeof(ShiftUpDecryption), new ShiftUpDecryption()},
                    {typeof(ShiftMultiplyDecryption), new ShiftMultiplyDecryption()}
                };
            return collection;
        }

        #endregion

        #region Internal class methods

        /// <summary>
        /// Returns an IDecryptionAlgorithm implementation class.
        /// </summary>
        /// <param name="type">Cryptography type.</param>
        /// <returns>Decryption algorithm implementation instance</returns>
        internal static IDecryptionAlgorithm CreateInstance(Type type)
        {
            return DecryptionAlgorithmCollection[type];
        }

        #endregion
    }
}
