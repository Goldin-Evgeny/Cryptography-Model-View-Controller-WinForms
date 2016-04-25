using System;
using System.Linq;
using Contracts;
using DefaultCryptoBLL.Cryptography;
using DefaultCryptoBLL.Cryptography.Exceptions;
using DefaultCryptoBLL.Cryptography.Factory;
using DefaultCryptoBLL.Cryptography.Key;
using DefaultCryptoBLL.Cryptography.RepeatCryptography;
using DefaultCryptoBLL.Cryptography.ShiftMultiply;
using DefaultCryptoBLL.Cryptography.ShiftUp;
using Infrastructure;

namespace DefaultCryptoBLL.Services
{
    /// <summary>
    /// Provides implemented functionality to encrypt and decrypt files.
    /// </summary>

    public class FileCryptographer : IFileCryptographer
    {
        #region Events

        public event Action BadKeyFileRead;
        public event Action EncryptionStarted;
        public event Action<string, string> EncryptionEnded;
        public event Action DecryptionStarted;
        public event Action<string> DecryptionEnded;
        public event Action<int> ProgressUpdate;

        #endregion

        #region Private Members

        private IDataAccess _dataAccess;
        private ICryptographyAlgorithm _cryptographyAlgorithm; //Should they be proprties?
        private Key[] _typeCryptographyKey = { new KeyModel { KeyModel = 34 } };
        private TypeCryptographyAlgorithm _typeCryptographyAlgorithm;
        private Logger _logger;
        private string[] _preActionMutableText;
        private string[] _postActionMutableText;
        private Key[] _mutableKeyModels;
        private int _currentWorkingString;

        #endregion

        #region Constractor

        public FileCryptographer(IDataAccess dataAccess)
        {
            this._dataAccess = dataAccess;
            _typeCryptographyAlgorithm = new TypeCryptographyAlgorithm();
            _logger = new Logger();
        }

        #endregion

        #region Public methods

        public TimeSpan EncryptFile(ICryptography cryptographyModel)
        {
            DetermineWantedAlgorithm(cryptographyModel.CryptographyAlgorithmModel);

            _preActionMutableText = ReadFile(cryptographyModel.OriginalFileDirectory);

            NotifyEncryptionBegun();

            TimeSpan timeSpan = Timer.MeasureTimeForAction(Encrypt);

            NotifyEncryptionDone(cryptographyModel);

            string[] encryptedTextWithCode = AddUpEncryptedTypeAndText(_postActionMutableText, GetEncryptedType());

            SaveEncryptedTextAndKey(cryptographyModel, encryptedTextWithCode);

            return timeSpan;
        }

        public TimeSpan DecryptFile(ICryptography cryptographyModel)
        {
            TimeSpan timeSpan = TimeSpan.Zero;
            try
            {
                _preActionMutableText = ReadFile(cryptographyModel.OriginalFileDirectory);

                DetermineAlgorithm();

                _mutableKeyModels = GetKeyModel(cryptographyModel.KeyFileDirectory);

                NotifyDecryptionStarted();

                timeSpan = Timer.MeasureTimeForAction(Decyrpt);

                NotifyDecryptionEnded(cryptographyModel);

                SaveText(_postActionMutableText, cryptographyModel.OutputFileDirectory);
            }
            catch (InvalidEncryptionKeyException)
            {
                NotifyBadKey();
            }
            catch (FormatException)
            {
                NotifyBadKey();
            }

            return timeSpan;
        }

        public void ResetToDefult()
        {
            _currentWorkingString = 0;
        }

        #endregion

        #region Private methods

        private void NotifyDecryptionEnded(ICryptography cryptographyModel)
        {
            DecryptionEnded?.Invoke(cryptographyModel.OutputFileDirectory);
            _logger.DecryptionEnded(cryptographyModel.OutputFileDirectory);
        }

        private void NotifyDecryptionStarted()
        {
            DecryptionStarted?.Invoke();
            _logger.DecryptionStarted();
        }

        private void NotifyEncryptionBegun()
        {
            EncryptionStarted?.Invoke();
            _logger.EncryptionStarted();
        }

        private void NotifyEncryptionDone(ICryptography cryptographyModel)
        {
            EncryptionEnded?.Invoke(cryptographyModel.OutputFileDirectory, cryptographyModel.KeyFileDirectory);
            _logger.EncryptionEnded(cryptographyModel.OutputFileDirectory, cryptographyModel.KeyFileDirectory);
        }

        private void NotifyBadKey()
        {
            BadKeyFileRead?.Invoke();
            _logger.BadKeyFileRead();
        }

