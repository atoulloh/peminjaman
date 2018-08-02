namespace peminjaman.View
{
    partial class Anggota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anggota));
            this.label2 = new System.Windows.Forms.Label();
            this.DgvAnggota = new System.Windows.Forms.DataGridView();
            this.id_anggota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenis_kelamin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurusan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_hp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtCariAg = new System.Windows.Forms.TextBox();
            this.CmbCariAnggota = new System.Windows.Forms.ComboBox();
            this.labeljumlahag = new System.Windows.Forms.Label();
            this.BtnRefAg = new System.Windows.Forms.Button();
            this.BtnEditAg = new System.Windows.Forms.Button();
            this.BtnCetakAg = new System.Windows.Forms.Button();
            this.BtnHapusAg = new System.Windows.Forms.Button();
            this.BtnCari = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAnggota)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.label2.Size = new System.Drawing.Size(298, 37);
            this.label2.TabIndex = 56;
            this.label2.Text = "DATA ANGGOTA ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DgvAnggota
            // 
            this.DgvAnggota.AllowUserToAddRows = false;
            this.DgvAnggota.AllowUserToDeleteRows = false;
            this.DgvAnggota.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvAnggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAnggota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_anggota,
            this.nis,
            this.nama,
            this.jenis_kelamin,
            this.kelas,
            this.jurusan,
            this.no_hp,
            this.alamat});
            this.DgvAnggota.Location = new System.Drawing.Point(12, 101);
            this.DgvAnggota.Name = "DgvAnggota";
            this.DgvAnggota.ReadOnly = true;
            this.DgvAnggota.Size = new System.Drawing.Size(840, 267);
            this.DgvAnggota.TabIndex = 57;
            // 
            // id_anggota
            // 
            this.id_anggota.DataPropertyName = "id_anggota";
            this.id_anggota.HeaderText = "ID Anggota";
            this.id_anggota.Name = "id_anggota";
            this.id_anggota.ReadOnly = true;
            // 
            // nis
            // 
            this.nis.DataPropertyName = "nis";
            this.nis.HeaderText = "NIS";
            this.nis.Name = "nis";
            this.nis.ReadOnly = true;
            // 
            // nama
            // 
            this.nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama.DataPropertyName = "nama";
            this.nama.HeaderText = "Nama Anggota";
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            // 
            // jenis_kelamin
            // 
            this.jenis_kelamin.DataPropertyName = "jenis_kelamin";
            this.jenis_kelamin.HeaderText = "Jenis Kelamin";
            this.jenis_kelamin.Name = "jenis_kelamin";
            this.jenis_kelamin.ReadOnly = true;
            // 
            // kelas
            // 
            this.kelas.DataPropertyName = "kelas";
            this.kelas.HeaderText = "Kelas";
            this.kelas.Name = "kelas";
            this.kelas.ReadOnly = true;
            // 
            // jurusan
            // 
            this.jurusan.DataPropertyName = "jurusan";
            this.jurusan.HeaderText = "Jurusan";
            this.jurusan.Name = "jurusan";
            this.jurusan.ReadOnly = true;
            // 
            // no_hp
            // 
            this.no_hp.DataPropertyName = "no_hp";
            this.no_hp.HeaderText = "No HP";
            this.no_hp.Name = "no_hp";
            this.no_hp.ReadOnly = true;
            // 
            // alamat
            // 
            this.alamat.DataPropertyName = "alamat";
            this.alamat.HeaderText = "Alamat";
            this.alamat.Name = "alamat";
            this.alamat.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.TxtCariAg);
            this.panel1.Controls.Add(this.CmbCariAnggota);
            this.panel1.Location = new System.Drawing.Point(478, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 36);
            this.panel1.TabIndex = 67;
            // 
            // TxtCariAg
            // 
            this.TxtCariAg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtCariAg.BackColor = System.Drawing.Color.SlateGray;
            this.TxtCariAg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCariAg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCariAg.ForeColor = System.Drawing.Color.White;
            this.TxtCariAg.Location = new System.Drawing.Point(3, 5);
            this.TxtCariAg.Name = "TxtCariAg";
            this.TxtCariAg.Size = new System.Drawing.Size(172, 28);
            this.TxtCariAg.TabIndex = 1;
            this.TxtCariAg.TextChanged += new System.EventHandler(this.TxtCariAg_TextChanged);
            // 
            // CmbCariAnggota
            // 
            this.CmbCariAnggota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmbCariAnggota.BackColor = System.Drawing.Color.DimGray;
            this.CmbCariAnggota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbCariAnggota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCariAnggota.ForeColor = System.Drawing.Color.White;
            this.CmbCariAnggota.FormattingEnabled = true;
            this.CmbCariAnggota.Items.AddRange(new object[] {
            "ID Anggota",
            "Nis",
            "Nama",
            "Jenis Kelamin",
            "Kelas",
            "Jurusan",
            "Alamat"});
            this.CmbCariAnggota.Location = new System.Drawing.Point(187, 5);
            this.CmbCariAnggota.Name = "CmbCariAnggota";
            this.CmbCariAnggota.Size = new System.Drawing.Size(172, 28);
            this.CmbCariAnggota.TabIndex = 63;
            this.CmbCariAnggota.Text = "---Cari Data---";
            this.CmbCariAnggota.SelectedIndexChanged += new System.EventHandler(this.CmbCariAnggota_SelectedIndexChanged);
            // 
            // labeljumlahag
            // 
            this.labeljumlahag.AutoSize = true;
            this.labeljumlahag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeljumlahag.ForeColor = System.Drawing.Color.Black;
            this.labeljumlahag.Location = new System.Drawing.Point(15, 80);
            this.labeljumlahag.Name = "labeljumlahag";
            this.labeljumlahag.Size = new System.Drawing.Size(111, 16);
            this.labeljumlahag.TabIndex = 68;
            this.labeljumlahag.Text = "Jumlah Anggota :";
            this.labeljumlahag.Click += new System.EventHandler(this.labeljumlahag_Click);
            // 
            // BtnRefAg
            // 
            this.BtnRefAg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefAg.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnRefAg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefAg.FlatAppearance.BorderSize = 0;
            this.BtnRefAg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefAg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefAg.ForeColor = System.Drawing.Color.Black;
            this.BtnRefAg.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefAg.Image")));
            this.BtnRefAg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRefAg.Location = new System.Drawing.Point(479, 390);
            this.BtnRefAg.Name = "BtnRefAg";
            this.BtnRefAg.Size = new System.Drawing.Size(105, 58);
            this.BtnRefAg.TabIndex = 69;
            this.BtnRefAg.Text = "Refresh [F5]";
            this.BtnRefAg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRefAg.UseVisualStyleBackColor = false;
            this.BtnRefAg.Click += new System.EventHandler(this.BtnRefAg_Click);
            // 
            // BtnEditAg
            // 
            this.BtnEditAg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditAg.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnEditAg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditAg.FlatAppearance.BorderSize = 0;
            this.BtnEditAg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditAg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditAg.ForeColor = System.Drawing.Color.Black;
            this.BtnEditAg.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditAg.Image")));
            this.BtnEditAg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEditAg.Location = new System.Drawing.Point(590, 390);
            this.BtnEditAg.Name = "BtnEditAg";
            this.BtnEditAg.Size = new System.Drawing.Size(74, 59);
            this.BtnEditAg.TabIndex = 70;
            this.BtnEditAg.Text = "Edit [F6]";
            this.BtnEditAg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEditAg.UseVisualStyleBackColor = false;
            this.BtnEditAg.Click += new System.EventHandler(this.BtnEditAg_Click);
            // 
            // BtnCetakAg
            // 
            this.BtnCetakAg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCetakAg.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnCetakAg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCetakAg.FlatAppearance.BorderSize = 0;
            this.BtnCetakAg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCetakAg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCetakAg.ForeColor = System.Drawing.Color.Black;
            this.BtnCetakAg.Image = ((System.Drawing.Image)(resources.GetObject("BtnCetakAg.Image")));
            this.BtnCetakAg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCetakAg.Location = new System.Drawing.Point(768, 391);
            this.BtnCetakAg.Name = "BtnCetakAg";
            this.BtnCetakAg.Size = new System.Drawing.Size(82, 59);
            this.BtnCetakAg.TabIndex = 71;
            this.BtnCetakAg.Text = "Cetak [F7]";
            this.BtnCetakAg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCetakAg.UseVisualStyleBackColor = false;
            this.BtnCetakAg.Click += new System.EventHandler(this.BtnCetakAg_Click);
            // 
            // BtnHapusAg
            // 
            this.BtnHapusAg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHapusAg.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnHapusAg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHapusAg.FlatAppearance.BorderSize = 0;
            this.BtnHapusAg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHapusAg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHapusAg.ForeColor = System.Drawing.Color.Black;
            this.BtnHapusAg.Image = ((System.Drawing.Image)(resources.GetObject("BtnHapusAg.Image")));
            this.BtnHapusAg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnHapusAg.Location = new System.Drawing.Point(673, 391);
            this.BtnHapusAg.Name = "BtnHapusAg";
            this.BtnHapusAg.Size = new System.Drawing.Size(89, 58);
            this.BtnHapusAg.TabIndex = 73;
            this.BtnHapusAg.Text = "Hapus [F8]";
            this.BtnHapusAg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnHapusAg.UseVisualStyleBackColor = false;
            this.BtnHapusAg.Click += new System.EventHandler(this.BtnHapusAg_Click);
            // 
            // BtnCari
            // 
            this.BtnCari.Location = new System.Drawing.Point(747, 72);
            this.BtnCari.Name = "BtnCari";
            this.BtnCari.Size = new System.Drawing.Size(75, 23);
            this.BtnCari.TabIndex = 74;
            this.BtnCari.Text = "Cari";
            this.BtnCari.UseVisualStyleBackColor = true;
            this.BtnCari.Click += new System.EventHandler(this.BtnCari_Click);
            // 
            // Anggota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(864, 461);
            this.Controls.Add(this.BtnRefAg);
            this.Controls.Add(this.BtnHapusAg);
            this.Controls.Add(this.BtnEditAg);
            this.Controls.Add(this.BtnCetakAg);
            this.Controls.Add(this.labeljumlahag);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvAnggota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCari);
            this.Name = "Anggota";
            this.Text = "Anggota";
            this.Load += new System.EventHandler(this.Anggota_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAnggota)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvAnggota;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtCariAg;
        private System.Windows.Forms.ComboBox CmbCariAnggota;
        private System.Windows.Forms.Label labeljumlahag;
        public System.Windows.Forms.Button BtnRefAg;
        private System.Windows.Forms.Button BtnEditAg;
        private System.Windows.Forms.Button BtnCetakAg;
        private System.Windows.Forms.Button BtnHapusAg;
        private System.Windows.Forms.Button BtnCari;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_anggota;
        private System.Windows.Forms.DataGridViewTextBoxColumn nis;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenis_kelamin;
        private System.Windows.Forms.DataGridViewTextBoxColumn kelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurusan;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_hp;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamat;
    }
}