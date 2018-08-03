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
            this.TxtCariDtKembali = new System.Windows.Forms.TextBox();
            this.DgvKembali = new System.Windows.Forms.DataGridView();
            this.idpeminjaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idanggota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalpinjam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalkembali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpdetailkembali = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textkembali = new System.Windows.Forms.TextBox();
            this.dgvdetailkembali = new System.Windows.Forms.DataGridView();
            this.id_peminjaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_peminjam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_alat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btncari = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelPengembali = new System.Windows.Forms.Label();
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 37);
            this.label2.TabIndex = 59;
            this.label2.Text = "DATA KEMBALI ALAT";
            // 
            // BtnCetak
            // 
            this.BtnCetak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCetak.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnCetak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCetak.FlatAppearance.BorderSize = 0;
            this.BtnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCetak.ForeColor = System.Drawing.Color.Black;
            this.BtnCetak.Image = ((System.Drawing.Image)(resources.GetObject("BtnCetak.Image")));
            this.BtnCetak.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCetak.Location = new System.Drawing.Point(768, 368);
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
            this.BtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefresh.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.FlatAppearance.BorderSize = 0;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.ForeColor = System.Drawing.Color.Black;
            this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
            this.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRefresh.Location = new System.Drawing.Point(665, 368);
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
            this.labeljumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeljumlah.ForeColor = System.Drawing.Color.Black;
            this.labeljumlah.Location = new System.Drawing.Point(9, 99);
            this.labeljumlah.Name = "labeljumlah";
            this.labeljumlah.Size = new System.Drawing.Size(89, 16);
            this.labeljumlah.TabIndex = 71;
            this.labeljumlah.Text = "Jumlah Data :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtCariDtKembali);
            this.panel1.Location = new System.Drawing.Point(488, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 34);
            this.panel1.TabIndex = 73;
            // 
            // TxtCariDtKembali
            // 
            this.TxtCariDtKembali.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtCariDtKembali.BackColor = System.Drawing.Color.DimGray;
            this.TxtCariDtKembali.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCariDtKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCariDtKembali.ForeColor = System.Drawing.Color.White;
            this.TxtCariDtKembali.Location = new System.Drawing.Point(194, 0);
            this.TxtCariDtKembali.Name = "TxtCariDtKembali";
            this.TxtCariDtKembali.Size = new System.Drawing.Size(172, 28);
            this.TxtCariDtKembali.TabIndex = 1;
            this.TxtCariDtKembali.TextChanged += new System.EventHandler(this.TxtCariDtKembali_TextChanged);
            // 
            // DgvKembali
            // 
            this.DgvKembali.AllowUserToAddRows = false;
            this.DgvKembali.AllowUserToDeleteRows = false;
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
            this.DgvKembali.Location = new System.Drawing.Point(12, 89);
            this.DgvKembali.Name = "DgvKembali";
            this.DgvKembali.ReadOnly = true;
            this.DgvKembali.Size = new System.Drawing.Size(847, 266);
            this.DgvKembali.TabIndex = 75;
            this.DgvKembali.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvKembali_CellDoubleClick);
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
            // grpdetailkembali
            // 
            this.grpdetailkembali.Controls.Add(this.button1);
            this.grpdetailkembali.Controls.Add(this.textkembali);
            this.grpdetailkembali.Controls.Add(this.dgvdetailkembali);
            this.grpdetailkembali.Controls.Add(this.label1);
            this.grpdetailkembali.Location = new System.Drawing.Point(6, 99);
            this.grpdetailkembali.Name = "grpdetailkembali";
            this.grpdetailkembali.Size = new System.Drawing.Size(574, 243);
            this.grpdetailkembali.TabIndex = 77;
            this.grpdetailkembali.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textkembali
            // 
            this.textkembali.Location = new System.Drawing.Point(461, 35);
            this.textkembali.Name = "textkembali";
            this.textkembali.Size = new System.Drawing.Size(100, 20);
            this.textkembali.TabIndex = 2;
            this.textkembali.TextChanged += new System.EventHandler(this.textkembali_TextChanged);
            // 
            // dgvdetailkembali
            // 
            this.dgvdetailkembali.AllowUserToAddRows = false;
            this.dgvdetailkembali.AllowUserToDeleteRows = false;
            this.dgvdetailkembali.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdetailkembali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetailkembali.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_peminjaman,
            this.id_peminjam,
            this.nama_alat,
            this.letak,
            this.Status});
            this.dgvdetailkembali.Location = new System.Drawing.Point(15, 61);
            this.dgvdetailkembali.Name = "dgvdetailkembali";
            this.dgvdetailkembali.Size = new System.Drawing.Size(546, 168);
            this.dgvdetailkembali.TabIndex = 1;
            // 
            // id_peminjaman
            // 
            this.id_peminjaman.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_peminjaman.DataPropertyName = "id_peminjaman";
            this.id_peminjaman.HeaderText = "Id Peminjaman";
            this.id_peminjaman.Name = "id_peminjaman";
            // 
            // id_peminjam
            // 
            this.id_peminjam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_peminjam.DataPropertyName = "id_pinjaman";
            this.id_peminjam.HeaderText = "Id Pinjaman";
            this.id_peminjam.Name = "id_peminjam";
            // 
            // nama_alat
            // 
            this.nama_alat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama_alat.DataPropertyName = "nama_alat";
            this.nama_alat.HeaderText = "Nama Alat";
            this.nama_alat.Name = "nama_alat";
            // 
            // letak
            // 
            this.letak.DataPropertyName = "letak";
            this.letak.HeaderText = "Letak";
            this.letak.Name = "letak";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "status";
            this.Status.HeaderText = "Status Alat";
            this.Status.Name = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detail Kembali";
            // 
            // btncari
            // 
            this.btncari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncari.Location = new System.Drawing.Point(574, 52);
            this.btncari.Name = "btncari";
            this.btncari.Size = new System.Drawing.Size(75, 23);
            this.btncari.TabIndex = 78;
            this.btncari.Text = "button2";
            this.btncari.UseVisualStyleBackColor = true;
            this.btncari.Click += new System.EventHandler(this.btncari_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cari Pengembali";
            // 
            // LabelPengembali
            // 
            this.LabelPengembali.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelPengembali.AutoSize = true;
            this.LabelPengembali.Location = new System.Drawing.Point(18, 368);
            this.LabelPengembali.Name = "LabelPengembali";
            this.LabelPengembali.Size = new System.Drawing.Size(104, 13);
            this.LabelPengembali.TabIndex = 79;
            this.LabelPengembali.Text = "Jumlah Pengembali :";
            // 
            // Kembali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(866, 436);
            this.Controls.Add(this.LabelPengembali);
            this.Controls.Add(this.grpdetailkembali);
            this.Controls.Add(this.DgvKembali);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labeljumlah);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnCetak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncari);
            this.Name = "Kembali";
            this.Text = "DataKembali";
            this.Load += new System.EventHandler(this.Kembali_Load);
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
        private System.Windows.Forms.TextBox TxtCariDtKembali;
        private System.Windows.Forms.DataGridView DgvKembali;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_peminjaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_peminjam;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_alat;
        private System.Windows.Forms.DataGridViewTextBoxColumn letak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button btncari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelPengembali;
    }
}