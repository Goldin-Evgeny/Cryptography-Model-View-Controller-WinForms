using System.Windows.Forms;

namespace CryptoWindowsFormsApplication.DecryptionPreparation
{
    public partial class DecryptionPreparationView : UserControl, IDecryptionPreparationView
    {
        #region Constructors

        public DecryptionPreparationView()
        {
            InitializeComponent();
        } 

        #endregion

        public Button PreviousButton => _nextPreviousView._previousButton;

        public Button NextButton => _nextPreviousView._nextButton;

        public TextBox FileDirectoryTextBox => _fileBrowseView._directoryTextBox;

        public Button BrowseFileButton => _fileBrowseView._browseButton;

        public TextBox KeyFileDirectoryTextBox => _keyFileBrowseView._directoryTextBox;

        public Button BrowseKeyFileButton => _keyFileBrowseView._browseButton;
    }
}
