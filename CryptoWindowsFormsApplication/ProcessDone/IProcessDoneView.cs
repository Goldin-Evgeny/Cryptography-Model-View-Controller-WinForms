using System.Windows.Forms;

namespace CryptoWindowsFormsApplication.ProcessDone
{
    public interface IProcessDoneView
    {
        LinkLabel FileDirectoryLink { get;  }
        LinkLabel KeyFileDirectoryLink { get; }
        Button FinishButton { get; }
    }
}
