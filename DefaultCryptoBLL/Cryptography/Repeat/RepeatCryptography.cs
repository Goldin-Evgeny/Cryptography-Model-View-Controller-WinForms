using Contracts;
using DefaultCryptoBLL.Cryptography.Factory;
using DefaultCryptoBLL.Cryptography.Interfaces;
using DefaultCryptoBLL.Cryptography.Key;
using System;

namespace DefaultCryptoBLL.Cryptography.RepeatCryptography
{
    /// <summary>
    /// Provides machanism to encrypt and decrypt any given text using Repeat cryptography.
    /// </summary>
    public class RepeatCryptography<T> : ICryptographyAlgorithm where T : IShiftCryptography
    {
        #region Events

        public event Action ProgressUpdate;

        #endregion

        #region Members

        private readonly ICryptographyAlgorithm _cryptographyAlgorithm;
        private readonly int _noOfRepeats;

        #endregion

        #region Properties

        public Infrastructure.Key[] KeyChain { get; private set; }
        public int KeyStrength => _cryptographyAlgorithm.KeyStrength;

        #endregion

        #region Constructors

        public RepeatCryptography(int repeats)
        {
            this._cryptographyAlgorithm = ShiftCryptographyAlgorithmFactory.CreateInstance(typeof(T));
            _cryptographyAlgorithm.ProgressUpdate += ProgressUpdated;
            this._noOfRepeats = repeats;
        }

        #endregion

        #region Public methods

        public string[] Decrypt(string[] textToDecrypt, Infrastructure.Key[] keyToDecryptWith)
        {
            int endKeyPosition = keyToDecryptWith.Length - 1;
            string[] decryptedText = _cryptographyAlgorithm.Decrypt(textToDecrypt, new Infrastructure.Key[] { keyToDecryptWith[endKeyPosition] });
            //Do as many times as much keys in the key chain
            for (int i = 0; i < keyToDecryptWith.Length - 1; i++)
            {
                decryptedText = _cryptographyAlgorithm.Decrypt(decryptedText, new Infrastructure.Key[] { keyToDecryptWith[endKeyPosition - 1 - i] });
            }
            return decryptedText;
        }

        public string[] Encrypt(string[] textToEncrypt)
        {
            string[] encryptedText = _cryptographyAlgorithm.Encrypt(textToEncrypt);
            KeyChain = new KeyModel[_noOfRepeats];
            KeyChain[0] = _cryptographyAlgorithm.KeyChain[0];
            for (int i = 0; i < _noOfRepeats - 1; i++)
            {
                encryptedText = _cryptographyAlgorithm.Encrypt(encryptedText);
                KeyChain[i + 1] = _cryptographyAlgorithm.KeyChain[0];
            }
            return encryptedText;
        }

        protected bool Equals(RepeatCryptography<T> other)
        {
            return Equals(_cryptographyAlgorithm, other._cryptographyAlgorithm) && _noOfRepeats == other._noOfRepeats && Equals(KeyChain, other.KeyChain);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((RepeatCryptography<T>)obj);
        }

        public static bool operator ==(RepeatCryptography<T> a, RepeatCryptography<T> b)
        {
            return Equals(a, b);
        }

        public static bool operator !=(RepeatCryptography<T> a, RepeatCryptography<T> b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return int.Parse("3" + _cryptographyAlgorithm.GetHashCode() + _noOfRepeats);
        }

        #endregion

        #region Private methods

        private void ProgressUpdated()
        {
            ProgressUpdate?.Invoke();
        }

        #endregion
    }
}
