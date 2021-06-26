
namespace Ahla
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartDLBtn = new System.Windows.Forms.Button();
            this.PatchStartBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartDLBtn
            // 
            this.StartDLBtn.Location = new System.Drawing.Point(13, 12);
            this.StartDLBtn.Name = "StartDLBtn";
            this.StartDLBtn.Size = new System.Drawing.Size(287, 96);
            this.StartDLBtn.TabIndex = 0;
            this.StartDLBtn.Text = "Download Windows 10";
            this.StartDLBtn.UseVisualStyleBackColor = true;
            this.StartDLBtn.Click += new System.EventHandler(this.StartDLBtn_Click);
            // 
            // PatchStartBtn
            // 
            this.PatchStartBtn.Location = new System.Drawing.Point(13, 114);
            this.PatchStartBtn.Name = "PatchStartBtn";
            this.PatchStartBtn.Size = new System.Drawing.Size(287, 96);
            this.PatchStartBtn.TabIndex = 1;
            this.PatchStartBtn.Text = "Patch Windows 11";
            this.PatchStartBtn.UseVisualStyleBackColor = true;
            this.PatchStartBtn.Click += new System.EventHandler(this.PatchStartBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 222);
            this.Controls.Add(this.PatchStartBtn);
            this.Controls.Add(this.StartDLBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Ahla";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartDLBtn;
        private System.Windows.Forms.Button PatchStartBtn;
    }
}

