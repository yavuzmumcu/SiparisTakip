namespace SiparisTakipPL
{
    partial class SiparisEkle
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
            this.panelSiparis = new System.Windows.Forms.Panel();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtSiparisAciklama = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.dtpSiparisTarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSiparis.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSiparis
            // 
            this.panelSiparis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelSiparis.Controls.Add(this.btnEkle);
            this.panelSiparis.Controls.Add(this.txtSiparisAciklama);
            this.panelSiparis.Controls.Add(this.label12);
            this.panelSiparis.Controls.Add(this.cmbMusteri);
            this.panelSiparis.Controls.Add(this.dtpSiparisTarih);
            this.panelSiparis.Controls.Add(this.label2);
            this.panelSiparis.Controls.Add(this.label1);
            this.panelSiparis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSiparis.Location = new System.Drawing.Point(0, 0);
            this.panelSiparis.Name = "panelSiparis";
            this.panelSiparis.Size = new System.Drawing.Size(454, 192);
            this.panelSiparis.TabIndex = 6;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(358, 157);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "OLUŞTUR";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtSiparisAciklama
            // 
            this.txtSiparisAciklama.Location = new System.Drawing.Point(153, 94);
            this.txtSiparisAciklama.Multiline = true;
            this.txtSiparisAciklama.Name = "txtSiparisAciklama";
            this.txtSiparisAciklama.Size = new System.Drawing.Size(280, 51);
            this.txtSiparisAciklama.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(12, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 15);
            this.label12.TabIndex = 9;
            this.label12.Text = "AÇIKLAMA";
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(153, 55);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(280, 21);
            this.cmbMusteri.TabIndex = 8;
            this.cmbMusteri.Leave += new System.EventHandler(this.cmbMusteri_Leave);
            // 
            // dtpSiparisTarih
            // 
            this.dtpSiparisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSiparisTarih.Location = new System.Drawing.Point(153, 20);
            this.dtpSiparisTarih.Name = "dtpSiparisTarih";
            this.dtpSiparisTarih.Size = new System.Drawing.Size(121, 20);
            this.dtpSiparisTarih.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "SİPARİŞ TARİHİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "MÜŞTERİ";
            // 
            // SiparisEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 192);
            this.Controls.Add(this.panelSiparis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SiparisEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiparisEkle";
            this.Load += new System.EventHandler(this.SiparisEkle_Load);
            this.panelSiparis.ResumeLayout(false);
            this.panelSiparis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSiparis;
        private System.Windows.Forms.TextBox txtSiparisAciklama;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.DateTimePicker dtpSiparisTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
    }
}