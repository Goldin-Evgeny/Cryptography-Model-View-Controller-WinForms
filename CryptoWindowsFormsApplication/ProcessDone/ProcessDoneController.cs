using Contracts;
using Infrastructure;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CryptoWindowsFormsApplication.ProcessDone
{
    public class ProcessDoneController:IController
    {
        public event EventHandler NextView;
        public UserControl View { get { return _view as UserControl; } }
        

        private ICryptography Model;

        private readonly IProcessDoneView _view;

        public ProcessDoneController(IProcessDoneView view, ICryptography model)
        {
            _view = view;
            Model = model;
            Model.ModelUpdated += ModelUpdated;
            InitializeView();
        }

        private void ModelUpdated()
        {
            //The output file will always be what I need...!!!!
            //But the vesabilisty of the key directory should be based on something
            _view.FileDirectoryLink.Text = Model.OutputFileDirectory;
            _view.KeyFileDirectoryLink.Text = Model.KeyFileDirectory;
        }

        private void InitializeView()
        {
            _view.FinishButton.Click += OnFinish;
            _view.FileDirectoryLink.Click += OnFileClick;
            _view.KeyFileDirectoryLink.Click += OnKeyFile;

        }

        private void OnKeyFile(object sender, EventArgs e)
        {
            Process.Start(_view.KeyFileDirectoryLink.Text);
        }

        private void OnFileClick(object sender, EventArgs e)
        {
            Process.Start(_view.FileDirectoryLink.Text);
            //Directory only open with file selected
        }

        private void OnFinish(object sender, EventArgs e)
        {
            //Reset the model?
            //Invoke
            NextView?.Invoke(sender, e);
        }
    }
}
