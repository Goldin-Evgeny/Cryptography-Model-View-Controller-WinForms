using System;
using System.Windows.Forms;
using Contracts;
using System.Diagnostics;
using Infrastructure;

namespace CryptoWindowsFormsApplication.CryptographyOption
{
    public class CryptographyOptionController : IController
    {

        #region Public members

        public event EventHandler NextView;
        public UserControl View { get { return (UserControl)_view; } }

        #endregion

        #region Private members

        private ICryptography _model;

        private ICryptographyOptionView _view; 

        #endregion

        #region Constructors

        public CryptographyOptionController(ICryptographyOptionView view, ICryptography model)
        {
            _model = model;
            _view = view;
            InitializeView();
        }
        
        #endregion

        #region Private methods

        private void InitializeView()
        {
            _view.EncryptButton.Click += OnEncrypt;
            _view.DecryptButton.Click += OnDecrypt;
            _view.EncryptionInfoLink.Click += OnEncryptInfo;
            _view.DecryptionInfoLink.Click += OnDecryptInfo;
        }

        private void OnDecryptInfo(object sender, EventArgs e)
        {
            Process.Start("https://en.wikipedia.org/wiki/Bullshit");
        }

        private void OnEncryptInfo(object sender, EventArgs e)
        {
            Process.Start("https://en.wikipedia.org/wiki/Bullshit");
        }

        private void OnDecrypt(object sender, EventArgs e)
        {
            //Invoke
            _model.Reset();
            NextView?.Invoke(sender, e);
        }

        private void OnEncrypt(object sender, EventArgs e)
        {
            //Invoke
            _model.Reset();
            NextView?.Invoke(sender, e);
        } 

        #endregion
    }
}
