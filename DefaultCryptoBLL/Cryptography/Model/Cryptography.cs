using System;
using Contracts;

namespace DefaultCryptoBLL.Cryptography.Model
{
    public class Cryptography : ICryptography
    {

        public ICryptographyAlgorithmModel _cryptographyAlgorithmModel;

        public string _keyFileDirectory;

        public string _originalFileDirectory;

        public string _outputFileDirectory;

        public ICryptographyAlgorithmModel CryptographyAlgorithmModel
        {
            get { return _cryptographyAlgorithmModel; }
            set
            {
                _cryptographyAlgorithmModel = value;
                ModelUpdated?.Invoke();
            }
        }

        public string KeyFileDirectory
        {
            get { return _keyFileDirectory; }
            set
            {
                _keyFileDirectory = value;
                ModelUpdated?.Invoke();
            }
        }

        public string OriginalFileDirectory
        {
            get { return _originalFileDirectory; }
            set
            {
                _originalFileDirectory = value;
                ModelUpdated?.Invoke();
            }
        }

        public string OutputFileDirectory
        {
            get { return _outputFileDirectory; }
            set
            {
                _outputFileDirectory = value;
                ModelUpdated?.Invoke();
            }
        }

        public event Action ModelUpdated;
        
        public Cryptography()
        {
            _cryptographyAlgorithmModel = new CryptographyAlgorithmModel();
        }
        
        public void Reset()
        {
            _cryptographyAlgorithmModel = new CryptographyAlgorithmModel();
            _keyFileDirectory = null;
            _originalFileDirectory = null;
            _outputFileDirectory = null;
        }
    }
}
