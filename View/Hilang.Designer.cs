namespace peminjaman.View
{
    partial class Hilang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hilang));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvhilang = new System.Windows.Forms.DataGridView();
            this.BtnCetak = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.labelhilang = new System.Windows.Forms.Label();
            this.id_peminjaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_anggota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama_alat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhilang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 101;
            this.label1.Text = "ALAT HILANG";
            // 
            // dgvhilang
            // 
            this.dgvhilang.AllowUserToAddRows = false;
            this.dgvhilang.AllowUserToDeleteRows = false;
            this.dgvhilang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvhilang.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvhilang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhilang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_peminjaman,
            this.id_anggota,
            this.nama,
            this.Nama_alat,
            this.letak,
            this.jumlah,
            this.status});
            this.dgvhilang.Location = new System.Drawing.Point(12, 59);
            this.dgvhilang.Name = "dgvhilang";
            this.dgvhilang.ReadOnly = true;
            this.dgvhilang.Size = new System.Drawing.Size(872, 287);
            this.dgvhilang.TabIndex = 102;
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
            this.BtnCetak.Location = new System.Drawing.Point(784, 352);
            this.BtnCetak.Name = "BtnCetak";
            this.BtnCetak.Size = new System.Drawing.Size(86, 65);
            this.BtnCetak.TabIndex = 103;
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
            this.BtnRefresh.Location = new System.Drawing.Point(670, 352);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(97, 65);
            this.BtnRefresh.TabIndex = 104;
            this.BtnRefresh.Text = "Refresh [F5]";
            this.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // labelhilang
            // 
            this.labelhilang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelhilang.AutoSize = true;
            this.labelhilang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhilang.Location = new System.Drawing.Point(12, 352);
            this.labelhilang.Name = "labelhilang";
            this.labelhilang.Size = new System.Drawing.Size(129, 18);
            this.labelhilang.TabIndex = 105;
            this.labelhilang.Text = "Jumlah Alat Hilang";
            // 
            // id_peminjaman
            // 
            this.id_peminjaman.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_peminjaman.DataPropertyName = "id_peminjaman";
            this.id_peminjaman.HeaderText = "ID_Peminjaman";
            this.id_peminjaman.Name = "id_peminjaman";
            this.id_peminjaman.ReadOnly = true;
            // 
            // id_anggota
            // 
            this.id_anggota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_anggota.DataPropertyName = "id_anggota";
            this.id_anggota.HeaderText = "Id Anggota";
            this.id_anggota.Name = "id_anggota";
            this.id_anggota.ReadOnly = true;
            // 
            // nama
            // 
            this.nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama.DataPropertyName = "nama";
            this.nama.HeaderText = "Nama Anggota";
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            // 
            // Nama_alat
            // 
            this.Nama_alat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nama_alat.DataPropertyName = "nama_alat";
            this.Nama_alat.HeaderText = "Nama Alat";
            this.Nama_alat.Name = "Nama_alat";
            this.Nama_alat.ReadOnly = true;
            // 
            // letak
            // 
            this.letak.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.letak.DataPropertyName = "Letak";
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
            this.status.DataPropertyName = "status_alat";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // Hilang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(896, 426);
            this.Controls.Add(this.labelhilang);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnCetak);
            this.Controls.Add(this.dgvhilang);
            this.Controls.Add(this.label1);
            this.Name = "Hilang";
            this.Text = "Hilang";
            this.Load += new System.EventHandler(this.Hilang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhilang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvhilang;
        private System.Windows.Forms.Button BtnCetak;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Label labelhilang;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_peminjaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_anggota;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_alat;
        private System.Windows.Forms.DataGridViewTextBoxColumn letak;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}