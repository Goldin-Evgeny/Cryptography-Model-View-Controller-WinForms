using System;

namespace Contracts
{
    /// <summary>
    /// Provides basic operations to manage text files IO.
    /// </summary>
    public interface IDataAccess
    {
        /// <summary>
        /// Reads file from the specified uri.
        /// </summary>
        /// <param name="uri">Uri from which the file will be read.</param>
        /// <returns>Read text file.</returns>
        string[] ReadFile(Uri uri);

        /// <summary>
        /// Provided text, will save to specified to uri.
        /// </summary>
        /// <param name="textToSave">The text file to save.</param>
        /// <param name="uri">Uri to where to save the file.</param>
        void SaveFile(string[] textToSave, Uri uri);
    }
}
