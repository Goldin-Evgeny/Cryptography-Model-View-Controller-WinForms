using Contracts;
using Infrastructure;

namespace DefaultCryptoBLL.Cryptography.Model
{
    class CryptographyAlgorithmModel : ICryptographyAlgorithmModel
    {
        public CryptographyType CryptographyType { get; set; }

        public int Repeats { get; set; }
    }
}
