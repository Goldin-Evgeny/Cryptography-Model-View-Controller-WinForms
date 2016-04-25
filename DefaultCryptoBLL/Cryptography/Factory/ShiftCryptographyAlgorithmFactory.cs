using Contracts;
using DefaultCryptoBLL.Cryptography.ShiftMultiply;
using DefaultCryptoBLL.Cryptography.ShiftUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultCryptoBLL.Cryptography.Factory
{
    /// <summary>
    /// Provides methods dealing with creating an cryptography instances.
    /// </summary>
    internal static class ShiftCryptographyAlgorithmFactory
    {
        #region Class variable

        private static readonly Dictionary<Type, ICryptographyAlgorithm> CryptographyAlgorithmCollection = GetAlgorithmCollection();

        #endregion

        #region Private class methods

        private static Dictionary<Type, ICryptographyAlgorithm> GetAlgorithmCollection()
        {
            return new Dictionary<Type, ICryptographyAlgorithm>
            {
                {typeof (ShiftUpCryptography), new ShiftUpCryptography()},
                {typeof (ShiftMultiplyCryptography), new ShiftMultiplyCryptography()}
            };
        }

        #endregion

        #region Public class methods

        /// <summary>
        /// Returns an ICryptographyAlgorithm implementation class.
        /// </summary>
        /// <param name="type">Cryptography type.</param>
        /// <returns>Cryptography algorithm implementation instance.</returns>
        public static ICryptographyAlgorithm CreateInstance(Type type)
        {
            return CryptographyAlgorithmCollection[type];
        }

        #endregion
    }
}
