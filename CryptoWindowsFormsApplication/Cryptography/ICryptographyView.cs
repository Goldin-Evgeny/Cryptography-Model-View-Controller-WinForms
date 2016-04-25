using System.Windows.Forms;

namespace CryptoWindowsFormsApplication.Cryptography
{
    public interface ICryptographyView
    {
        PictureBox CryptographyPictureBoxPictureBox { get; }
        Panel ContainerPanel { get; }
    }
}
