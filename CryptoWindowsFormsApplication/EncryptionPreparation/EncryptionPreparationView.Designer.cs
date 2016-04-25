using CryptoWindowsFormsApplication.Cryptography;

namespace CryptoWindowsFormsApplication.EncryptionPreparation
{
    partial class EncryptionPreparationView
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
            this._directoryLabel = new System.Windows.Forms.Label();
            this._encryptionLabel = new System.Windows.Forms.Label();
            this._cryptographyAlgorithmComboBox = new System.Windows.Forms.ComboBox();
            this._subEncryptionLabel = new System.Windows.Forms.Label();
            this._subCryptographyAlgorithmComboBox = new System.Windows.Forms.ComboBox();
            this._repeatsLabel = new System.Windows.Forms.Label();
            this._repeatsUpDown = new System.Windows.Forms.NumericUpDown();
            this._browseView = new CryptoWindowsFormsApplication.Browse.BrowseView();
            this._nextPreviousView = new CryptoWindowsFormsApplication.NextPrevious.NextPreviousView();
            ((System.ComponentModel.ISupportInitialize)(this._repeatsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // _directoryLabel
            // 
            this._directoryLabel.AutoSize = true;
            this._directoryLabel.Location = new System.Drawing.Point(0, 142);
            this._directoryLabel.Name = "_directoryLabel";
            this._directoryLabel.Size = new System.Drawing.Size(124, 13);
            this._directoryLabel.TabIndex = 4;
            this._directoryLabel.Text = "Select path to source file";
            // 
            // _encryptionLabel
            // 
            this._encryptionLabel.AutoSize = true;
            this._encryptionLabel.Location = new System.Drawing.Point(0, 8);
            this._encryptionLabel.Name = "_encryptionLabel";
            this._encryptionLabel.Size = new System.Drawing.Size(57, 13);
            this._encryptionLabel.TabIndex = 5;
            this._encryptionLabel.Text = "Encryption";
            // 
            // _cryptographyAlgorithmComboBox
            // 
            this._cryptographyAlgorithmComboBox.FormattingEnabled = true;
            this._cryptographyAlgorithmComboBox.Location = new System.Drawing.Point(159, 5);
            this._cryptographyAlgorithmComboBox.Name = "_cryptographyAlgorithmComboBox";
            this._cryptographyAlgorithmComboBox.Size = new System.Drawing.Size(208, 21);
            this._cryptographyAlgorithmComboBox.TabIndex = 6;
            // 
            // _subEncryptionLabel
            // 
            this._subEncryptionLabel.AutoSize = true;
            this._subEncryptionLabel.Location = new System.Drawing.Point(0, 38);
            this._subEncryptionLabel.Name = "_subEncryptionLabel";
            this._subEncryptionLabel.Size = new System.Drawing.Size(78, 13);
            this._subEncryptionLabel.TabIndex = 7;
            this._subEncryptionLabel.Text = "Sub encryption";
            this._subEncryptionLabel.Visible = false;
            // 
            // _subCryptographyAlgorithmComboBox
            // 
            this._subCryptographyAlgorithmComboBox.FormattingEnabled = true;
            this._subCryptographyAlgorithmComboBox.Location = new System.Drawing.Point(159, 35);
            this._subCryptographyAlgorithmComboBox.Name = "_subCryptographyAlgorithmComboBox";
            this._subCryptographyAlgorithmComboBox.Size = new System.Drawing.Size(208, 21);
            this._subCryptographyAlgorithmComboBox.TabIndex = 8;
            this._subCryptographyAlgorithmComboBox.Visible = false;
            // 
            // _repeatsLabel
            // 
            this._repeatsLabel.AutoSize = true;
            this._repeatsLabel.Location = new System.Drawing.Point(0, 66);
            this._repeatsLabel.Name = "_repeatsLabel";
            this._repeatsLabel.Size = new System.Drawing.Size(47, 13);
            this._repeatsLabel.TabIndex = 9;
            this._repeatsLabel.Text = "Repeats";
            this._repeatsLabel.Visible = false;
            // 
            // _repeatsUpDown
            // 
            this._repeatsUpDown.Location = new System.Drawing.Point(323, 64);
            this._repeatsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._repeatsUpDown.Name = "_repeatsUpDown";
            this._repeatsUpDown.Size = new System.Drawing.Size(44, 20);
            this._repeatsUpDown.TabIndex = 10;
            this._repeatsUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._repeatsUpDown.Visible = false;
            // 
            // _browseView
            // 
            this._browseView.Location = new System.Drawing.Point(0, 158);
            this._browseView.Name = "_browseView";
            this._browseView.Size = new System.Drawing.Size(370, 32);
            this._browseView.TabIndex = 11;
            // 
            // _nextPreviousView
            // 
            this._nextPreviousView.Location = new System.Drawing.Point(0, 329);
            this._nextPreviousView.Name = "_nextPreviousView";
            this._nextPreviousView.Size = new System.Drawing.Size(370, 31);
            this._nextPreviousView.TabIndex = 12;
            _nextPreviousView._nextButton.Tag = ViewEnumRepresentation.ProcessProgress;
            _nextPreviousView._previousButton.Tag = ViewEnumRepresentation.CryptographyOption;
            // 
            // EncryptionPreparationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._nextPreviousView);
            this.Controls.Add(this._browseView);
            this.Controls.Add(this._repeatsUpDown);
            this.Controls.Add(this._repeatsLabel);
            this.Controls.Add(this._subCryptographyAlgorithmComboBox);
            this.Controls.Add(this._subEncryptionLabel);
            this.Controls.Add(this._cryptographyAlgorithmComboBox);
            this.Controls.Add(this._encryptionLabel);
            this.Controls.Add(this._directoryLabel);
            this.Name = "EncryptionPreparationView";
            this.Size = new System.Drawing.Size(370, 360);
            ((System.ComponentModel.ISupportInitialize)(this._repeatsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label _directoryLabel;
        internal System.Windows.Forms.Label _encryptionLabel;
        internal System.Windows.Forms.ComboBox _cryptographyAlgorithmComboBox;
        internal System.Windows.Forms.Label _subEncryptionLabel;
        internal System.Windows.Forms.ComboBox _subCryptographyAlgorithmComboBox;
        internal System.Windows.Forms.Label _repeatsLabel;
        internal System.Windows.Forms.NumericUpDown _repeatsUpDown;
        private Browse.BrowseView _browseView;
        private NextPrevious.NextPreviousView _nextPreviousView;
    }
}
