using System;
using System.Collections.Generic;
using Contracts;
using DefaultCryptoBLL.Cryptography.ShiftUp;
using DefaultCryptoBLL.Cryptography.Factory;
using DefaultCryptoBLL.Cryptography.ShiftMultiply;
using DefaultCryptoBLL.Cryptography.RepeatCryptography;

namespace DefaultCryptoBLL.Services
{
    /// <summary>
    /// Provides functionaly to deduce the cryptography algorithm from an number.
    /// </summary>
    static class HashCodeToAlgorithmParser
    {
        #region Class Variables

        private static readonly Dictionary<int, ICryptographyAlgorithm> ShiftCryptographyAlgorithmDictionary = GetShiftAlgorithmCollection();

        #endregion

        #region Internal methods

        /// <summary>
        /// Return an ICryptographyAlgorithm implementation instance.
        /// </summary>
        /// <param name="v">Int representation of the ICryptographyAlgorithm type.</param>
        /// <returns>Cryptography algorithm implementation instance.</returns>
        internal static ICryptographyAlgorithm GetAlgorithm(int v)
        {
            ICryptographyAlgorithm algorithm = null;
            if (ShiftCryptographyAlgorithmDictionary.TryGetValue(v, out algorithm))
            {
                return algorithm;
            }
            else if (v % 10 == 2 && Math.Floor(Math.Log10(v) + 1) == 3)
            {
                Type doubleCryptographyType = typeof(DoubleCryptography<>);
                Type shiftCryptoType = ShiftCryptographyAlgorithmDictionary[(v % (10 ^ 2)) / 10 ^ (2 - 1)].GetType();//This line will return eighter ShiftUpCryptography or ShiftMultiplyCryptography type!
                Type[] doubleCryptographyGenericArgs = { shiftCryptoType };
                Type toInstantiate = doubleCryptographyType.MakeGenericType(doubleCryptographyGenericArgs);
                return (ICryptographyAlgorithm)Activator.CreateInstance(toInstantiate);
            }
            else
            {
                Type repeatCryptography = typeof(RepeatCryptography<>);
                int noOfRepeats = ConcludeNoOfRepeats(v);
                int i = (v % (10 ^ 2)) / 10 ^ (2 - 1);
                Type shiftCryptoType = ShiftCryptographyAlgorithmDictionary[i].GetType();
                Type[] repeatCryptographyGenericArgs = { shiftCryptoType };
                Type toInstantiate = repeatCryptography.MakeGenericType(repeatCryptographyGenericArgs);

                return (ICryptographyAlgorithm)Activator.CreateInstance(toInstantiate, noOfRepeats);
            }
        }

        #endregion

        #region Private methods

        private static Dictionary<int, ICryptographyAlgorithm> GetShiftAlgorithmCollection()
        {
            Dictionary<int, ICryptographyAlgorithm> collection =
                new Dictionary<int, ICryptographyAlgorithm>
                {
                    {1, ShiftCryptographyAlgorithmFactory.CreateInstance(typeof(ShiftUpCryptography))},
                    {2, ShiftCryptographyAlgorithmFactory.CreateInstance(typeof(ShiftMultiplyCryptography))}
                };
            return collection;
        }

        private static int ConcludeNoOfRepeats(int v)
        {
            int power = v.ToString().Length - 2;
            int module = (int) Math.Pow(10, power);
            return v % module;
        }

        #endregion
    }
}
