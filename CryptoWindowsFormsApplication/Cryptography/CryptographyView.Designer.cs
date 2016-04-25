namespace CryptoWindowsFormsApplication.Cryptography
{
    partial class CryptographyView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CryptographyView));
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _pictureBox
            // 
            this._pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("_pictureBox.Image")));
            this._pictureBox.Location = new System.Drawing.Point(4, 4);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(218, 358);
            this._pictureBox.TabIndex = 0;
            this._pictureBox.TabStop = false;
            // 
            // _panel
            // 
            this._panel.Location = new System.Drawing.Point(229, 4);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(371, 358);
            this._panel.TabIndex = 1;
            // 
            // CryptographyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._panel);
            this.Controls.Add(this._pictureBox);
            this.Name = "CryptographyView";
            this.Size = new System.Drawing.Size(603, 368);
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox _pictureBox;
        private System.Windows.Forms.Panel _panel;
    }
}
