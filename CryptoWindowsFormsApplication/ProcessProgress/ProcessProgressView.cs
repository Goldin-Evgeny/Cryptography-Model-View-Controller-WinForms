using System.Windows.Forms;
using CryptoWindowsFormsApplication.ProcessProgres;

namespace CryptoWindowsFormsApplication.ProcessProgress
{
    public partial class ProcessProgressView : UserControl, IProcessProgressView
    {
        public ProcessProgressView()
        {
            InitializeComponent();
        }

        public ProgressBar ProgressBar
        {
            get { return _progressBar; }
        }

        public Label ProcessingLabel
        {
            get { return _processingLabel; }
        }

        public Button NextButton
        {
            get { return _nextButton; }
        }
    }
}
