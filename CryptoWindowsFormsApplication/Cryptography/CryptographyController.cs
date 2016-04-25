using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Contracts;
using CryptoWindowsFormsApplication.CryptographyOption;
using CryptoWindowsFormsApplication.DecryptionPreparation;
using CryptoWindowsFormsApplication.EncryptionPreparation;
using CryptoWindowsFormsApplication.ProcessDone;
using CryptoWindowsFormsApplication.ProcessProgress;

namespace CryptoWindowsFormsApplication.Cryptography
{
    public class CryptographyController
    {

        //Should be the decisive force behind which UserControl to display and when.
        private ICryptographyView _view;
        private readonly ICryptography _model;
        private IFileCryptographer _fileCryptographer;
        private Dictionary<ViewEnumRepresentation, IController> _controllers;
        private ViewEnumRepresentation _currentViewEnum;

        public CryptographyController(ICryptographyView view, ICryptography model, IFileCryptographer bl)
        {
            //Assigning value
            _view = view;
            _model = model;
            _fileCryptographer = bl;

            InitializeControllers();
            _currentViewEnum = ViewEnumRepresentation.CryptographyOption;
            
            _view.ContainerPanel.Controls.Add(_controllers[_currentViewEnum].View);
        }

        private void InitializeControllers()
        {
            IController cryptographyOptionController = new CryptographyOptionController(new CryptographyOptionView(), _model);
            IController decryptionPreparationController = new DecryptionPreparationController(new DecryptionPreparationView(), _model);
            IController encryptionPreparationController = new EncryptionPreparationController(new EncryptionPreparationView(), _model);
            IController processDoneController = new ProcessDoneController(new ProcessDoneView(), _model);
            IController processProgressController = new ProcessProgresController(new ProcessProgressView(), _model, _fileCryptographer);

            cryptographyOptionController.NextView += NextView;
            decryptionPreparationController.NextView += NextView;
            encryptionPreparationController.NextView += NextView;
            processProgressController.NextView += NextView;
            processDoneController.NextView += NextView;

            _controllers = new Dictionary<ViewEnumRepresentation, IController>()
            {
                { ViewEnumRepresentation.CryptographyOption, cryptographyOptionController },
                { ViewEnumRepresentation.DecryptionPreparation, decryptionPreparationController},
                { ViewEnumRepresentation.EncryptionPreparation, encryptionPreparationController},
                { ViewEnumRepresentation.ProcessDone, processDoneController},
                { ViewEnumRepresentation.ProcessProgress, processProgressController }

            };
        }

        private void NextView(object sender, EventArgs e)
        {

            ViewEnumRepresentation nextView = (ViewEnumRepresentation)((Button)sender).Tag;
            if (nextView == ViewEnumRepresentation.ProcessProgress)
            {
                if (_currentViewEnum == ViewEnumRepresentation.EncryptionPreparation)
                    ((ProcessProgresController)_controllers[nextView]).Encrypt();
                else
                {
                    ((ProcessProgresController)_controllers[nextView]).Decrypt();
                }
            }
            _view.ContainerPanel.Controls.Clear();
            _view.ContainerPanel.Controls.Add(_controllers[nextView].View);
            _currentViewEnum = nextView;
        }
    }
}
