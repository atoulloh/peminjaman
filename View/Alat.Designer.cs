namespace peminjaman.View
{
    partial class Alat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alat));
            this.label2 = new System.Windows.Forms.Label();
            this.labeljumlaha = new System.Windows.Forms.Label();
            this.TxtCariAlat = new System.Windows.Forms.TextBox();
            this.BtnCari = new System.Windows.Forms.Button();
            this.dgvAlat = new System.Windows.Forms.DataGridView();
            this.kode_alat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_alat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenis_alat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_pembelian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahun_pembelian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kondisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnUbah = new System.Windows.Forms.Button();
            this.BtnTambah = new System.Windows.Forms.Button();
            this.BtnHapus = new System.Windows.Forms.Button();
            this.BtnCetakAL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAlat = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textjumlah = new System.Windows.Forms.TextBox();
            this.texttahun = new System.Windows.Forms.TextBox();
            this.textharga = new System.Windows.Forms.TextBox();
            this.textletak = new System.Windows.Forms.TextBox();
            this.textjenis = new System.Windows.Forms.TextBox();
            this.textnama = new System.Windows.Forms.TextBox();
            this.TxtKode = new System.Windows.Forms.TextBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpbuton = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlat)).BeginInit();
            this.grpAlat.SuspendLayout();
            this.grpbuton.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 37);
            this.label2.TabIndex = 57;
            this.label2.Text = "DATA ALAT";
            // 
            // labeljumlaha
            // 
            this.labeljumlaha.AutoSize = true;
            this.labeljumlaha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeljumlaha.ForeColor = System.Drawing.Color.Black;
            this.labeljumlaha.Location = new System.Drawing.Point(15, 68);
            this.labeljumlaha.Name = "labeljumlaha";
            this.labeljumlaha.Size = new System.Drawing.Size(83, 16);
            this.labeljumlaha.TabIndex = 63;
            this.labeljumlaha.Text = "Jumlah Alat :";
            this.labeljumlaha.Click += new System.EventHandler(this.labeljumlaha_Click);
            // 
            // TxtCariAlat
            // 
            this.TxtCariAlat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCariAlat.BackColor = System.Drawing.Color.LightSlateGray;
            this.TxtCariAlat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCariAlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCariAlat.ForeColor = System.Drawing.Color.White;
            this.TxtCariAlat.Location = new System.Drawing.Point(598, 50);
            this.TxtCariAlat.Name = "TxtCariAlat";
            this.TxtCariAlat.Size = new System.Drawing.Size(172, 28);
            this.TxtCariAlat.TabIndex = 1;
            this.TxtCariAlat.TextChanged += new System.EventHandler(this.TxtCariAlat_TextChanged_1);
            // 
            // BtnCari
            // 
            this.BtnCari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCari.Location = new System.Drawing.Point(669, 49);
            this.BtnCari.Name = "BtnCari";
            this.BtnCari.Size = new System.Drawing.Size(75, 23);
            this.BtnCari.TabIndex = 74;
            this.BtnCari.Text = "cari";
            this.BtnCari.UseVisualStyleBackColor = true;
            this.BtnCari.Click += new System.EventHandler(this.BtnCari_Click_1);
            // 
            // dgvAlat
            // 
            this.dgvAlat.AllowUserToAddRows = false;
            this.dgvAlat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAlat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kode_alat,
            this.nama_alat,
            this.jenis_alat,
            this.letak,
            this.harga_pembelian,
            this.tahun_pembelian,
            this.kondisi});
            this.dgvAlat.Location = new System.Drawing.Point(12, 86);
            this.dgvAlat.Name = "dgvAlat";
            this.dgvAlat.Size = new System.Drawing.Size(758, 233);
            this.dgvAlat.TabIndex = 67;
            this.dgvAlat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlat_CellContentClick);
            this.dgvAlat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlat_CellDoubleClick);
            // 
            // kode_alat
            // 
            this.kode_alat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kode_alat.DataPropertyName = "kode_alat";
            this.kode_alat.HeaderText = "Kode Alat";
            this.kode_alat.Name = "kode_alat";
            // 
            // nama_alat
            // 
            this.nama_alat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama_alat.DataPropertyName = "nama_alat";
            this.nama_alat.HeaderText = "Nama Alat";
            this.nama_alat.Name = "nama_alat";
            // 
            // jenis_alat
            // 
            this.jenis_alat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jenis_alat.DataPropertyName = "jenis_alat";
            this.jenis_alat.HeaderText = "Jenis";
            this.jenis_alat.Name = "jenis_alat";
            // 
            // letak
            // 
            this.letak.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.letak.DataPropertyName = "letak";
            this.letak.HeaderText = "Letak";
            this.letak.Name = "letak";
            // 
            // harga_pembelian
            // 
            this.harga_pembelian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.harga_pembelian.DataPropertyName = "harga_pembelian";
            this.harga_pembelian.HeaderText = "Harga ";
            this.harga_pembelian.Name = "harga_pembelian";
            // 
            // tahun_pembelian
            // 
            this.tahun_pembelian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tahun_pembelian.DataPropertyName = "tahun_pembelian";
            this.tahun_pembelian.HeaderText = "Tahun Pembelian";
            this.tahun_pembelian.Name = "tahun_pembelian";
            // 
            // kondisi
            // 
            this.kondisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kondisi.DataPropertyName = "kondisi";
            this.kondisi.HeaderText = "Kondisi";
            this.kondisi.Name = "kondisi";
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
            this.BtnRefresh.Location = new System.Drawing.Point(256, 343);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(106, 57);
            this.BtnRefresh.TabIndex = 68;
            this.BtnRefresh.Text = "Refresh [F5]";
            this.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnUbah
            // 
            this.BtnUbah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUbah.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnUbah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUbah.FlatAppearance.BorderSize = 0;
            this.BtnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUbah.ForeColor = System.Drawing.Color.Black;
            this.BtnUbah.Image = ((System.Drawing.Image)(resources.GetObject("BtnUbah.Image")));
            this.BtnUbah.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnUbah.Location = new System.Drawing.Point(367, 343);
            this.BtnUbah.Name = "BtnUbah";
            this.BtnUbah.Size = new System.Drawing.Size(79, 57);
            this.BtnUbah.TabIndex = 69;
            this.BtnUbah.Text = "Edit [F6]";
            this.BtnUbah.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnUbah.UseVisualStyleBackColor = false;
            this.BtnUbah.Click += new System.EventHandler(this.BtnUbah_Click_1);
            // 
            // BtnTambah
            // 
            this.BtnTambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTambah.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTambah.FlatAppearance.BorderSize = 0;
            this.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTambah.ForeColor = System.Drawing.Color.Black;
            this.BtnTambah.Image = ((System.Drawing.Image)(resources.GetObject("BtnTambah.Image")));
            this.BtnTambah.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnTambah.Location = new System.Drawing.Point(459, 343);
            this.BtnTambah.Name = "BtnTambah";
            this.BtnTambah.Size = new System.Drawing.Size(101, 57);
            this.BtnTambah.TabIndex = 70;
            this.BtnTambah.Text = "Tambah [F7]";
            this.BtnTambah.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnTambah.UseVisualStyleBackColor = false;
            this.BtnTambah.Click += new System.EventHandler(this.BtnTambah_Click_1);
            // 
            // BtnHapus
            // 
            this.BtnHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHapus.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHapus.FlatAppearance.BorderSize = 0;
            this.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHapus.ForeColor = System.Drawing.Color.Black;
            this.BtnHapus.Image = ((System.Drawing.Image)(resources.GetObject("BtnHapus.Image")));
            this.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnHapus.Location = new System.Drawing.Point(571, 343);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(96, 57);
            this.BtnHapus.TabIndex = 71;
            this.BtnHapus.Text = "Hapus [F8]";
            this.BtnHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnHapus.UseVisualStyleBackColor = false;
            this.BtnHapus.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnCetakAL
            // 
            this.BtnCetakAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCetakAL.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnCetakAL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCetakAL.FlatAppearance.BorderSize = 0;
            this.BtnCetakAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCetakAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCetakAL.ForeColor = System.Drawing.Color.Black;
            this.BtnCetakAL.Image = ((System.Drawing.Image)(resources.GetObject("BtnCetakAL.Image")));
            this.BtnCetakAL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCetakAL.Location = new System.Drawing.Point(680, 343);
            this.BtnCetakAL.Name = "BtnCetakAL";
            this.BtnCetakAL.Size = new System.Drawing.Size(86, 57);
            this.BtnCetakAL.TabIndex = 72;
            this.BtnCetakAL.Text = "Cetak [F9]";
            this.BtnCetakAL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCetakAL.UseVisualStyleBackColor = false;
            this.BtnCetakAL.Click += new System.EventHandler(this.BtnCetakAL_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(426, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 31);
            this.label1.TabIndex = 75;
            this.label1.Text = "CARI ALAT";
            // 
            // grpAlat
            // 
            this.grpAlat.Controls.Add(this.textBox7);
            this.grpAlat.Controls.Add(this.textjumlah);
            this.grpAlat.Controls.Add(this.texttahun);
            this.grpAlat.Controls.Add(this.textharga);
            this.grpAlat.Controls.Add(this.textletak);
            this.grpAlat.Controls.Add(this.textjenis);
            this.grpAlat.Controls.Add(this.textnama);
            this.grpAlat.Controls.Add(this.TxtKode);
            this.grpAlat.Controls.Add(this.BtnBack);
            this.grpAlat.Controls.Add(this.BtnSimpan);
            this.grpAlat.Controls.Add(this.label11);
            this.grpAlat.Controls.Add(this.label10);
            this.grpAlat.Controls.Add(this.label9);
            this.grpAlat.Controls.Add(this.label8);
            this.grpAlat.Controls.Add(this.label7);
            this.grpAlat.Controls.Add(this.label6);
            this.grpAlat.Controls.Add(this.label5);
            this.grpAlat.Controls.Add(this.label4);
            this.grpAlat.Controls.Add(this.label3);
            this.grpAlat.Location = new System.Drawing.Point(150, 14);
            this.grpAlat.Name = "grpAlat";
            this.grpAlat.Size = new System.Drawing.Size(330, 386);
            this.grpAlat.TabIndex = 76;
            this.grpAlat.TabStop = false;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(158, 277);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(122, 20);
            this.textBox7.TabIndex = 31;
            // 
            // textjumlah
            // 
            this.textjumlah.Location = new System.Drawing.Point(158, 248);
            this.textjumlah.Name = "textjumlah";
            this.textjumlah.Size = new System.Drawing.Size(122, 20);
            this.textjumlah.TabIndex = 30;
            // 
            // texttahun
            // 
            this.texttahun.Location = new System.Drawing.Point(158, 212);
            this.texttahun.Name = "texttahun";
            this.texttahun.Size = new System.Drawing.Size(122, 20);
            this.texttahun.TabIndex = 29;
            // 
            // textharga
            // 
            this.textharga.Location = new System.Drawing.Point(158, 185);
            this.textharga.Name = "textharga";
            this.textharga.Size = new System.Drawing.Size(122, 20);
            this.textharga.TabIndex = 28;
            // 
            // textletak
            // 
            this.textletak.Location = new System.Drawing.Point(158, 152);
            this.textletak.Name = "textletak";
            this.textletak.Size = new System.Drawing.Size(122, 20);
            this.textletak.TabIndex = 27;
            // 
            // textjenis
            // 
            this.textjenis.Location = new System.Drawing.Point(158, 118);
            this.textjenis.Name = "textjenis";
            this.textjenis.Size = new System.Drawing.Size(122, 20);
            this.textjenis.TabIndex = 26;
            // 
            // textnama
            // 
            this.textnama.Location = new System.Drawing.Point(158, 88);
            this.textnama.Name = "textnama";
            this.textnama.Size = new System.Drawing.Size(122, 20);
            this.textnama.TabIndex = 25;
            // 
            // TxtKode
            // 
            this.TxtKode.Location = new System.Drawing.Point(158, 56);
            this.TxtKode.Name = "TxtKode";
            this.TxtKode.Size = new System.Drawing.Size(122, 20);
            this.TxtKode.TabIndex = 24;
            // 
            // BtnBack
            // 
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.Location = new System.Drawing.Point(286, 13);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(38, 35);
            this.BtnBack.TabIndex = 23;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSimpan.Image = ((System.Drawing.Image)(resources.GetObject("BtnSimpan.Image")));
            this.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSimpan.Location = new System.Drawing.Point(126, 331);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(90, 40);
            this.BtnSimpan.TabIndex = 22;
            this.BtnSimpan.Text = "SIMPAN";
            this.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSimpan.UseVisualStyleBackColor = false;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 18);
            this.label11.TabIndex = 21;
            this.label11.Text = "Kondisi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Jumlah";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Tahun Pembelian";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Harga Pembelian";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Letak";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Jenis Alat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nama Alat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kode Alat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tambah Alat";
            // 
            // grpbuton
            // 
            this.grpbuton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpbuton.Controls.Add(this.button2);
            this.grpbuton.Controls.Add(this.button1);
            this.grpbuton.Location = new System.Drawing.Point(27, 325);
            this.grpbuton.Name = "grpbuton";
            this.grpbuton.Size = new System.Drawing.Size(236, 91);
            this.grpbuton.TabIndex = 77;
            this.grpbuton.TabStop = false;
            this.grpbuton.Text = "groupBox1";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(113, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 57);
            this.button2.TabIndex = 72;
            this.button2.Text = "Tambah Baru";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 57);
            this.button1.TabIndex = 71;
            this.button1.Text = "Tambah Ada";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Alat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(776, 412);
            this.Controls.Add(this.grpbuton);
            this.Controls.Add(this.grpAlat);
            this.Controls.Add(this.TxtCariAlat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCetakAL);
            this.Controls.Add(this.BtnHapus);
            this.Controls.Add(this.BtnTambah);
            this.Controls.Add(this.BtnUbah);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.dgvAlat);
            this.Controls.Add(this.labeljumlaha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCari);
            this.Name = "Alat";
            this.Text = "Alat";
            this.Load += new System.EventHandler(this.Alat_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlat)).EndInit();
            this.grpAlat.ResumeLayout(false);
            this.grpAlat.PerformLayout();
            this.grpbuton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labeljumlaha;
        private System.Windows.Forms.TextBox TxtCariAlat;
        private System.Windows.Forms.DataGridView dgvAlat;
        public System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnUbah;
        private System.Windows.Forms.Button BtnTambah;
        private System.Windows.Forms.Button BtnHapus;
        private System.Windows.Forms.Button BtnCetakAL;
        private System.Windows.Forms.Button BtnCari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_alat;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_alat;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenis_alat;
        private System.Windows.Forms.DataGridViewTextBoxColumn letak;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_pembelian;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahun_pembelian;
        private System.Windows.Forms.DataGridViewTextBoxColumn kondisi;
        private System.Windows.Forms.GroupBox grpAlat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textjumlah;
        private System.Windows.Forms.TextBox texttahun;
        private System.Windows.Forms.TextBox textharga;
        private System.Windows.Forms.TextBox textletak;
        private System.Windows.Forms.TextBox textjenis;
        private System.Windows.Forms.TextBox textnama;
        private System.Windows.Forms.TextBox TxtKode;
        private System.Windows.Forms.GroupBox grpbuton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}