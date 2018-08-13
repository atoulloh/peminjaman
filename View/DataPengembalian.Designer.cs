namespace peminjaman.View
{
    partial class MonitorData
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
            this.dgvdetailpinjam = new System.Windows.Forms.DataGridView();
            this.dgvAlat = new System.Windows.Forms.DataGridView();
            this.txtdetail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kode_alat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaAlat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jenis_Alat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Letak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_pembelian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahun_pembelian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Pinjam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_anggota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama_Alat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal_Pinjam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetailpinjam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdetailpinjam
            // 
            this.dgvdetailpinjam.AllowUserToAddRows = false;
            this.dgvdetailpinjam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdetailpinjam.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvdetailpinjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetailpinjam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Pinjam,
            this.id_anggota,
            this.nama,
            this.Nama_Alat,
            this.Tanggal_Pinjam,
            this.Status});
            this.dgvdetailpinjam.Location = new System.Drawing.Point(12, 62);
            this.dgvdetailpinjam.Name = "dgvdetailpinjam";
            this.dgvdetailpinjam.Size = new System.Drawing.Size(983, 241);
            this.dgvdetailpinjam.TabIndex = 0;
            this.dgvdetailpinjam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvAlat
            // 
            this.dgvAlat.AllowUserToAddRows = false;
            this.dgvAlat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAlat.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAlat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kode_alat,
            this.NamaAlat,
            this.Jenis_Alat,
            this.Letak,
            this.harga_pembelian,
            this.tahun_pembelian});
            this.dgvAlat.Location = new System.Drawing.Point(12, 334);
            this.dgvAlat.Name = "dgvAlat";
            this.dgvAlat.ReadOnly = true;
            this.dgvAlat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlat.Size = new System.Drawing.Size(983, 232);
            this.dgvAlat.TabIndex = 1;
            this.dgvAlat.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlat_CellContentDoubleClick);
            this.dgvAlat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlat_CellDoubleClick);
            this.dgvAlat.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAlat_CellFormatting);
            this.dgvAlat.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlat_CellLeave);
            // 
            // txtdetail
            // 
            this.txtdetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdetail.Location = new System.Drawing.Point(844, 36);
            this.txtdetail.Name = "txtdetail";
            this.txtdetail.Size = new System.Drawing.Size(123, 20);
            this.txtdetail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "TABEL LIHAT STATUS DATA ALAT ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "TABEL CEK DATA ALAT ";
            // 
            // kode_alat
            // 
            this.kode_alat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kode_alat.DataPropertyName = "kode_alat";
            this.kode_alat.HeaderText = "Kode Alat";
            this.kode_alat.Name = "kode_alat";
            this.kode_alat.ReadOnly = true;
            // 
            // NamaAlat
            // 
            this.NamaAlat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamaAlat.DataPropertyName = "nama_alat";
            this.NamaAlat.HeaderText = "Nama Alat";
            this.NamaAlat.Name = "NamaAlat";
            this.NamaAlat.ReadOnly = true;
            // 
            // Jenis_Alat
            // 
            this.Jenis_Alat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Jenis_Alat.DataPropertyName = "jenis_alat";
            this.Jenis_Alat.HeaderText = "Jenis Alat";
            this.Jenis_Alat.Name = "Jenis_Alat";
            this.Jenis_Alat.ReadOnly = true;
            // 
            // Letak
            // 
            this.Letak.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Letak.DataPropertyName = "letak";
            this.Letak.HeaderText = "Letak";
            this.Letak.Name = "Letak";
            this.Letak.ReadOnly = true;
            // 
            // harga_pembelian
            // 
            this.harga_pembelian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.harga_pembelian.DataPropertyName = "harga_pembelian";
            this.harga_pembelian.HeaderText = "Harga Pembelian";
            this.harga_pembelian.Name = "harga_pembelian";
            this.harga_pembelian.ReadOnly = true;
            // 
            // tahun_pembelian
            // 
            this.tahun_pembelian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tahun_pembelian.DataPropertyName = "tahun_pembelian";
            this.tahun_pembelian.HeaderText = "Tahun Pembelian";
            this.tahun_pembelian.Name = "tahun_pembelian";
            this.tahun_pembelian.ReadOnly = true;
            // 
            // Id_Pinjam
            // 
            this.Id_Pinjam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id_Pinjam.DataPropertyName = "id_pinjaman";
            this.Id_Pinjam.HeaderText = "ID Pinjam";
            this.Id_Pinjam.Name = "Id_Pinjam";
            // 
            // id_anggota
            // 
            this.id_anggota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_anggota.DataPropertyName = "id_anggota";
            this.id_anggota.HeaderText = "ID Anggota";
            this.id_anggota.Name = "id_anggota";
            // 
            // nama
            // 
            this.nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama.DataPropertyName = "nama";
            this.nama.HeaderText = "Nama Peminjam";
            this.nama.Name = "nama";
            // 
            // Nama_Alat
            // 
            this.Nama_Alat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nama_Alat.DataPropertyName = "nama_alat";
            this.Nama_Alat.HeaderText = "Nama Alat";
            this.Nama_Alat.Name = "Nama_Alat";
            // 
            // Tanggal_Pinjam
            // 
            this.Tanggal_Pinjam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tanggal_Pinjam.DataPropertyName = "tanggal_pinjam";
            this.Tanggal_Pinjam.HeaderText = "Tanggal Pinjam";
            this.Tanggal_Pinjam.Name = "Tanggal_Pinjam";
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.DataPropertyName = "status";
            this.Status.HeaderText = "Status Alat";
            this.Status.Name = "Status";
            // 
            // MonitorData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1007, 578);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdetail);
            this.Controls.Add(this.dgvAlat);
            this.Controls.Add(this.dgvdetailpinjam);
            this.Name = "MonitorData";
            this.Text = "DataPengembalian";
            this.Load += new System.EventHandler(this.MonitorData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetailpinjam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdetailpinjam;
        private System.Windows.Forms.DataGridView dgvAlat;
        private System.Windows.Forms.TextBox txtdetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_alat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaAlat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jenis_Alat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Letak;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_pembelian;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahun_pembelian;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Pinjam;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_anggota;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_Alat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal_Pinjam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}