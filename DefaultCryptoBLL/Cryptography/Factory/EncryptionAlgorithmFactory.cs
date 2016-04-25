using DefaultCryptoBLL.Cryptography.Interfaces;
using DefaultCryptoBLL.Cryptography.ShiftMultiply;
using DefaultCryptoBLL.Cryptography.ShiftUp;
using System;
using System.Collections.Generic;

namespace DefaultCryptoBLL.Cryptography.Factory
{
    /// <summary>
    /// Provides methods dealing with creating an encryption instances.
    /// </summary>
    internal static class EncryptionAlgorithmFactory
    {
        #region Class variable

        private static readonly Dictionary<Type, IEncryptionAlgorithm> EncryptionAlgorithmCollection = GetAlgorithmCollection();

        #endregion

        #region Public class methods

        /// <summary>
        /// Returns an IEncryptionAlgorithm implementation class.
        /// </summary>
        /// <param name="type">Cryptography type.</param>
        /// <returns>Encryption algorithm implementation instance.</returns>
        internal static IEncryptionAlgorithm CreateInstance(Type type)
        {
            return EncryptionAlgorithmCollection[type];
        }

        #endregion

        #region Private class methods

        private static Dictionary<Type, IEncryptionAlgorithm> GetAlgorithmCollection()
        {
            Dictionary<Type, IEncryptionAlgorithm> collection =
                new Dictionary<Type, IEncryptionAlgorithm>
                {
                    {typeof (ShiftUpEncryption), new ShiftUpEncryption()},
                    {typeof (ShiftMultiplyEncryption), new ShiftMultiplyEncryption()}
                };
            //Adding various encryption algorithms
            return collection;
        }

        #endregion
    }
}
