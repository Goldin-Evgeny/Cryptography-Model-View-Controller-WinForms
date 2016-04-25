using System;
using Contracts;
using System.Windows.Forms;
using System.IO;

namespace CryptoWindowsFormsApplication.DecryptionPreparation
{
    public class DecryptionPreparationController : IController
    {

        #region Public members
        
        public event EventHandler NextView;
        public UserControl View { get { return (UserControl)_view; } } 

        #endregion

        #region Private members

        private ICryptography _model;
        private OpenFileDialog _openFileDialog;
        private IDecryptionPreparationView _view;

        #endregion

        #region Constructors

        public DecryptionPreparationController(IDecryptionPreparationView view, ICryptography model)
        {
            _view = view;
            _model = model;
            InitializeComponents();
        } 

        #endregion

        #region Private methods

        private void InitializeComponents()
        {
            InitializeView();
            InitializeFileDialog();
        }

        private void InitializeView()
        {
            _view.NextButton.Click += OnBegin;
            _view.PreviousButton.Click += OnPrevious;
            _view.BrowseFileButton.Click += OnChooseFile;
            _view.BrowseKeyFileButton.Click += OnChooseKeyFile;
        }



        private void InitializeFileDialog()
        {
            _openFileDialog = new OpenFileDialog();
            _openFileDialog.InitialDirectory = "d:\\";
            _openFileDialog.Filter = "txt files (*.txt)|*.txt";
            _openFileDialog.FilterIndex = 2;
            _openFileDialog.RestoreDirectory = true;
        }

        private void OnChooseKeyFile(object sender, EventArgs e)
        {
            _openFileDialog.Title = "Choose key file";
            using (_openFileDialog)
            {
                if (_openFileDialog.ShowDialog() == DialogResult.OK) // Test result.
                {
                    _view.KeyFileDirectoryTextBox.Text = _openFileDialog.FileName;
                }
            }
        }

        private void OnChooseFile(object sender, EventArgs e)
        {
            _openFileDialog.Title = "Choose file to decrypt";
            using (_openFileDialog)
            {
                if (_openFileDialog.ShowDialog() == DialogResult.OK) // Test result.
                {
                    _view.FileDirectoryTextBox.Text = _openFileDialog.FileName;
                }
            }
        }

        private void OnPrevious(object sender, EventArgs e)
        {
            //Invoke
            NextView?.Invoke(sender, e);
        }

        private void OnBegin(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                UpdateModel();
                NextView?.Invoke(sender, e);
                //Invoke
            }
            else
            {
                //Handle bad input from mother fucker
            }
        }

        private bool IsValidInput()
        {
            // In the future might check more things
            return File.Exists(_view.FileDirectoryTextBox.Text) && File.Exists(_view.KeyFileDirectoryTextBox.Text);
        }

        private void UpdateModel()
        {
            SetPathsForModel();
        }

        private void SetPathsForModel()
        {
            string fileDirectory = _view.FileDirectoryTextBox.Text;
            string cleanDirectory = Path.Combine(Path.GetDirectoryName(fileDirectory), Path.GetFileNameWithoutExtension(fileDirectory));
            string decryptedFileDirectory = cleanDirectory + "_decrypted.txt";
            string keyFileDirectory = _view.KeyFileDirectoryTextBox.Text;

            _model.OriginalFileDirectory = fileDirectory;
            _model.KeyFileDirectory = keyFileDirectory;
            _model.OutputFileDirectory = decryptedFileDirectory;
        } 

        #endregion
    }
}
