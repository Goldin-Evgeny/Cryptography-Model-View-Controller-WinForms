using System.Windows.Forms;
using CryptoWindowsFormsApplication.Cryptography;

namespace CryptoWindowsFormsApplication.ProcessDone
{
    partial class ProcessDoneView
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
            this.ProcessDoneLabel = new System.Windows.Forms.Label();
            this.FileLabel = new System.Windows.Forms.Label();
            this._fileDirectoryLink = new System.Windows.Forms.LinkLabel();
            this.KeyFileLabel = new System.Windows.Forms.Label();
            this._keyFileDirectoryLink = new System.Windows.Forms.LinkLabel();
            this._finishButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProcessDoneLabel
            // 
            this.ProcessDoneLabel.AutoSize = true;
            this.ProcessDoneLabel.Location = new System.Drawing.Point(3, 0);
            this.ProcessDoneLabel.Name = "ProcessDoneLabel";
            this.ProcessDoneLabel.Size = new System.Drawing.Size(85, 13);
            this.ProcessDoneLabel.TabIndex = 1;
            this.ProcessDoneLabel.Text = "Process is done!";
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Location = new System.Drawing.Point(3, 25);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(117, 13);
            this.FileLabel.TabIndex = 2;
            this.FileLabel.Text = "File has been saved to:";
            // 
            // _fileDirectoryLink
            // 
            this._fileDirectoryLink.AutoSize = true;
            this._fileDirectoryLink.Location = new System.Drawing.Point(3, 51);
            this._fileDirectoryLink.Name = "_fileDirectoryLink";
            this._fileDirectoryLink.Size = new System.Drawing.Size(43, 13);
            this._fileDirectoryLink.TabIndex = 3;
            this._fileDirectoryLink.TabStop = true;
            this._fileDirectoryLink.Text = "D:\\a.txt";
            // 
            // KeyFileLabel
            // 
            this.KeyFileLabel.AutoSize = true;
            this.KeyFileLabel.Location = new System.Drawing.Point(3, 80);
            this.KeyFileLabel.Name = "KeyFileLabel";
            this.KeyFileLabel.Size = new System.Drawing.Size(135, 13);
            this.KeyFileLabel.TabIndex = 4;
            this.KeyFileLabel.Text = "Key file has been saved to:";
            // 
            // _keyFileDirectoryLink
            // 
            this._keyFileDirectoryLink.AutoSize = true;
            this._keyFileDirectoryLink.Location = new System.Drawing.Point(3, 107);
            this._keyFileDirectoryLink.Name = "_keyFileDirectoryLink";
            this._keyFileDirectoryLink.Size = new System.Drawing.Size(66, 13);
            this._keyFileDirectoryLink.TabIndex = 5;
            this._keyFileDirectoryLink.TabStop = true;
            this._keyFileDirectoryLink.Text = "D:\\a_key.txt";
            // 
            // _finishButton
            // 
            this._finishButton.Location = new System.Drawing.Point(292, 334);
            this._finishButton.Name = "_finishButton";
            this._finishButton.Size = new System.Drawing.Size(75, 23);
            this._finishButton.TabIndex = 6;
            this._finishButton.Tag = "Next";
            this._finishButton.Text = "Finish";
            this._finishButton.UseVisualStyleBackColor = true;
            _finishButton.Tag = ViewEnumRepresentation.CryptographyOption;
            // 
            // ProcessDoneView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._finishButton);
            this.Controls.Add(this._keyFileDirectoryLink);
            this.Controls.Add(this.KeyFileLabel);
            this.Controls.Add(this._fileDirectoryLink);
            this.Controls.Add(this.FileLabel);
            this.Controls.Add(this.ProcessDoneLabel);
            this.Name = "ProcessDoneView";
            this.Size = new System.Drawing.Size(370, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Label ProcessDoneLabel;
        internal Label FileLabel;
        internal LinkLabel _fileDirectoryLink;
        internal Label KeyFileLabel;
        internal LinkLabel _keyFileDirectoryLink;
        internal Button _finishButton;
    }
}
