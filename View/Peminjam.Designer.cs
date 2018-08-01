namespace peminjaman.View
{
    partial class Peminjam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Peminjam));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.labeljumlah = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CmbCariPeminjam = new System.Windows.Forms.ComboBox();
            this.TxtCariDtPinjam = new System.Windows.Forms.TextBox();
            this.btncariPinjam = new System.Windows.Forms.Button();
            this.BtnCetak = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnDetailPinjam = new System.Windows.Forms.Button();
            this.grpdetail = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvdetail = new System.Windows.Forms.DataGridView();
            this.txtdetail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPeminjam = new System.Windows.Forms.DataGridView();
            this.id_peminjaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_anggota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal_pinjam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Pinjaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama_Alat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.grpdetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeminjam)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(290, 37);
            this.label2.TabIndex = 58;
            this.label2.Text = "DATA PEMINJAM";
            // 
            // labeljumlah
            // 
            this.labeljumlah.AutoSize = true;
            this.labeljumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeljumlah.ForeColor = System.Drawing.Color.Black;
            this.labeljumlah.Location = new System.Drawing.Point(12, 91);
            this.labeljumlah.Name = "labeljumlah";
            this.labeljumlah.Size = new System.Drawing.Size(120, 16);
            this.labeljumlah.TabIndex = 63;
            this.labeljumlah.Text = "Jumlah Peminjam :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.CmbCariPeminjam);
            this.panel1.Controls.Add(this.TxtCariDtPinjam);
            this.panel1.Controls.Add(this.btncariPinjam);
            this.panel1.Location = new System.Drawing.Point(468, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 34);
            this.panel1.TabIndex = 72;
            // 
            // CmbCariPeminjam
            // 
            this.CmbCariPeminjam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmbCariPeminjam.BackColor = System.Drawing.Color.Gray;
            this.CmbCariPeminjam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbCariPeminjam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCariPeminjam.ForeColor = System.Drawing.Color.White;
            this.CmbCariPeminjam.FormattingEnabled = true;
            this.CmbCariPeminjam.Items.AddRange(new object[] {
            "Id Peminjam",
            "Id Anggota",
            "Nama Anggota",
            "Tanggal Pinjam"});
            this.CmbCariPeminjam.Location = new System.Drawing.Point(177, 0);
            this.CmbCariPeminjam.Name = "CmbCariPeminjam";
            this.CmbCariPeminjam.Size = new System.Drawing.Size(172, 28);
            this.CmbCariPeminjam.TabIndex = 70;
            this.CmbCariPeminjam.Text = "---Cari Data---";
            this.CmbCariPeminjam.SelectedIndexChanged += new System.EventHandler(this.CmbCariPeminjam_SelectedIndexChanged);
            // 
            // TxtCariDtPinjam
            // 
            this.TxtCariDtPinjam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtCariDtPinjam.BackColor = System.Drawing.Color.LightSlateGray;
            this.TxtCariDtPinjam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCariDtPinjam.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCariDtPinjam.ForeColor = System.Drawing.Color.White;
            this.TxtCariDtPinjam.Location = new System.Drawing.Point(3, 0);
            this.TxtCariDtPinjam.Name = "TxtCariDtPinjam";
            this.TxtCariDtPinjam.Size = new System.Drawing.Size(172, 28);
            this.TxtCariDtPinjam.TabIndex = 1;
            this.TxtCariDtPinjam.TextChanged += new System.EventHandler(this.TxtCariDtPinjam_TextChanged);
            // 
            // btncariPinjam
            // 
            this.btncariPinjam.Location = new System.Drawing.Point(83, 0);
            this.btncariPinjam.Name = "btncariPinjam";
            this.btncariPinjam.Size = new System.Drawing.Size(75, 23);
            this.btncariPinjam.TabIndex = 79;
            this.btncariPinjam.Text = "cari";
            this.btncariPinjam.UseVisualStyleBackColor = true;
            this.btncariPinjam.TextChanged += new System.EventHandler(this.btncariPinjam_TextChanged);
            this.btncariPinjam.Click += new System.EventHandler(this.btncariPinjam_Click);
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
            this.BtnCetak.Location = new System.Drawing.Point(632, 370);
            this.BtnCetak.Name = "BtnCetak";
            this.BtnCetak.Size = new System.Drawing.Size(86, 55);
            this.BtnCetak.TabIndex = 75;
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
            this.BtnRefresh.Location = new System.Drawing.Point(523, 370);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(103, 55);
            this.BtnRefresh.TabIndex = 76;
            this.BtnRefresh.Text = "Refresh [F5]";
            this.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnDetailPinjam
            // 
            this.BtnDetailPinjam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDetailPinjam.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnDetailPinjam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDetailPinjam.FlatAppearance.BorderSize = 0;
            this.BtnDetailPinjam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDetailPinjam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDetailPinjam.ForeColor = System.Drawing.Color.Black;
            this.BtnDetailPinjam.Image = ((System.Drawing.Image)(resources.GetObject("BtnDetailPinjam.Image")));
            this.BtnDetailPinjam.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnDetailPinjam.Location = new System.Drawing.Point(724, 370);
            this.BtnDetailPinjam.Name = "BtnDetailPinjam";
            this.BtnDetailPinjam.Size = new System.Drawing.Size(94, 55);
            this.BtnDetailPinjam.TabIndex = 78;
            this.BtnDetailPinjam.Text = "Detail [F6]";
            this.BtnDetailPinjam.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDetailPinjam.UseVisualStyleBackColor = false;
            this.BtnDetailPinjam.Click += new System.EventHandler(this.BtnDetailPinjam_Click);
            // 
            // grpdetail
            // 
            this.grpdetail.Controls.Add(this.button1);
            this.grpdetail.Controls.Add(this.dgvdetail);
            this.grpdetail.Controls.Add(this.txtdetail);
            this.grpdetail.Controls.Add(this.label1);
            this.grpdetail.Location = new System.Drawing.Point(148, 152);
            this.grpdetail.Name = "grpdetail";
            this.grpdetail.Size = new System.Drawing.Size(435, 205);
            this.grpdetail.TabIndex = 79;
            this.grpdetail.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvdetail
            // 
            this.dgvdetail.AllowUserToAddRows = false;
            this.dgvdetail.AllowUserToDeleteRows = false;
            this.dgvdetail.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Pinjaman,
            this.Nama_Alat,
            this.letak,
            this.Status});
            this.dgvdetail.Location = new System.Drawing.Point(6, 55);
            this.dgvdetail.Name = "dgvdetail";
            this.dgvdetail.ReadOnly = true;
            this.dgvdetail.Size = new System.Drawing.Size(423, 144);
            this.dgvdetail.TabIndex = 2;
            // 
            // txtdetail
            // 
            this.txtdetail.Location = new System.Drawing.Point(314, 29);
            this.txtdetail.Name = "txtdetail";
            this.txtdetail.Size = new System.Drawing.Size(100, 20);
            this.txtdetail.TabIndex = 1;
            this.txtdetail.TextChanged += new System.EventHandler(this.txtdetail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DETAIL PINJAM";
            // 
            // dgvPeminjam
            // 
            this.dgvPeminjam.AllowUserToAddRows = false;
            this.dgvPeminjam.AllowUserToDeleteRows = false;
            this.dgvPeminjam.AllowUserToResizeColumns = false;
            this.dgvPeminjam.AllowUserToResizeRows = false;
            this.dgvPeminjam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPeminjam.BackgroundColor = System.Drawing.Color.White;
            this.dgvPeminjam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPeminjam.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeminjam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPeminjam.ColumnHeadersHeight = 33;
            this.dgvPeminjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPeminjam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_peminjaman,
            this.Id_anggota,
            this.Nama,
            this.Tanggal_pinjam});
            this.dgvPeminjam.GridColor = System.Drawing.Color.White;
            this.dgvPeminjam.Location = new System.Drawing.Point(12, 112);
            this.dgvPeminjam.Name = "dgvPeminjam";
            this.dgvPeminjam.ReadOnly = true;
            this.dgvPeminjam.Size = new System.Drawing.Size(806, 242);
            this.dgvPeminjam.TabIndex = 80;
            this.dgvPeminjam.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeminjam_CellDoubleClick_1);
            // 
            // id_peminjaman
            // 
            this.id_peminjaman.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_peminjaman.DataPropertyName = "id_peminjaman";
            this.id_peminjaman.HeaderText = "ID Peminjaman";
            this.id_peminjaman.Name = "id_peminjaman";
            this.id_peminjaman.ReadOnly = true;
            // 
            // Id_anggota
            // 
            this.Id_anggota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id_anggota.DataPropertyName = "id_anggota";
            this.Id_anggota.HeaderText = "ID Anggota";
            this.Id_anggota.Name = "Id_anggota";
            this.Id_anggota.ReadOnly = true;
            // 
            // Nama
            // 
            this.Nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nama.DataPropertyName = "nama";
            this.Nama.HeaderText = "Nama Peminjam";
            this.Nama.Name = "Nama";
            this.Nama.ReadOnly = true;
            // 
            // Tanggal_pinjam
            // 
            this.Tanggal_pinjam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tanggal_pinjam.DataPropertyName = "tanggal_pinjam";
            this.Tanggal_pinjam.HeaderText = "Tanggal Pinjam";
            this.Tanggal_pinjam.Name = "Tanggal_pinjam";
            this.Tanggal_pinjam.ReadOnly = true;
            // 
            // ID_Pinjaman
            // 
            this.ID_Pinjaman.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_Pinjaman.DataPropertyName = "id_pinjaman";
            this.ID_Pinjaman.HeaderText = "ID Pinjaman";
            this.ID_Pinjaman.Name = "ID_Pinjaman";
            this.ID_Pinjaman.ReadOnly = true;
            // 
            // Nama_Alat
            // 
            this.Nama_Alat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nama_Alat.DataPropertyName = "nama_alat";
            this.Nama_Alat.HeaderText = "Nama Alat";
            this.Nama_Alat.Name = "Nama_Alat";
            this.Nama_Alat.ReadOnly = true;
            // 
            // letak
            // 
            this.letak.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.letak.DataPropertyName = "letak";
            this.letak.HeaderText = "Letak";
            this.letak.Name = "letak";
            this.letak.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.DataPropertyName = "status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Peminjam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(829, 437);
            this.Controls.Add(this.grpdetail);
            this.Controls.Add(this.dgvPeminjam);
            this.Controls.Add(this.BtnDetailPinjam);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnCetak);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labeljumlah);
            this.Controls.Add(this.label2);
            this.Name = "Peminjam";
            this.Text = "Peminjam";
            this.Load += new System.EventHandler(this.Peminjam_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpdetail.ResumeLayout(false);
            this.grpdetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeminjam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labeljumlah;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CmbCariPeminjam;
        private System.Windows.Forms.TextBox TxtCariDtPinjam;
        private System.Windows.Forms.Button BtnCetak;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnDetailPinjam;
        private System.Windows.Forms.Button btncariPinjam;
        private System.Windows.Forms.GroupBox grpdetail;
        private System.Windows.Forms.DataGridView dgvdetail;
        private System.Windows.Forms.TextBox txtdetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dgvPeminjam;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_peminjaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_anggota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal_pinjam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Pinjaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_Alat;
        private System.Windows.Forms.DataGridViewTextBoxColumn letak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}