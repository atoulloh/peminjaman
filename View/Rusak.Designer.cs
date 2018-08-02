namespace peminjaman.View
{
    partial class Rusak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rusak));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvalatrusak = new System.Windows.Forms.DataGridView();
            this.kode_alat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_alat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenis_alat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCetakAL = new System.Windows.Forms.Button();
            this.BtnHapus = new System.Windows.Forms.Button();
            this.BtnTambah = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.txtdetail = new System.Windows.Forms.TextBox();
            this.labelrusak = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvalatrusak)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Alat Rusak";
            // 
            // dgvalatrusak
            // 
            this.dgvalatrusak.AllowUserToAddRows = false;
            this.dgvalatrusak.AllowUserToDeleteRows = false;
            this.dgvalatrusak.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvalatrusak.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvalatrusak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvalatrusak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kode_alat,
            this.nama_alat,
            this.jenis_alat,
            this.letak,
            this.jumlah,
            this.status});
            this.dgvalatrusak.Location = new System.Drawing.Point(12, 62);
            this.dgvalatrusak.Name = "dgvalatrusak";
            this.dgvalatrusak.ReadOnly = true;
            this.dgvalatrusak.Size = new System.Drawing.Size(724, 349);
            this.dgvalatrusak.TabIndex = 1;
            // 
            // kode_alat
            // 
            this.kode_alat.DataPropertyName = "kode_alat";
            this.kode_alat.HeaderText = "Kode Alat";
            this.kode_alat.Name = "kode_alat";
            this.kode_alat.ReadOnly = true;
            // 
            // nama_alat
            // 
            this.nama_alat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama_alat.DataPropertyName = "nama_alat";
            this.nama_alat.HeaderText = "Nama Alat";
            this.nama_alat.Name = "nama_alat";
            this.nama_alat.ReadOnly = true;
            // 
            // jenis_alat
            // 
            this.jenis_alat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jenis_alat.DataPropertyName = "jenis_alat";
            this.jenis_alat.HeaderText = "Jenis Alat";
            this.jenis_alat.Name = "jenis_alat";
            this.jenis_alat.ReadOnly = true;
            // 
            // letak
            // 
            this.letak.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.letak.DataPropertyName = "letak";
            this.letak.HeaderText = "Letak";
            this.letak.Name = "letak";
            this.letak.ReadOnly = true;
            // 
            // jumlah
            // 
            this.jumlah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jumlah.DataPropertyName = "jumlah";
            this.jumlah.HeaderText = "Jumlah";
            this.jumlah.Name = "jumlah";
            this.jumlah.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status Alat";
            this.status.Name = "status";
            this.status.ReadOnly = true;
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
            this.BtnCetakAL.Location = new System.Drawing.Point(650, 417);
            this.BtnCetakAL.Name = "BtnCetakAL";
            this.BtnCetakAL.Size = new System.Drawing.Size(86, 57);
            this.BtnCetakAL.TabIndex = 73;
            this.BtnCetakAL.Text = "Cetak [F9]";
            this.BtnCetakAL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCetakAL.UseVisualStyleBackColor = false;
            this.BtnCetakAL.Click += new System.EventHandler(this.BtnCetakAL_Click);
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
            this.BtnHapus.Location = new System.Drawing.Point(548, 417);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(96, 57);
            this.BtnHapus.TabIndex = 74;
            this.BtnHapus.Text = "Hapus [F8]";
            this.BtnHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnHapus.UseVisualStyleBackColor = false;
            this.BtnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
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
            this.BtnTambah.Location = new System.Drawing.Point(441, 417);
            this.BtnTambah.Name = "BtnTambah";
            this.BtnTambah.Size = new System.Drawing.Size(101, 57);
            this.BtnTambah.TabIndex = 75;
            this.BtnTambah.Text = "Tambah [F7]";
            this.BtnTambah.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnTambah.UseVisualStyleBackColor = false;
            this.BtnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
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
            this.BtnRefresh.Location = new System.Drawing.Point(329, 417);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(106, 57);
            this.BtnRefresh.TabIndex = 76;
            this.BtnRefresh.Text = "Refresh [F5]";
            this.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // txtdetail
            // 
            this.txtdetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdetail.Location = new System.Drawing.Point(613, 36);
            this.txtdetail.Name = "txtdetail";
            this.txtdetail.Size = new System.Drawing.Size(123, 20);
            this.txtdetail.TabIndex = 77;
            // 
            // labelrusak
            // 
            this.labelrusak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelrusak.AutoSize = true;
            this.labelrusak.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelrusak.Location = new System.Drawing.Point(12, 417);
            this.labelrusak.Name = "labelrusak";
            this.labelrusak.Size = new System.Drawing.Size(148, 18);
            this.labelrusak.TabIndex = 78;
            this.labelrusak.Text = "Jumlah Alat Rusak";
            // 
            // Rusak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(748, 484);
            this.Controls.Add(this.labelrusak);
            this.Controls.Add(this.txtdetail);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnTambah);
            this.Controls.Add(this.BtnHapus);
            this.Controls.Add(this.BtnCetakAL);
            this.Controls.Add(this.dgvalatrusak);
            this.Controls.Add(this.label1);
            this.Name = "Rusak";
            this.Text = "Rusak";
            this.Load += new System.EventHandler(this.Rusak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvalatrusak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvalatrusak;
        private System.Windows.Forms.Button BtnCetakAL;
        private System.Windows.Forms.Button BtnHapus;
        private System.Windows.Forms.Button BtnTambah;
        public System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_alat;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_alat;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenis_alat;
        private System.Windows.Forms.DataGridViewTextBoxColumn letak;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.TextBox txtdetail;
        private System.Windows.Forms.Label labelrusak;
    }
}