using System;

namespace Contracts
{
    public interface ICryptography
    {
        event Action ModelUpdated;

        ICryptographyAlgorithmModel CryptographyAlgorithmModel { get; set; }
        string OriginalFileDirectory { get; set; }
        string KeyFileDirectory { get; set; }
        string OutputFileDirectory { get; set; }

        void Reset();
    }
}
