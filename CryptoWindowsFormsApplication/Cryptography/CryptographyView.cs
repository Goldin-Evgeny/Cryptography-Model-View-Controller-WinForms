using System.Windows.Forms;

namespace CryptoWindowsFormsApplication.Cryptography
{
    public partial class CryptographyView : UserControl, ICryptographyView
    {

        public CryptographyView()
        {
            InitializeComponent();
        }

        public PictureBox CryptographyPictureBoxPictureBox
        {
            get { return _pictureBox; }
        }

        public Panel ContainerPanel
        {
            get { return _panel;}
        }
    }
}
