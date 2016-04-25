namespace CryptoWindowsFormsApplication.NextPrevious
{
    partial class NextPreviousView
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
            this._previousButton = new System.Windows.Forms.Button();
            this._nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _previousButton
            // 
            this._previousButton.Location = new System.Drawing.Point(4, 4);
            this._previousButton.Name = "_previousButton";
            this._previousButton.Size = new System.Drawing.Size(75, 23);
            this._previousButton.TabIndex = 0;
            this._previousButton.Tag = "Previous";
            this._previousButton.Text = "< Previous";
            this._previousButton.UseVisualStyleBackColor = true;
            // 
            // _nextButton
            // 
            this._nextButton.Location = new System.Drawing.Point(292, 4);
            this._nextButton.Name = "_nextButton";
            this._nextButton.Size = new System.Drawing.Size(75, 23);
            this._nextButton.TabIndex = 1;
            this._nextButton.Tag = "Next";
            this._nextButton.Text = "Next >";
            this._nextButton.UseVisualStyleBackColor = true;
            // 
            // NextPreviousView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._nextButton);
            this.Controls.Add(this._previousButton);
            this.Name = "NextPreviousView";
            this.Size = new System.Drawing.Size(370, 31);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button _previousButton;
        internal System.Windows.Forms.Button _nextButton;
    }
}
