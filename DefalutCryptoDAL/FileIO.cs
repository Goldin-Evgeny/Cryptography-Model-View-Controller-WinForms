using Contracts;
using System;
using System.IO;

namespace DefalutCryptoDAL
{
    /// <summary>
    /// IDataAccess implementation which reads and save file to 
    /// </summary>
    public class FileIO : IDataAccess
    {
        #region Public methods

        public string[] ReadFile(Uri uri)
        {
            string[] text = File.ReadAllLines(uri.AbsolutePath);
            return text;
        }

        public void SaveFile(string[] textToSave, Uri uri)
        {
            File.WriteAllLines(uri.AbsolutePath, textToSave);
        }

        #endregion
    }
}
