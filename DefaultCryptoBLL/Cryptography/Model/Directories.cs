using Contracts;

namespace DefaultCryptoBLL.Cryptography.Model
{
    public class Directories : IDirectories
    {
        private string _originalFileDirectory;
        private string _keyFileDirectory;
        private string _outputFileDirectory;

        public string OriginalFileDirectory
        {
            get { return _originalFileDirectory; }
            set { _originalFileDirectory = value; }
        }

        public string KeyFileDirectory
        {
            get { return _keyFileDirectory; }
            set { _keyFileDirectory = value; }
        }

        public string OutputFileDirectory
        {
            get { return _outputFileDirectory; }
            set { _outputFileDirectory = value; }
        }
    }
}
