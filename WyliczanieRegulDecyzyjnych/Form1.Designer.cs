namespace WyliczanieRegulDecyzyjnych
{
    partial class Form1
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
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.tbSciezka = new System.Windows.Forms.TextBox();
            this.ofdPlik = new System.Windows.Forms.OpenFileDialog();
            this.btnSequentialCovering = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSzukaj.Location = new System.Drawing.Point(671, 12);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(25, 23);
            this.btnSzukaj.TabIndex = 0;
            this.btnSzukaj.Text = "...";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // tbSciezka
            // 
            this.tbSciezka.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSciezka.Location = new System.Drawing.Point(12, 12);
            this.tbSciezka.Name = "tbSciezka";
            this.tbSciezka.ReadOnly = true;
            this.tbSciezka.Size = new System.Drawing.Size(653, 20);
            this.tbSciezka.TabIndex = 1;
            // 
            // ofdPlik
            // 
            this.ofdPlik.FileName = "openFileDialog1";
            // 
            // btnSequentialCovering
            // 
            this.btnSequentialCovering.Location = new System.Drawing.Point(12, 64);
            this.btnSequentialCovering.Name = "btnSequentialCovering";
            this.btnSequentialCovering.Size = new System.Drawing.Size(109, 38);
            this.btnSequentialCovering.TabIndex = 2;
            this.btnSequentialCovering.Text = "Covering";
            this.btnSequentialCovering.UseVisualStyleBackColor = true;
            this.btnSequentialCovering.Click += new System.EventHandler(this.btnSequentialCovering_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 285);
            this.Controls.Add(this.btnSequentialCovering);
            this.Controls.Add(this.tbSciezka);
            this.Controls.Add(this.btnSzukaj);
            this.Name = "Form1";
            this.Text = "Wyliczanie Regul Decyzyjnych";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.TextBox tbSciezka;
        private System.Windows.Forms.OpenFileDialog ofdPlik;
        private System.Windows.Forms.Button btnSequentialCovering;
    }
}

