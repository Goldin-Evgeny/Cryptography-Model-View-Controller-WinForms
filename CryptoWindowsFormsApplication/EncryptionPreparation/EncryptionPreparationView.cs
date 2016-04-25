using System.Windows.Forms;

namespace CryptoWindowsFormsApplication.EncryptionPreparation
{
    public partial class EncryptionPreparationView : UserControl, IEncryptionPreparationView
    {
        public UserControl Process;

        public EncryptionPreparationView()
        {
            InitializeComponent();
        }

        public Button BrowseButton => _browseView._browseButton;

        public ComboBox CryptographyAlgorithmComboBox => _cryptographyAlgorithmComboBox;

        public TextBox DirectoryTextBox => _browseView._directoryTextBox;

        public Button NextButton => _nextPreviousView._nextButton;

        public Button PreviousButton => _nextPreviousView._previousButton;

        public Label RepeatsLabel => _repeatsLabel;

        public NumericUpDown RepeatsUpDown => _repeatsUpDown;

        public ComboBox SubCryptographyAlgorithmComboBox => _subCryptographyAlgorithmComboBox;

        public Label SubEncryptionLabel => _subEncryptionLabel;
    }
}
