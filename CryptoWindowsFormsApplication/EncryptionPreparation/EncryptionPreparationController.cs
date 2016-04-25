using Contracts;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using CryptoWindowsFormsApplication.Properties;

namespace CryptoWindowsFormsApplication.EncryptionPreparation
{
    public class EncryptionPreparationController : IController
    {
        #region Events
        
        public event EventHandler NextView;

        #endregion

        #region Private members

        public UserControl View { get { return _view as UserControl; } }
        private readonly ICryptography _model;
        private OpenFileDialog _openFileDialog;
        private Dictionary<string, Action> _cryptographySelectionCases;
        private readonly IEncryptionPreparationView _view;

        #endregion

        #region Constructor

        public EncryptionPreparationController(IEncryptionPreparationView view, ICryptography model)
        {
            _view = view;
            _model = model;
            InitializeComponents();
        }

        #endregion

        #region Private methods

        #region Initializers

        private void InitializeComponents()
        {
            InitializeViewComponents();

            InitializeCryptographySelectionCases();

            InitializeFileDialog();
        }

        private void InitializeViewComponents()
        {
            _view.NextButton.Click += OnBegin;
            _view.PreviousButton.Click += OnPrevious;
            _view.BrowseButton.Click += OnChooseFile;

            const string shiftUp = "Shiftup cryptography";
            const string shiftMultiply = "Shiftmultiply cryptography";

            _view.CryptographyAlgorithmComboBox.Items.Add(shiftUp);
            _view.CryptographyAlgorithmComboBox.Items.Add(shiftMultiply);
            _view.CryptographyAlgorithmComboBox.Items.Add("Double cryptography");
            _view.CryptographyAlgorithmComboBox.Items.Add("Repeat cryptography");
            _view.CryptographyAlgorithmComboBox.SelectedIndex = 0;
            _view.CryptographyAlgorithmComboBox.SelectedIndexChanged += Algorithm_SelectedIndexChanged;

            _view.SubCryptographyAlgorithmComboBox.Items.Add(shiftUp);
            _view.SubCryptographyAlgorithmComboBox.Items.Add(shiftMultiply);
            _view.SubCryptographyAlgorithmComboBox.SelectedIndex = 0;
            HideSubAlgorithmAndRepeats();
        }

        private void InitializeCryptographySelectionCases()
        {
            _cryptographySelectionCases = new Dictionary<string, Action>()
            {
                { "Shiftup", HideSubAlgorithmAndRepeats},
                { "Shiftmultiply", HideSubAlgorithmAndRepeats},
                { "Repeat", ShowSubAlgorithmAndRepeats},
                { "Double", ShowSubAlgorithm}
            };

        }

        private void InitializeFileDialog()
        {
            _openFileDialog = new OpenFileDialog();
            _openFileDialog.InitialDirectory = "d:\\";
            _openFileDialog.Filter = Resources.txtFileTypeFilter;
            _openFileDialog.FilterIndex = 2;
            _openFileDialog.RestoreDirectory = true;
        }

        #endregion

        #region Buttons handlers

