
namespace Ahla
{
    partial class DownloadForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DownloadingProgress = new System.Windows.Forms.ProgressBar();
            this.DownloadingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DownloadingProgress
            // 
            this.DownloadingProgress.Location = new System.Drawing.Point(12, 30);
            this.DownloadingProgress.Name = "DownloadingProgress";
            this.DownloadingProgress.Size = new System.Drawing.Size(310, 22);
            this.DownloadingProgress.TabIndex = 0;
            // 
            // DownloadingLabel
            // 
            this.DownloadingLabel.AutoSize = true;
            this.DownloadingLabel.Location = new System.Drawing.Point(12, 9);
            this.DownloadingLabel.Name = "DownloadingLabel";
            this.DownloadingLabel.Size = new System.Drawing.Size(140, 13);
            this.DownloadingLabel.TabIndex = 1;
            this.DownloadingLabel.Text = "Downloading Windows 10...";
            // 
            // DownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 64);
            this.Controls.Add(this.DownloadingLabel);
            this.Controls.Add(this.DownloadingProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DownloadForm";
            this.Text = "DownloadForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DownloadForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar DownloadingProgress;
        private System.Windows.Forms.Label DownloadingLabel;
    }
}