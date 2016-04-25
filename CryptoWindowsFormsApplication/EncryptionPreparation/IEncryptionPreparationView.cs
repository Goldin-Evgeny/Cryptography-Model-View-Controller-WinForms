using System.Windows.Forms;

namespace CryptoWindowsFormsApplication.EncryptionPreparation
{
    public interface IEncryptionPreparationView
    {
        Button NextButton { get; }
        Button PreviousButton { get; }
        Button BrowseButton { get; }
        ComboBox CryptographyAlgorithmComboBox { get; }
        ComboBox SubCryptographyAlgorithmComboBox { get; }
        TextBox DirectoryTextBox { get; }
        NumericUpDown RepeatsUpDown { get; }
        Label RepeatsLabel { get; }
        Label SubEncryptionLabel { get; }

    }
}
