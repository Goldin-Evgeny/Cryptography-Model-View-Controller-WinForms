using System.Windows.Forms;

namespace CryptoWindowsFormsApplication.DecryptionPreparation
{
    public interface IDecryptionPreparationView
    {
        Button PreviousButton { get; }
        Button NextButton { get; }
        TextBox FileDirectoryTextBox { get; }
        TextBox KeyFileDirectoryTextBox { get; }
        Button BrowseFileButton { get; }
        Button BrowseKeyFileButton { get; }
    }
}
