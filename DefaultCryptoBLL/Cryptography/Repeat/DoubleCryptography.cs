using DefaultCryptoBLL.Cryptography.Interfaces;

namespace DefaultCryptoBLL.Cryptography.RepeatCryptography
{
    /// <summary>
    /// Provides machanism to encrypt and decrypt any given text using Double cryptography.
    /// </summary>
    public class DoubleCryptography<T> : RepeatCryptography<T> where T : IShiftCryptography
    {
        #region Constructor

        public DoubleCryptography() : base(2) { }

        #endregion

    }
}