        private void OnChooseFile(object sender, EventArgs e)
        {
            _openFileDialog.Title = Resources.chooseFileToEncrypt;
            using (_openFileDialog)
            {
                if (_openFileDialog.ShowDialog() == DialogResult.OK) // Test result.
                {
                    _view.DirectoryTextBox.Text = _openFileDialog.FileName;
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
                //Invoke
                NextView?.Invoke(sender, e);
            }
            else
            {
                //Handle stupid ass motherfucker cock sucking cocks
            }
        }

        #endregion

        #region Model modefiers

        private void SetAlgorithmForModel()
        {
            //TODO: Try to improve this mess!!!!!!
            string encryption = GetEncryptionForComboBox(_view.CryptographyAlgorithmComboBox);
            if (encryption.Equals("Shiftup"))
            {
                _model.CryptographyAlgorithmModel.CryptographyType = CryptographyType.ShiftUpCryptography;
                _model.CryptographyAlgorithmModel.Repeats = 1;
            }
            else if (encryption.Equals("Shiftmultiply"))
            {
                _model.CryptographyAlgorithmModel.CryptographyType = CryptographyType.ShiftMultiplyCryptography;
                _model.CryptographyAlgorithmModel.Repeats = 1;
            }
            else if (encryption.Equals("Double"))
            {
                string subEncryption = GetEncryptionForComboBox(_view.SubCryptographyAlgorithmComboBox);
                if (subEncryption.Equals("Shiftup"))
                {
                    _model.CryptographyAlgorithmModel.CryptographyType = CryptographyType.ShiftUpCryptography;
                    _model.CryptographyAlgorithmModel.Repeats = 2;
                }
                else if (subEncryption.Equals("Shiftmultiply"))
                {
                    _model.CryptographyAlgorithmModel.CryptographyType = CryptographyType.ShiftMultiplyCryptography;
                    _model.CryptographyAlgorithmModel.Repeats = 2;
                }
            }
            else if (encryption.Equals("Repeat"))
            {
                string subEncryption = GetEncryptionForComboBox(_view.SubCryptographyAlgorithmComboBox);
                if (subEncryption.Equals("Shiftup"))
                {
                    _model.CryptographyAlgorithmModel.CryptographyType = CryptographyType.ShiftUpCryptography;
                    _model.CryptographyAlgorithmModel.Repeats = (int)_view.RepeatsUpDown.Value;
                }
                else if (subEncryption.Equals("Shiftmultiply"))
                {
                    _model.CryptographyAlgorithmModel.CryptographyType = CryptographyType.ShiftMultiplyCryptography;
                    _model.CryptographyAlgorithmModel.Repeats = (int)_view.RepeatsUpDown.Value;
                }
            }
        }

        private void SetPathsForModel()
        {
            string fileDirectory = _view.DirectoryTextBox.Text;
            string cleanDirectory = Path.Combine(Path.GetDirectoryName(fileDirectory), Path.GetFileNameWithoutExtension(fileDirectory));
            string encryptedFileDirectory = string.Format("{0}_encrypted.txt", cleanDirectory);
            string keyFileDirectory = string.Format("{0}_key.txt", cleanDirectory);

            _model.OriginalFileDirectory = fileDirectory;
            _model.KeyFileDirectory = keyFileDirectory;
            _model.OutputFileDirectory = encryptedFileDirectory;
        }

        #endregion

        private void ShowSubAlgorithmAndRepeats()
        {
            _view.RepeatsUpDown.Visible = true;
            _view.RepeatsLabel.Visible = true;
            ShowSubAlgorithm();
        }

        private void ShowSubAlgorithm()
        {
            _view.SubCryptographyAlgorithmComboBox.Visible = true;
            _view.SubEncryptionLabel.Visible = true;
        }

        private void HideSubAlgorithmAndRepeats()
        {
            _view.SubCryptographyAlgorithmComboBox.Visible = false;
            _view.SubEncryptionLabel.Visible = false;
            _view.RepeatsUpDown.Visible = false;
            _view.RepeatsLabel.Visible = false;
        }

        private void Algorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            string encryption = GetEncryptionForComboBox(_view.CryptographyAlgorithmComboBox);
            _cryptographySelectionCases[encryption].Invoke();
        }

        private string GetEncryptionForComboBox(ComboBox comboBox)
        {
            string selectedItem = comboBox.Text;
            return selectedItem.Substring(0, selectedItem.IndexOf(" "));
        }

        private bool IsValidInput()
        {
            // In the future might check more things
            return File.Exists(_view.DirectoryTextBox.Text);
        }

        private void UpdateModel()
        {
            SetAlgorithmForModel();

            SetPathsForModel();
        }

        #endregion
    }
}
