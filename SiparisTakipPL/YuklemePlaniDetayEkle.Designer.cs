namespace SiparisTakipPL
{
    partial class YuklemePlaniDetayEkle
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.numAdet = new System.Windows.Forms.NumericUpDown();
            this.dgvYuklemePlani = new System.Windows.Forms.DataGridView();
            this.dgvSiparisDetaylari = new System.Windows.Forms.DataGridView();
            this.dgvSiparisler = new System.Windows.Forms.DataGridView();
            this.lblYuklemePlaniId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSevkArac = new System.Windows.Forms.Label();
            this.lblSevkAdres = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblYuklemePlaniAd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYuklemePlani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkle.Location = new System.Drawing.Point(1186, 289);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 34;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // numAdet
            // 
            this.numAdet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numAdet.Location = new System.Drawing.Point(1048, 292);
            this.numAdet.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numAdet.Name = "numAdet";
            this.numAdet.Size = new System.Drawing.Size(120, 20);
            this.numAdet.TabIndex = 33;
            // 
            // dgvYuklemePlani
            // 
            this.dgvYuklemePlani.AllowUserToAddRows = false;
            this.dgvYuklemePlani.AllowUserToDeleteRows = false;
            this.dgvYuklemePlani.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvYuklemePlani.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYuklemePlani.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvYuklemePlani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYuklemePlani.Location = new System.Drawing.Point(354, 355);
            this.dgvYuklemePlani.Name = "dgvYuklemePlani";
            this.dgvYuklemePlani.ReadOnly = true;
            this.dgvYuklemePlani.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYuklemePlani.Size = new System.Drawing.Size(907, 280);
            this.dgvYuklemePlani.TabIndex = 32;
            // 
            // dgvSiparisDetaylari
            // 
            this.dgvSiparisDetaylari.AllowUserToAddRows = false;
            this.dgvSiparisDetaylari.AllowUserToDeleteRows = false;
            this.dgvSiparisDetaylari.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSiparisDetaylari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisDetaylari.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSiparisDetaylari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisDetaylari.Location = new System.Drawing.Point(354, 24);
            this.dgvSiparisDetaylari.Name = "dgvSiparisDetaylari";
            this.dgvSiparisDetaylari.ReadOnly = true;
            this.dgvSiparisDetaylari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparisDetaylari.Size = new System.Drawing.Size(907, 256);
            this.dgvSiparisDetaylari.TabIndex = 31;
            this.dgvSiparisDetaylari.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSiparisDetaylari_CellClick_1);
            // 
            // dgvSiparisler
            // 
            this.dgvSiparisler.AllowUserToAddRows = false;
            this.dgvSiparisler.AllowUserToDeleteRows = false;
            this.dgvSiparisler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisler.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisler.Location = new System.Drawing.Point(12, 23);
            this.dgvSiparisler.Name = "dgvSiparisler";
            this.dgvSiparisler.ReadOnly = true;
            this.dgvSiparisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparisler.Size = new System.Drawing.Size(323, 612);
            this.dgvSiparisler.TabIndex = 30;
            this.dgvSiparisler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSiparisler_CellClick_1);
            // 
            // lblYuklemePlaniId
            // 
            this.lblYuklemePlaniId.AutoSize = true;
            this.lblYuklemePlaniId.Location = new System.Drawing.Point(510, 294);
            this.lblYuklemePlaniId.Name = "lblYuklemePlaniId";
            this.lblYuklemePlaniId.Size = new System.Drawing.Size(35, 13);
            this.lblYuklemePlaniId.TabIndex = 35;
            this.lblYuklemePlaniId.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "YÜKLEME PLANI ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 647);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "SEVK ARAC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 680);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "ADRES";
            // 
            // lblSevkArac
            // 
            this.lblSevkArac.AutoSize = true;
            this.lblSevkArac.Location = new System.Drawing.Point(510, 647);
            this.lblSevkArac.Name = "lblSevkArac";
            this.lblSevkArac.Size = new System.Drawing.Size(106, 13);
            this.lblSevkArac.TabIndex = 39;
            this.lblSevkArac.Text = "YÜKLEME PLANI ID";
            // 
            // lblSevkAdres
            // 
            this.lblSevkAdres.AutoSize = true;
            this.lblSevkAdres.Location = new System.Drawing.Point(510, 680);
            this.lblSevkAdres.Name = "lblSevkAdres";
            this.lblSevkAdres.Size = new System.Drawing.Size(106, 13);
            this.lblSevkAdres.TabIndex = 40;
            this.lblSevkAdres.Text = "YÜKLEME PLANI ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "YÜKLEME PLANI AD";
            // 
            // lblYuklemePlaniAd
            // 
            this.lblYuklemePlaniAd.AutoSize = true;
            this.lblYuklemePlaniAd.Location = new System.Drawing.Point(510, 318);
            this.lblYuklemePlaniAd.Name = "lblYuklemePlaniAd";
            this.lblYuklemePlaniAd.Size = new System.Drawing.Size(35, 13);
            this.lblYuklemePlaniAd.TabIndex = 41;
            this.lblYuklemePlaniAd.Text = "label1";
            // 
            // YuklemePlaniDetayEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 726);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblYuklemePlaniAd);
            this.Controls.Add(this.lblSevkAdres);
            this.Controls.Add(this.lblSevkArac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblYuklemePlaniId);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.numAdet);
            this.Controls.Add(this.dgvYuklemePlani);
            this.Controls.Add(this.dgvSiparisDetaylari);
            this.Controls.Add(this.dgvSiparisler);
            this.Name = "YuklemePlaniDetayEkle";
            this.Text = "YuklemePlaniDetayEkle";
            this.Load += new System.EventHandler(this.YuklemePlaniDetayEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYuklemePlani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.NumericUpDown numAdet;
        private System.Windows.Forms.DataGridView dgvYuklemePlani;
        private System.Windows.Forms.DataGridView dgvSiparisDetaylari;
        private System.Windows.Forms.DataGridView dgvSiparisler;
        private System.Windows.Forms.Label lblYuklemePlaniId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSevkArac;
        private System.Windows.Forms.Label lblSevkAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblYuklemePlaniAd;
    }
}