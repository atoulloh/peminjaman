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
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kondisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnUbah = new System.Windows.Forms.Button();
            this.BtnTambah = new System.Windows.Forms.Button();
            this.BtnHapus = new System.Windows.Forms.Button();
            this.BtnCetakAL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlat)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 34);
            this.label2.TabIndex = 57;
            this.label2.Text = "DATA ALAT";
            // 
            // labeljumlaha
            // 
            this.labeljumlaha.AutoSize = true;
            this.labeljumlaha.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeljumlaha.ForeColor = System.Drawing.Color.Black;
            this.labeljumlaha.Location = new System.Drawing.Point(15, 68);
            this.labeljumlaha.Name = "labeljumlaha";
            this.labeljumlaha.Size = new System.Drawing.Size(81, 15);
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
            this.jumlah,
            this.kondisi});
            this.dgvAlat.Location = new System.Drawing.Point(12, 86);
            this.dgvAlat.Name = "dgvAlat";
            this.dgvAlat.Size = new System.Drawing.Size(758, 233);
            this.dgvAlat.TabIndex = 67;
            this.dgvAlat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlat_CellContentClick);
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
            // jumlah
            // 
            this.jumlah.DataPropertyName = "jumlah";
            this.jumlah.HeaderText = "Jumlah";
            this.jumlah.Name = "jumlah";
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
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(426, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 75;
            this.label1.Text = "CARI ALAT";
            // 
            // Alat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(776, 412);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_alat;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_alat;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenis_alat;
        private System.Windows.Forms.DataGridViewTextBoxColumn letak;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_pembelian;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahun_pembelian;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn kondisi;
        private System.Windows.Forms.Label label1;
    }
}