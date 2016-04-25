namespace CryptoWindowsFormsApplication.Browse
{
    partial class BrowseView
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
            this._directoryTextBox = new System.Windows.Forms.TextBox();
            this._browseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _directoryTextBox
            // 
            this._directoryTextBox.Location = new System.Drawing.Point(4, 6);
            this._directoryTextBox.Name = "_directoryTextBox";
            this._directoryTextBox.Size = new System.Drawing.Size(282, 20);
            this._directoryTextBox.TabIndex = 0;
            // 
            // _browseButton
            // 
            this._browseButton.Location = new System.Drawing.Point(292, 4);
            this._browseButton.Name = "_browseButton";
            this._browseButton.Size = new System.Drawing.Size(75, 23);
            this._browseButton.TabIndex = 1;
            this._browseButton.Text = "Browse";
            this._browseButton.UseVisualStyleBackColor = true;
            // 
            // BrowseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._browseButton);
            this.Controls.Add(this._directoryTextBox);
            this.Name = "BrowseView";
            this.Size = new System.Drawing.Size(370, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox _directoryTextBox;
        internal System.Windows.Forms.Button _browseButton;
    }
}
