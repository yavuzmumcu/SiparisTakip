namespace SiparisTakipPL
{
    partial class Siparislerim
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
            this.dgvSiparisler = new System.Windows.Forms.DataGridView();
            this.dgvSiparisDetaylari = new System.Windows.Forms.DataGridView();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSiparisDetaySil = new System.Windows.Forms.Button();
            this.btnSipariseEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylari)).BeginInit();
            this.SuspendLayout();
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
            this.dgvSiparisler.Location = new System.Drawing.Point(12, 12);
            this.dgvSiparisler.Name = "dgvSiparisler";
            this.dgvSiparisler.ReadOnly = true;
            this.dgvSiparisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparisler.Size = new System.Drawing.Size(323, 513);
            this.dgvSiparisler.TabIndex = 23;
            this.dgvSiparisler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSiparisler_CellClick);
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
            this.dgvSiparisDetaylari.Location = new System.Drawing.Point(354, 12);
            this.dgvSiparisDetaylari.Name = "dgvSiparisDetaylari";
            this.dgvSiparisDetaylari.ReadOnly = true;
            this.dgvSiparisDetaylari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparisDetaylari.Size = new System.Drawing.Size(814, 434);
            this.dgvSiparisDetaylari.TabIndex = 24;
            this.dgvSiparisDetaylari.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSiparisDetaylari_CellClick);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuzenle.Location = new System.Drawing.Point(1093, 452);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnDuzenle.TabIndex = 25;
            this.btnDuzenle.Text = "DÜZENLE";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSiparisDetaySil
            // 
            this.btnSiparisDetaySil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiparisDetaySil.Location = new System.Drawing.Point(1012, 452);
            this.btnSiparisDetaySil.Name = "btnSiparisDetaySil";
            this.btnSiparisDetaySil.Size = new System.Drawing.Size(75, 23);
            this.btnSiparisDetaySil.TabIndex = 26;
            this.btnSiparisDetaySil.Text = "SİL";
            this.btnSiparisDetaySil.UseVisualStyleBackColor = true;
            this.btnSiparisDetaySil.Click += new System.EventHandler(this.btnSiparisDetaySil_Click);
            // 
            // btnSipariseEkle
            // 
            this.btnSipariseEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSipariseEkle.Location = new System.Drawing.Point(260, 531);
            this.btnSipariseEkle.Name = "btnSipariseEkle";
            this.btnSipariseEkle.Size = new System.Drawing.Size(75, 23);
            this.btnSipariseEkle.TabIndex = 27;
            this.btnSipariseEkle.Text = "EKLE";
            this.btnSipariseEkle.UseVisualStyleBackColor = true;
            this.btnSipariseEkle.Click += new System.EventHandler(this.btnSipariseEkle_Click);
            // 
            // Siparislerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 561);
            this.Controls.Add(this.btnSipariseEkle);
            this.Controls.Add(this.btnSiparisDetaySil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.dgvSiparisDetaylari);
            this.Controls.Add(this.dgvSiparisler);
            this.Name = "Siparislerim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparislerim";
            this.Load += new System.EventHandler(this.Siparislerim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSiparisler;
        private System.Windows.Forms.DataGridView dgvSiparisDetaylari;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSiparisDetaySil;
        private System.Windows.Forms.Button btnSipariseEkle;
    }
}