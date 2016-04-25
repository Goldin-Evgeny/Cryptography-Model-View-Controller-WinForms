using System;
using System.Threading;
using System.Windows.Forms;
using Contracts;
using CryptoWindowsFormsApplication.ProcessProgres;

namespace CryptoWindowsFormsApplication.ProcessProgress
{
    public class ProcessProgresController:IController
    {
        private readonly IProcessProgressView _view;
        private ICryptography _model;
        private IFileCryptographer _fileCryptographer;

        public event EventHandler NextView;

        public UserControl View { get { return _view as UserControl; }}

        public ProcessProgresController(IProcessProgressView view, ICryptography model, IFileCryptographer fileCryptographer)
        {
            _fileCryptographer = fileCryptographer;
            _view = view;
            _model = model;
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            _view.NextButton.Enabled = false;
            _view.NextButton.Click += OnNext;
        }

        private void OnNext(object sender, EventArgs e)
        {
            _view.NextButton.Enabled = false;
            _view.ProgressBar.Value = 0;
            _fileCryptographer.ResetToDefult();
            NextView?.Invoke(sender, e);
        }

        public void Encrypt()
        {
            Thread encryptionThread = new Thread(new ThreadStart(BeginEncryptionProcess));
            encryptionThread.Start();
        }
        
        public  void Decrypt()
        {
            Thread decryptionThread = new Thread(new ThreadStart(BeginDecryptionProcess));
            decryptionThread.Start();
        }

        private void ProgressUpdated(int precentage)
        {
            _view.Invoke(new Action<int>(UpdateProgressBar), precentage);
        }

        private void UpdateProgressBar(int i)
        {
            if(i < 101)
                _view.ProgressBar.Value = i;
        }

        private void BeginEncryptionProcess()
        {
            _fileCryptographer.ProgressUpdate += ProgressUpdated;
            TimeSpan timeSpan = _fileCryptographer.EncryptFile(_model);
            _view.Invoke(new Action<TimeSpan>(UpdateView), timeSpan);
        }

        private void UpdateView(TimeSpan timeSpan)
        {
            _view.ProgressBar.Value = _view.ProgressBar.Maximum;
            _view.NextButton.Enabled = true;
        }

        private void BeginDecryptionProcess()
        {
            _fileCryptographer.ProgressUpdate += ProgressUpdated;
            TimeSpan timeSpan = _fileCryptographer.DecryptFile(_model);
            _view.Invoke(new Action<TimeSpan>(UpdateView), timeSpan);
        }
    }
}
