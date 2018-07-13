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
            this.btnhapus = new System.Windows.Forms.Button();
            this.DgvKembali = new System.Windows.Forms.DataGridView();
            this.BtnBack = new System.Windows.Forms.Button();
            this.grpdetailkembali = new System.Windows.Forms.GroupBox();
            this.idpeminjaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idanggota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalpinjam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalkembali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvdetailkembali = new System.Windows.Forms.DataGridView();
            this.id_peminjaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_peminjam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_alat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textkembali = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvKembali)).BeginInit();
            this.grpdetailkembali.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetailkembali)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
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
            this.BtnCetak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCetak.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnCetak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCetak.FlatAppearance.BorderSize = 0;
            this.BtnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCetak.ForeColor = System.Drawing.Color.Black;
            this.BtnCetak.Image = ((System.Drawing.Image)(resources.GetObject("BtnCetak.Image")));
            this.BtnCetak.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCetak.Location = new System.Drawing.Point(219, 446);
            this.BtnCetak.Name = "BtnCetak";
            this.BtnCetak.Size = new System.Drawing.Size(86, 65);
            this.BtnCetak.TabIndex = 69;
            this.BtnCetak.Text = "Cetak [F7]";
            this.BtnCetak.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCetak.UseVisualStyleBackColor = false;
            this.BtnCetak.Click += new System.EventHandler(this.BtnCetak_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnRefresh.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.FlatAppearance.BorderSize = 0;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.ForeColor = System.Drawing.Color.Black;
            this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
            this.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRefresh.Location = new System.Drawing.Point(12, 446);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(97, 65);
            this.BtnRefresh.TabIndex = 70;
            this.BtnRefresh.Text = "Refresh [F5]";
            this.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // labeljumlah
            // 
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
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.CmbCariPeminjam.BackColor = System.Drawing.Color.DimGray;
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
            this.TxtCariDtKembali.BackColor = System.Drawing.Color.DimGray;
            this.TxtCariDtKembali.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCariDtKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCariDtKembali.ForeColor = System.Drawing.Color.White;
            this.TxtCariDtKembali.Location = new System.Drawing.Point(17, 3);
            this.TxtCariDtKembali.Name = "TxtCariDtKembali";
            this.TxtCariDtKembali.Size = new System.Drawing.Size(172, 28);
            this.TxtCariDtKembali.TabIndex = 1;
            // 
            // btnhapus
            // 
            this.btnhapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnhapus.BackColor = System.Drawing.Color.SkyBlue;
            this.btnhapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhapus.FlatAppearance.BorderSize = 0;
            this.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhapus.ForeColor = System.Drawing.Color.Black;
            this.btnhapus.Image = ((System.Drawing.Image)(resources.GetObject("btnhapus.Image")));
            this.btnhapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnhapus.Location = new System.Drawing.Point(119, 446);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(93, 65);
            this.btnhapus.TabIndex = 74;
            this.btnhapus.Text = "Hapus [F8]";
            this.btnhapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnhapus.UseVisualStyleBackColor = false;
            // 
            // DgvKembali
            // 
            this.DgvKembali.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvKembali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvKembali.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpeminjaman,
            this.idanggota,
            this.nama,
            this.Jumlah,
            this.tanggalpinjam,
            this.tanggalkembali});
            this.DgvKembali.Location = new System.Drawing.Point(-2, 117);
            this.DgvKembali.Name = "DgvKembali";
            this.DgvKembali.Size = new System.Drawing.Size(805, 316);
            this.DgvKembali.TabIndex = 75;
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBack.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.FlatAppearance.BorderSize = 0;
            this.BtnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(134)))), ((int)(((byte)(213)))));
            this.BtnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.Location = new System.Drawing.Point(726, 446);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(73, 65);
            this.BtnBack.TabIndex = 76;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBackAnggota_Click);
            // 
            // grpdetailkembali
            // 
            this.grpdetailkembali.Controls.Add(this.button1);
            this.grpdetailkembali.Controls.Add(this.textkembali);
            this.grpdetailkembali.Controls.Add(this.dgvdetailkembali);
            this.grpdetailkembali.Controls.Add(this.label1);
            this.grpdetailkembali.Location = new System.Drawing.Point(171, 159);
            this.grpdetailkembali.Name = "grpdetailkembali";
            this.grpdetailkembali.Size = new System.Drawing.Size(292, 186);
            this.grpdetailkembali.TabIndex = 77;
            this.grpdetailkembali.TabStop = false;
            // 
            // idpeminjaman
            // 
            this.idpeminjaman.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idpeminjaman.DataPropertyName = "id_peminjaman";
            this.idpeminjaman.HeaderText = "Id Peminjaman";
            this.idpeminjaman.Name = "idpeminjaman";
            this.idpeminjaman.ReadOnly = true;
            // 
            // idanggota
            // 
            this.idanggota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idanggota.DataPropertyName = "id_anggota";
            this.idanggota.HeaderText = "Id Anggota";
            this.idanggota.Name = "idanggota";
            this.idanggota.ReadOnly = true;
            // 
            // nama
            // 
            this.nama.DataPropertyName = "nama";
            this.nama.HeaderText = "Nama Anggota";
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            // 
            // Jumlah
            // 
            this.Jumlah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Jumlah.DataPropertyName = "jumlah";
            this.Jumlah.HeaderText = "Jumlah";
            this.Jumlah.Name = "Jumlah";
            this.Jumlah.ReadOnly = true;
            // 
            // tanggalpinjam
            // 
            this.tanggalpinjam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tanggalpinjam.DataPropertyName = "tanggal_pinjam";
            this.tanggalpinjam.HeaderText = "Tanggal Peminjaman";
            this.tanggalpinjam.Name = "tanggalpinjam";
            this.tanggalpinjam.ReadOnly = true;
            // 
            // tanggalkembali
            // 
            this.tanggalkembali.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tanggalkembali.DataPropertyName = "tanggal_kembali";
            this.tanggalkembali.HeaderText = "Tanggal Kembali";
            this.tanggalkembali.Name = "tanggalkembali";
            this.tanggalkembali.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detail Kembali";
            // 
            // dgvdetailkembali
            // 
            this.dgvdetailkembali.AllowUserToAddRows = false;
            this.dgvdetailkembali.AllowUserToDeleteRows = false;
            this.dgvdetailkembali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetailkembali.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_peminjaman,
            this.id_peminjam,
            this.nama_alat});
            this.dgvdetailkembali.Location = new System.Drawing.Point(6, 61);
            this.dgvdetailkembali.Name = "dgvdetailkembali";
            this.dgvdetailkembali.ReadOnly = true;
            this.dgvdetailkembali.Size = new System.Drawing.Size(280, 121);
            this.dgvdetailkembali.TabIndex = 1;
            // 
            // id_peminjaman
            // 
            this.id_peminjaman.DataPropertyName = "id_peminjaman";
            this.id_peminjaman.HeaderText = "Id Peminjaman";
            this.id_peminjaman.Name = "id_peminjaman";
            this.id_peminjaman.ReadOnly = true;
            // 
            // id_peminjam
            // 
            this.id_peminjam.DataPropertyName = "id_peminjam";
            this.id_peminjam.HeaderText = "Id Peminjam";
            this.id_peminjam.Name = "id_peminjam";
            this.id_peminjam.ReadOnly = true;
            // 
            // nama_alat
            // 
            this.nama_alat.DataPropertyName = "nama_alat";
            this.nama_alat.HeaderText = "Nama Alat";
            this.nama_alat.Name = "nama_alat";
            this.nama_alat.ReadOnly = true;
            // 
            // textkembali
            // 
            this.textkembali.Location = new System.Drawing.Point(186, 35);
            this.textkembali.Name = "textkembali";
            this.textkembali.Size = new System.Drawing.Size(100, 20);
            this.textkembali.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Kembali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(806, 514);
            this.Controls.Add(this.grpdetailkembali);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.DgvKembali);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labeljumlah);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnCetak);
            this.Controls.Add(this.label2);
            this.Name = "Kembali";
            this.Text = "DataKembali";
            this.Load += new System.EventHandler(this.Kembali_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvKembali)).EndInit();
            this.grpdetailkembali.ResumeLayout(false);
            this.grpdetailkembali.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetailkembali)).EndInit();
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
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.DataGridView DgvKembali;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.GroupBox grpdetailkembali;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpeminjaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn idanggota;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalpinjam;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalkembali;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textkembali;
        private System.Windows.Forms.DataGridView dgvdetailkembali;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_peminjaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_peminjam;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_alat;
        private System.Windows.Forms.Label label1;
    }
}