using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultCryptoBLL.Cryptography
{
    /// <summary>
    /// A class which provides compare mechanism of algorithm based on their key strength.
    /// </summary>
    internal class CryptographyComparer : IComparer<ICryptographyAlgorithm>
    {
        #region Public methods

        public int Compare(ICryptographyAlgorithm firstAlgorithm, ICryptographyAlgorithm secondAlgorithm)
        {
            if (firstAlgorithm.KeyStrength > secondAlgorithm.KeyStrength)
                return 1;

            if (firstAlgorithm.KeyStrength < secondAlgorithm.KeyStrength)
                return -1;

            return 0;
        }

        #endregion
    }
}
