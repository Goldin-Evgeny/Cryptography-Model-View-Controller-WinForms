using System.Windows.Forms;
using CryptoWindowsFormsApplication.Cryptography;

namespace CryptoWindowsFormsApplication.CryptographyOption
{
    partial class CryptographyOptionView
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
            this._encryptionAlgorithmGroupBox = new System.Windows.Forms.GroupBox();
            this._descriptionLabel = new System.Windows.Forms.Label();
            this._encryptionInfoLink = new System.Windows.Forms.LinkLabel();
            this._encryptButton = new System.Windows.Forms.Button();
            this._decryptionGroupBox = new System.Windows.Forms.GroupBox();
            this._decryptionInfoLink = new System.Windows.Forms.LinkLabel();
            this._decryptButton = new System.Windows.Forms.Button();
            this._decryptinDescription = new System.Windows.Forms.Label();
            this._encryptionAlgorithmGroupBox.SuspendLayout();
            this._decryptionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _encryptionAlgorithmGroupBox
            // 
            this._encryptionAlgorithmGroupBox.Controls.Add(this._descriptionLabel);
            this._encryptionAlgorithmGroupBox.Controls.Add(this._encryptionInfoLink);
            this._encryptionAlgorithmGroupBox.Controls.Add(this._encryptButton);
            this._encryptionAlgorithmGroupBox.Location = new System.Drawing.Point(4, 4);
            this._encryptionAlgorithmGroupBox.Name = "_encryptionAlgorithmGroupBox";
            this._encryptionAlgorithmGroupBox.Size = new System.Drawing.Size(363, 170);
            this._encryptionAlgorithmGroupBox.TabIndex = 0;
            this._encryptionAlgorithmGroupBox.TabStop = false;
            this._encryptionAlgorithmGroupBox.Text = "Encryption Algorithm";
            // 
            // _descriptionLabel
            // 
            this._descriptionLabel.AutoSize = true;
            this._descriptionLabel.Location = new System.Drawing.Point(6, 16);
            this._descriptionLabel.Name = "_descriptionLabel";
            this._descriptionLabel.Size = new System.Drawing.Size(56, 13);
            this._descriptionLabel.TabIndex = 5;
            this._descriptionLabel.Text = "Discription";
            // 
            // _encryptionInfoLink
            // 
            this._encryptionInfoLink.AutoSize = true;
            this._encryptionInfoLink.Location = new System.Drawing.Point(4, 144);
            this._encryptionInfoLink.Name = "_encryptionInfoLink";
            this._encryptionInfoLink.Size = new System.Drawing.Size(176, 13);
            this._encryptionInfoLink.TabIndex = 4;
            this._encryptionInfoLink.TabStop = true;
            this._encryptionInfoLink.Text = "More information on Shift encryption";
            // 
            // _encryptButton
            // 
            this._encryptButton.Location = new System.Drawing.Point(282, 139);
            this._encryptButton.Name = "_encryptButton";
            this._encryptButton.Size = new System.Drawing.Size(75, 23);
            this._encryptButton.TabIndex = 3;
            this._encryptButton.Tag = ViewEnumRepresentation.EncryptionPreparation;
            this._encryptButton.Text = "Encrypt";
            this._encryptButton.UseVisualStyleBackColor = true;
            // 
            // _decryptionGroupBox
            // 
            this._decryptionGroupBox.Controls.Add(this._decryptionInfoLink);
            this._decryptionGroupBox.Controls.Add(this._decryptButton);
            this._decryptionGroupBox.Controls.Add(this._decryptinDescription);
            this._decryptionGroupBox.Location = new System.Drawing.Point(4, 181);
            this._decryptionGroupBox.Name = "_decryptionGroupBox";
            this._decryptionGroupBox.Size = new System.Drawing.Size(363, 169);
            this._decryptionGroupBox.TabIndex = 1;
            this._decryptionGroupBox.TabStop = false;
            this._decryptionGroupBox.Text = "Decryption";
            // 
            // _decryptionInfoLink
            // 
            this._decryptionInfoLink.AutoSize = true;
            this._decryptionInfoLink.Location = new System.Drawing.Point(4, 140);
            this._decryptionInfoLink.Name = "_decryptionInfoLink";
            this._decryptionInfoLink.Size = new System.Drawing.Size(170, 13);
            this._decryptionInfoLink.TabIndex = 2;
            this._decryptionInfoLink.TabStop = true;
            this._decryptionInfoLink.Text = "More information on the decryption";
            // 
            // _decryptButton
            // 
            this._decryptButton.Location = new System.Drawing.Point(282, 135);
            this._decryptButton.Name = "_decryptButton";
            this._decryptButton.Size = new System.Drawing.Size(75, 23);
            this._decryptButton.TabIndex = 1;
            this._decryptButton.Tag = ViewEnumRepresentation.DecryptionPreparation;
            this._decryptButton.Text = "Decrypt";
            this._decryptButton.UseVisualStyleBackColor = true;
            // 
            // _decryptinDescription
            // 
            this._decryptinDescription.AutoSize = true;
            this._decryptinDescription.Location = new System.Drawing.Point(12, 20);
            this._decryptinDescription.Name = "_decryptinDescription";
            this._decryptinDescription.Size = new System.Drawing.Size(60, 13);
            this._decryptinDescription.TabIndex = 0;
            this._decryptinDescription.Text = "Description";
            // 
            // CryptographyOptionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._decryptionGroupBox);
            this.Controls.Add(this._encryptionAlgorithmGroupBox);
            this.Name = "CryptographyOptionView";
            this.Size = new System.Drawing.Size(370, 360);
            this.Tag = "Encrypt";
            this._encryptionAlgorithmGroupBox.ResumeLayout(false);
            this._encryptionAlgorithmGroupBox.PerformLayout();
            this._decryptionGroupBox.ResumeLayout(false);
            this._decryptionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal GroupBox _encryptionAlgorithmGroupBox;
        internal LinkLabel _encryptionInfoLink;
        internal LinkLabel _decryptionInfoLink;
        internal Button _encryptButton;
        internal Button _decryptButton;

        internal Label _descriptionLabel;
        internal GroupBox _decryptionGroupBox;
        internal Label _decryptinDescription;
    }
}
