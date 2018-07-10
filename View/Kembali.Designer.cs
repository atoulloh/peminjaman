namespace peminjaman.View
{
    partial class Kembali
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kembali));
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCetak = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.labeljumlah = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CmbCariPeminjam = new System.Windows.Forms.ComboBox();
            this.TxtCariDtKembali = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnBackAnggota = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 34);
            this.label2.TabIndex = 59;
            this.label2.Text = "DATA KEMBALI ALAT";
            // 
            // BtnCetak
            // 
            this.BtnCetak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCetak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(134)))), ((int)(((byte)(213)))));
            this.BtnCetak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCetak.FlatAppearance.BorderSize = 0;
            this.BtnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCetak.ForeColor = System.Drawing.Color.White;
            this.BtnCetak.Image = ((System.Drawing.Image)(resources.GetObject("BtnCetak.Image")));
            this.BtnCetak.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCetak.Location = new System.Drawing.Point(256, 439);
            this.BtnCetak.Name = "BtnCetak";
            this.BtnCetak.Size = new System.Drawing.Size(116, 72);
            this.BtnCetak.TabIndex = 69;
            this.BtnCetak.Text = "Cetak [F7]";
            this.BtnCetak.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCetak.UseVisualStyleBackColor = false;
            this.BtnCetak.Click += new System.EventHandler(this.BtnCetak_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(134)))), ((int)(((byte)(213)))));
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.FlatAppearance.BorderSize = 0;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.ForeColor = System.Drawing.Color.White;
            this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
            this.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRefresh.Location = new System.Drawing.Point(12, 439);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(116, 72);
            this.BtnRefresh.TabIndex = 70;
            this.BtnRefresh.Text = "Refresh [F5]";
            this.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            // 
            // labeljumlah
            // 
            this.labeljumlah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labeljumlah.AutoSize = true;
            this.labeljumlah.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeljumlah.ForeColor = System.Drawing.Color.Black;
            this.labeljumlah.Location = new System.Drawing.Point(9, 99);
            this.labeljumlah.Name = "labeljumlah";
            this.labeljumlah.Size = new System.Drawing.Size(83, 15);
            this.labeljumlah.TabIndex = 71;
            this.labeljumlah.Text = "Jumlah Data :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.CmbCariPeminjam);
            this.panel1.Controls.Add(this.TxtCariDtKembali);
            this.panel1.Location = new System.Drawing.Point(432, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 34);
            this.panel1.TabIndex = 73;
            // 
            // CmbCariPeminjam
            // 
            this.CmbCariPeminjam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmbCariPeminjam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(134)))), ((int)(((byte)(213)))));
            this.CmbCariPeminjam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbCariPeminjam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCariPeminjam.ForeColor = System.Drawing.Color.White;
            this.CmbCariPeminjam.FormattingEnabled = true;
            this.CmbCariPeminjam.Items.AddRange(new object[] {
            "Kode Pinjam",
            "Tanggal Pinjam",
            "Denda"});
            this.CmbCariPeminjam.Location = new System.Drawing.Point(195, 3);
            this.CmbCariPeminjam.Name = "CmbCariPeminjam";
            this.CmbCariPeminjam.Size = new System.Drawing.Size(172, 28);
            this.CmbCariPeminjam.TabIndex = 71;
            this.CmbCariPeminjam.Text = "---Cari Data---";
            // 
            // TxtCariDtKembali
            // 
            this.TxtCariDtKembali.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtCariDtKembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(134)))), ((int)(((byte)(213)))));
            this.TxtCariDtKembali.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCariDtKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCariDtKembali.ForeColor = System.Drawing.Color.White;
            this.TxtCariDtKembali.Location = new System.Drawing.Point(17, 3);
            this.TxtCariDtKembali.Name = "TxtCariDtKembali";
            this.TxtCariDtKembali.Size = new System.Drawing.Size(172, 28);
            this.TxtCariDtKembali.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(134)))), ((int)(((byte)(213)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(134, 439);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 72);
            this.button3.TabIndex = 74;
            this.button3.Text = "Hapus [F8]";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(805, 316);
            this.dataGridView1.TabIndex = 75;
            // 
            // BtnBackAnggota
            // 
            this.BtnBackAnggota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(134)))), ((int)(((byte)(213)))));
            this.BtnBackAnggota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBackAnggota.FlatAppearance.BorderSize = 0;
            this.BtnBackAnggota.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(134)))), ((int)(((byte)(213)))));
            this.BtnBackAnggota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnBackAnggota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackAnggota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackAnggota.ForeColor = System.Drawing.Color.White;
            this.BtnBackAnggota.Image = ((System.Drawing.Image)(resources.GetObject("BtnBackAnggota.Image")));
            this.BtnBackAnggota.Location = new System.Drawing.Point(726, 446);
            this.BtnBackAnggota.Name = "BtnBackAnggota";
            this.BtnBackAnggota.Size = new System.Drawing.Size(73, 65);
            this.BtnBackAnggota.TabIndex = 76;
            this.BtnBackAnggota.UseVisualStyleBackColor = false;
            // 
            // Kembali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 514);
            this.Controls.Add(this.BtnBackAnggota);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labeljumlah);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnCetak);
            this.Controls.Add(this.label2);
            this.Name = "Kembali";
            this.Text = "DataKembali";
            this.Load += new System.EventHandler(this.Kembali_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCetak;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Label labeljumlah;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CmbCariPeminjam;
        private System.Windows.Forms.TextBox TxtCariDtKembali;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnBackAnggota;
    }
}