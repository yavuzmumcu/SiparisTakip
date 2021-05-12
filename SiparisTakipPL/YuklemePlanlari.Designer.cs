namespace SiparisTakipPL
{
    partial class YuklemePlanlari
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
            this.dgvYuklemePlanlari = new System.Windows.Forms.DataGridView();
            this.btnPlanOlustur = new System.Windows.Forms.Button();
            this.dgvYuklemePlaniDetaylari = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYuklemePlanlari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYuklemePlaniDetaylari)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvYuklemePlanlari
            // 
            this.dgvYuklemePlanlari.AllowUserToAddRows = false;
            this.dgvYuklemePlanlari.AllowUserToDeleteRows = false;
            this.dgvYuklemePlanlari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYuklemePlanlari.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvYuklemePlanlari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYuklemePlanlari.Location = new System.Drawing.Point(12, 12);
            this.dgvYuklemePlanlari.Name = "dgvYuklemePlanlari";
            this.dgvYuklemePlanlari.ReadOnly = true;
            this.dgvYuklemePlanlari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYuklemePlanlari.Size = new System.Drawing.Size(509, 300);
            this.dgvYuklemePlanlari.TabIndex = 23;
            this.dgvYuklemePlanlari.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYuklemePlanlari_CellClick);
            // 
            // btnPlanOlustur
            // 
            this.btnPlanOlustur.Location = new System.Drawing.Point(527, 12);
            this.btnPlanOlustur.Name = "btnPlanOlustur";
            this.btnPlanOlustur.Size = new System.Drawing.Size(75, 23);
            this.btnPlanOlustur.TabIndex = 24;
            this.btnPlanOlustur.Text = "YENİ PLAN";
            this.btnPlanOlustur.UseVisualStyleBackColor = true;
            this.btnPlanOlustur.Click += new System.EventHandler(this.btnPlanOlustur_Click);
            // 
            // dgvYuklemePlaniDetaylari
            // 
            this.dgvYuklemePlaniDetaylari.AllowUserToAddRows = false;
            this.dgvYuklemePlaniDetaylari.AllowUserToDeleteRows = false;
            this.dgvYuklemePlaniDetaylari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYuklemePlaniDetaylari.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvYuklemePlaniDetaylari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYuklemePlaniDetaylari.Location = new System.Drawing.Point(12, 331);
            this.dgvYuklemePlaniDetaylari.Name = "dgvYuklemePlaniDetaylari";
            this.dgvYuklemePlaniDetaylari.ReadOnly = true;
            this.dgvYuklemePlaniDetaylari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYuklemePlaniDetaylari.Size = new System.Drawing.Size(1011, 305);
            this.dgvYuklemePlaniDetaylari.TabIndex = 25;
            // 
            // YuklemePlanlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 648);
            this.Controls.Add(this.dgvYuklemePlaniDetaylari);
            this.Controls.Add(this.btnPlanOlustur);
            this.Controls.Add(this.dgvYuklemePlanlari);
            this.Name = "YuklemePlanlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YuklemePlanlari";
            this.Load += new System.EventHandler(this.YuklemePlanlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYuklemePlanlari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYuklemePlaniDetaylari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvYuklemePlanlari;
        private System.Windows.Forms.Button btnPlanOlustur;
        private System.Windows.Forms.DataGridView dgvYuklemePlaniDetaylari;
    }
}