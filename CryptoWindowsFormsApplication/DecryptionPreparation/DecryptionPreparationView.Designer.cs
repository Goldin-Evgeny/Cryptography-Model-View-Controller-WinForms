using System.Windows.Forms;
using CryptoWindowsFormsApplication.Cryptography;

namespace CryptoWindowsFormsApplication.DecryptionPreparation
{
    partial class DecryptionPreparationView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._selectDecryptedLabel = new System.Windows.Forms.Label();
            this._keyFileLabel = new System.Windows.Forms.Label();
            this._nextPreviousView = new CryptoWindowsFormsApplication.NextPrevious.NextPreviousView();
            this._fileBrowseView = new CryptoWindowsFormsApplication.Browse.BrowseView();
            this._keyFileBrowseView = new CryptoWindowsFormsApplication.Browse.BrowseView();
            this.SuspendLayout();
            // 
            // _selectDecryptedLabel
            // 
            this._selectDecryptedLabel.AutoSize = true;
            this._selectDecryptedLabel.Location = new System.Drawing.Point(3, 4);
            this._selectDecryptedLabel.Name = "_selectDecryptedLabel";
            this._selectDecryptedLabel.Size = new System.Drawing.Size(124, 13);
            this._selectDecryptedLabel.TabIndex = 6;
            this._selectDecryptedLabel.Text = "Select path to source file";
            // 
            // _keyFileLabel
            // 
            this._keyFileLabel.AutoSize = true;
            this._keyFileLabel.Location = new System.Drawing.Point(3, 100);
            this._keyFileLabel.Name = "_keyFileLabel";
            this._keyFileLabel.Size = new System.Drawing.Size(109, 13);
            this._keyFileLabel.TabIndex = 7;
            this._keyFileLabel.Text = "Select path to key file";
            // 
            // _nextPreviousView
            // 
            this._nextPreviousView.Location = new System.Drawing.Point(0, 326);
            this._nextPreviousView.Name = "_nextPreviousView";
            this._nextPreviousView.Size = new System.Drawing.Size(370, 31);
            this._nextPreviousView.TabIndex = 8;
            _nextPreviousView._nextButton.Tag = ViewEnumRepresentation.ProcessProgress;
            _nextPreviousView._previousButton.Tag = ViewEnumRepresentation.CryptographyOption;
            // 
            // _fileBrowseView
            // 
            this._fileBrowseView.Location = new System.Drawing.Point(0, 20);
            this._fileBrowseView.Name = "_fileBrowseView";
            this._fileBrowseView.Size = new System.Drawing.Size(370, 32);
            this._fileBrowseView.TabIndex = 9;
            // 
            // _keyFileBrowseView2
            // 
            this._keyFileBrowseView.Location = new System.Drawing.Point(0, 116);
            this._keyFileBrowseView.Name = "_keyFileBrowseView2";
            this._keyFileBrowseView.Size = new System.Drawing.Size(370, 32);
            this._keyFileBrowseView.TabIndex = 10;
            // 
            // DecryptionPreparationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._keyFileBrowseView);
            this.Controls.Add(this._fileBrowseView);
            this.Controls.Add(this._nextPreviousView);
            this.Controls.Add(this._keyFileLabel);
            this.Controls.Add(this._selectDecryptedLabel);
            this.Name = "DecryptionPreparationView";
            this.Size = new System.Drawing.Size(370, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Label _selectDecryptedLabel;
        internal Label _keyFileLabel;
        private NextPrevious.NextPreviousView _nextPreviousView;
        private Browse.BrowseView _fileBrowseView;
        private Browse.BrowseView _keyFileBrowseView;
    }
}
