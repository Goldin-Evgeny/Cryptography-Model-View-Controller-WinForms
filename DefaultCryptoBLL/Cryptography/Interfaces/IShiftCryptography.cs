using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultCryptoBLL.Cryptography.Interfaces
{
    /// <summary>
    /// Provides basic methods to encrypt and decrypt any given text using simple character shifting.
    /// </summary>
    public interface IShiftCryptography : ICryptographyAlgorithm {}
}
