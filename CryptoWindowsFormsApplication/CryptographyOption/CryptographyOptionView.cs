using System.Windows.Forms;

namespace CryptoWindowsFormsApplication.CryptographyOption
{
    public partial class CryptographyOptionView : UserControl, ICryptographyOptionView
    {

        #region Constructors

        public CryptographyOptionView()
        {
            InitializeComponent();
        }

        #endregion

        public Button DecryptButton => _decryptButton;
        public Button EncryptButton => _encryptButton;
        public LinkLabel DecryptionInfoLink => _decryptionInfoLink;
        public LinkLabel EncryptionInfoLink => _encryptionInfoLink;
    }
}