        private void SaveEncryptedTextAndKey(ICryptography cryptographyModel, string[] encryptedTextWithCode)
        {
            SaveText(encryptedTextWithCode, cryptographyModel.OutputFileDirectory);
            SaveKeyText(_cryptographyAlgorithm.KeyChain, cryptographyModel.KeyFileDirectory);
        }

        private void Decyrpt()
        {
            _cryptographyAlgorithm.ProgressUpdate += ProgressUpdated;
            _postActionMutableText = _cryptographyAlgorithm.Decrypt(_preActionMutableText.Where(w => w != _preActionMutableText[_preActionMutableText.Length - 1]).ToArray(), _mutableKeyModels);
        }

        private void Encrypt()
        {
            _cryptographyAlgorithm.ProgressUpdate += ProgressUpdated;
            _postActionMutableText = _cryptographyAlgorithm.Encrypt(_preActionMutableText);
        }

        private void ProgressUpdated()
        {
            _currentWorkingString++;
            int precentage = (int)((_currentWorkingString * 100) / _preActionMutableText.Length);
            ProgressUpdate?.Invoke(precentage);
        }

        private void DetermineAlgorithm()
        {
            int decryptedCryptographyType = DecryptCryptographyType(_preActionMutableText[_preActionMutableText.Length - 1]);
            _cryptographyAlgorithm = HashCodeToAlgorithmParser.GetAlgorithm(decryptedCryptographyType);
        }

        private int DecryptCryptographyType(string v)
        {
            string[] stri = _typeCryptographyAlgorithm.Decrypt(new string[] { v }, _typeCryptographyKey);
            return int.Parse(stri[0]);
        }

        private string[] AddUpEncryptedTypeAndText(string[] encryptedText, string[] encryptionType)
        {
            string[] newArray = new string[encryptedText.Length + encryptionType.Length];
            encryptedText.CopyTo(newArray, 0);
            encryptionType.CopyTo(newArray, encryptedText.Length);
            return newArray;
        }

        private string[] GetEncryptedType()
        {
            //Get the hash code of the Cryptography interface implementation, and encrypting it.
            return _typeCryptographyAlgorithm.Encrypt(new string[] { _cryptographyAlgorithm.GetHashCode().ToString() }, _typeCryptographyKey);
        }

        private Key[] GetKeyModel(string keyPath)
        {
            string[] keyAsStr = ReadFile(keyPath);
            Key[] keyModel = KeyGenerator.Parse(keyAsStr);
            return keyModel;
        }

        private void SaveKeyText(Key[] keyModel, string keyPath)
        {
            string[] keysAsStringArray = ParseKeyArrayToString(keyModel);
            SaveText(keysAsStringArray, keyPath);
        }

        private string[] ParseKeyArrayToString(Key[] keyModel)
        {
            int arrayLenght = keyModel.Length;
            string[] keysAsStringArray = new string[arrayLenght];
            for (int i = 0; i < arrayLenght; i++)
            {
                keysAsStringArray[i] = keyModel[i].ToString();
            }
            return keysAsStringArray;
        }

        private string[] ReadFile(string encryptedFilePath)
        {
            //Will use an interface for saving text and reading text
            Uri uri = new Uri(encryptedFilePath);
            string[] text = _dataAccess.ReadFile(uri);
            return text;
        }

        private void SaveText(string[] textToSave, string path)
        {
            //Will use an interface for saving text and reading text

            Uri uri = new Uri(path);
            _dataAccess.SaveFile(textToSave, uri);
        }
        
        private void DetermineWantedAlgorithm(ICryptographyAlgorithmModel model)
        {

            switch (model.CryptographyType)
            {
                case CryptographyType.ShiftUpCryptography:
                    if (model.Repeats == 1)
                        _cryptographyAlgorithm = ShiftCryptographyAlgorithmFactory.CreateInstance(typeof(ShiftUpCryptography));
                    else if(model.Repeats == 2)
                        _cryptographyAlgorithm = new DoubleCryptography<ShiftUpCryptography>();
                    else
                        _cryptographyAlgorithm = new RepeatCryptography<ShiftUpCryptography>(model.Repeats);
                    break;
                case CryptographyType.ShiftMultiplyCryptography:
                    if (model.Repeats == 1)
                        _cryptographyAlgorithm = ShiftCryptographyAlgorithmFactory.CreateInstance(typeof(ShiftUpCryptography));
                    else if (model.Repeats == 2)
                        _cryptographyAlgorithm = new DoubleCryptography<ShiftMultiplyCryptography>();
                    else
                        _cryptographyAlgorithm = new RepeatCryptography<ShiftMultiplyCryptography>(model.Repeats);
                    break;
            }
        }

        #endregion
    }
}
