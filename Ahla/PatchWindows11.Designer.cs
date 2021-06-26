
namespace Ahla
{
    partial class PatchWindows11
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
            this.InstallWimTextBox = new System.Windows.Forms.TextBox();
            this.WimSelectOkButton = new System.Windows.Forms.Button();
            this.WimSelectLabel = new System.Windows.Forms.Label();
            this.SelectWIMButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InstallWimTextBox
            // 
            this.InstallWimTextBox.Location = new System.Drawing.Point(15, 34);
            this.InstallWimTextBox.Name = "InstallWimTextBox";
            this.InstallWimTextBox.Size = new System.Drawing.Size(236, 20);
            this.InstallWimTextBox.TabIndex = 0;
            // 
            // WimSelectOkButton
            // 
            this.WimSelectOkButton.Location = new System.Drawing.Point(13, 60);
            this.WimSelectOkButton.Name = "WimSelectOkButton";
            this.WimSelectOkButton.Size = new System.Drawing.Size(75, 23);
            this.WimSelectOkButton.TabIndex = 1;
            this.WimSelectOkButton.Text = "Ok";
            this.WimSelectOkButton.UseVisualStyleBackColor = true;
            this.WimSelectOkButton.Click += new System.EventHandler(this.WimSelectOkButton_Click);
            // 
            // WimSelectLabel
            // 
            this.WimSelectLabel.AutoSize = true;
            this.WimSelectLabel.Location = new System.Drawing.Point(12, 9);
            this.WimSelectLabel.Name = "WimSelectLabel";
            this.WimSelectLabel.Size = new System.Drawing.Size(231, 13);
            this.WimSelectLabel.TabIndex = 2;
            this.WimSelectLabel.Text = "Select a Windows 11 Install.WIM and click OK.";
            // 
            // SelectWIMButton
            // 
            this.SelectWIMButton.Location = new System.Drawing.Point(257, 33);
            this.SelectWIMButton.Name = "SelectWIMButton";
            this.SelectWIMButton.Size = new System.Drawing.Size(29, 23);
            this.SelectWIMButton.TabIndex = 3;
            this.SelectWIMButton.Text = ">";
            this.SelectWIMButton.UseVisualStyleBackColor = true;
            this.SelectWIMButton.Click += new System.EventHandler(this.SelectWIMButton_Click);
            // 
            // PatchWindows11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 95);
            this.Controls.Add(this.SelectWIMButton);
            this.Controls.Add(this.WimSelectLabel);
            this.Controls.Add(this.WimSelectOkButton);
            this.Controls.Add(this.InstallWimTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PatchWindows11";
            this.Text = "PatchWindows11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InstallWimTextBox;
        private System.Windows.Forms.Button WimSelectOkButton;
        private System.Windows.Forms.Label WimSelectLabel;
        private System.Windows.Forms.Button SelectWIMButton;
    }
}