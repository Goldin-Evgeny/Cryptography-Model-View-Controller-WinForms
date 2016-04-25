using System.Windows.Forms;

namespace CryptoWindowsFormsApplication.ProcessDone
{
    public partial class ProcessDoneView : UserControl, IProcessDoneView
    {

        public ProcessDoneView()
        {
            InitializeComponent();
        }

        public LinkLabel FileDirectoryLink
        {
            get { return _fileDirectoryLink; }
        }

        public LinkLabel KeyFileDirectoryLink
        {
            get { return _keyFileDirectoryLink; }
        }

        public Button FinishButton
        {
            get { return _finishButton; }
        }
    }
}
