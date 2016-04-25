using System.Windows.Forms;

namespace CryptoWindowsFormsApplication.CryptographyOption
{
    public interface ICryptographyOptionView
    {
        Button DecryptButton { get; }
        Button EncryptButton { get;}
        LinkLabel DecryptionInfoLink { get; }
        LinkLabel EncryptionInfoLink { get; }
    }
}
