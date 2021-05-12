namespace SiparisTakipPL
{
    partial class AnaForm
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
            this.btnYeniSiparis = new System.Windows.Forms.Button();
            this.btnSiparislerim = new System.Windows.Forms.Button();
            this.btnYuklemePlani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYeniSiparis
            // 
            this.btnYeniSiparis.Location = new System.Drawing.Point(56, 32);
            this.btnYeniSiparis.Name = "btnYeniSiparis";
            this.btnYeniSiparis.Size = new System.Drawing.Size(109, 41);
            this.btnYeniSiparis.TabIndex = 0;
            this.btnYeniSiparis.Text = "SİPARİŞ EKLE";
            this.btnYeniSiparis.UseVisualStyleBackColor = true;
            this.btnYeniSiparis.Click += new System.EventHandler(this.btnYeniSiparis_Click);
            // 
            // btnSiparislerim
            // 
            this.btnSiparislerim.Location = new System.Drawing.Point(204, 32);
            this.btnSiparislerim.Name = "btnSiparislerim";
            this.btnSiparislerim.Size = new System.Drawing.Size(109, 41);
            this.btnSiparislerim.TabIndex = 1;
            this.btnSiparislerim.Text = "SİPARİŞLERİM";
            this.btnSiparislerim.UseVisualStyleBackColor = true;
            this.btnSiparislerim.Click += new System.EventHandler(this.btnSiparislerim_Click);
            // 
            // btnYuklemePlani
            // 
            this.btnYuklemePlani.Location = new System.Drawing.Point(351, 32);
            this.btnYuklemePlani.Name = "btnYuklemePlani";
            this.btnYuklemePlani.Size = new System.Drawing.Size(109, 41);
            this.btnYuklemePlani.TabIndex = 2;
            this.btnYuklemePlani.Text = "YÜKLEME PLANI";
            this.btnYuklemePlani.UseVisualStyleBackColor = true;
            this.btnYuklemePlani.Click += new System.EventHandler(this.btnYuklemePlani_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 539);
            this.Controls.Add(this.btnYuklemePlani);
            this.Controls.Add(this.btnSiparislerim);
            this.Controls.Add(this.btnYeniSiparis);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYeniSiparis;
        private System.Windows.Forms.Button btnSiparislerim;
        private System.Windows.Forms.Button btnYuklemePlani;
    }
}