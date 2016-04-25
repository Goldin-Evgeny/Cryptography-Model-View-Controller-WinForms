using System.Windows.Forms;
using CryptoWindowsFormsApplication.Cryptography;

namespace CryptoWindowsFormsApplication.ProcessProgress
{
    partial class ProcessProgressView
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
            this._progressBar = new System.Windows.Forms.ProgressBar();
            this._processingLabel = new System.Windows.Forms.Label();
            this._nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _progressBar
            // 
            this._progressBar.Location = new System.Drawing.Point(8, 220);
            this._progressBar.Margin = new System.Windows.Forms.Padding(4);
            this._progressBar.Name = "_progressBar";
            this._progressBar.Size = new System.Drawing.Size(475, 28);
            this._progressBar.TabIndex = 0;
            // 
            // _processingLabel
            // 
            this._processingLabel.AutoSize = true;
            this._processingLabel.Location = new System.Drawing.Point(4, 201);
            this._processingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._processingLabel.Name = "_processingLabel";
            this._processingLabel.Size = new System.Drawing.Size(78, 17);
            this._processingLabel.TabIndex = 2;
            this._processingLabel.Text = "Processing";
            // 
            // _nextButton
            // 
            this._nextButton.Location = new System.Drawing.Point(381, 411);
            this._nextButton.Margin = new System.Windows.Forms.Padding(4);
            this._nextButton.Name = "_nextButton";
            this._nextButton.Size = new System.Drawing.Size(100, 28);
            this._nextButton.TabIndex = 3;
            this._nextButton.Tag = CryptoWindowsFormsApplication.Cryptography.ViewEnumRepresentation.ProcessDone;
            this._nextButton.Text = "Next >";
            this._nextButton.UseVisualStyleBackColor = true;
            // 
            // ProcessProgressView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._nextButton);
            this.Controls.Add(this._processingLabel);
            this.Controls.Add(this._progressBar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProcessProgressView";
            this.Size = new System.Drawing.Size(493, 443);
            this.Tag = "Next";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal ProgressBar _progressBar;
        internal Label _processingLabel;
        internal Button _nextButton;
    }
}
