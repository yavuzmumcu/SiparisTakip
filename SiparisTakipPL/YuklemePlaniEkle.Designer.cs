namespace SiparisTakipPL
{
    partial class YuklemePlaniEkle
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
            this.txtYuklemePlaniAd = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSevk = new System.Windows.Forms.Panel();
            this.txtSevkAdres = new System.Windows.Forms.TextBox();
            this.cmbSevkArac = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelSevk.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtYuklemePlaniAd
            // 
            this.txtYuklemePlaniAd.Location = new System.Drawing.Point(168, 33);
            this.txtYuklemePlaniAd.Name = "txtYuklemePlaniAd";
            this.txtYuklemePlaniAd.Size = new System.Drawing.Size(282, 20);
            this.txtYuklemePlaniAd.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(379, 212);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "YÜKLEME PLANI ADI";
            // 
            // panelSevk
            // 
            this.panelSevk.BackColor = System.Drawing.Color.Khaki;
            this.panelSevk.Controls.Add(this.txtSevkAdres);
            this.panelSevk.Controls.Add(this.cmbSevkArac);
            this.panelSevk.Controls.Add(this.label11);
            this.panelSevk.Controls.Add(this.label10);
            this.panelSevk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelSevk.Location = new System.Drawing.Point(10, 69);
            this.panelSevk.Name = "panelSevk";
            this.panelSevk.Size = new System.Drawing.Size(444, 138);
            this.panelSevk.TabIndex = 8;
            // 
            // txtSevkAdres
            // 
            this.txtSevkAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSevkAdres.Location = new System.Drawing.Point(142, 59);
            this.txtSevkAdres.Multiline = true;
            this.txtSevkAdres.Name = "txtSevkAdres";
            this.txtSevkAdres.Size = new System.Drawing.Size(287, 60);
            this.txtSevkAdres.TabIndex = 11;
            // 
            // cmbSevkArac
            // 
            this.cmbSevkArac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSevkArac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSevkArac.FormattingEnabled = true;
            this.cmbSevkArac.Location = new System.Drawing.Point(142, 25);
            this.cmbSevkArac.Name = "cmbSevkArac";
            this.cmbSevkArac.Size = new System.Drawing.Size(121, 21);
            this.cmbSevkArac.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(21, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "SEVK ADRES";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(21, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "SEVK ARACI";
            // 
            // YuklemePlaniEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 247);
            this.Controls.Add(this.panelSevk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtYuklemePlaniAd);
            this.Name = "YuklemePlaniEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YuklemePlaniEkle";
            this.Load += new System.EventHandler(this.YuklemePlaniEkle_Load);
            this.panelSevk.ResumeLayout(false);
            this.panelSevk.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYuklemePlaniAd;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSevk;
        private System.Windows.Forms.TextBox txtSevkAdres;
        private System.Windows.Forms.ComboBox cmbSevkArac;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}