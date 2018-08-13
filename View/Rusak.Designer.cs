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
            this.BtnCetakAL = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.txtrusak = new System.Windows.Forms.TextBox();
            this.labelrusak = new System.Windows.Forms.Label();
            this.id_peminjaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_anggota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_alat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.id_peminjaman,
            this.id_anggota,
            this.nama,
            this.nama_alat,
            this.letak,
            this.jumlah,
            this.status});
            this.dgvalatrusak.Location = new System.Drawing.Point(12, 62);
            this.dgvalatrusak.Name = "dgvalatrusak";
            this.dgvalatrusak.ReadOnly = true;
            this.dgvalatrusak.Size = new System.Drawing.Size(724, 349);
            this.dgvalatrusak.TabIndex = 1;
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
            this.BtnRefresh.Location = new System.Drawing.Point(548, 417);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(106, 57);
            this.BtnRefresh.TabIndex = 76;
            this.BtnRefresh.Text = "Refresh [F5]";
            this.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // txtrusak
            // 
            this.txtrusak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtrusak.Location = new System.Drawing.Point(613, 36);
            this.txtrusak.Name = "txtrusak";
            this.txtrusak.Size = new System.Drawing.Size(123, 20);
            this.txtrusak.TabIndex = 77;
            this.txtrusak.TextChanged += new System.EventHandler(this.txtdetail_TextChanged);
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
            // id_peminjaman
            // 
            this.id_peminjaman.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_peminjaman.DataPropertyName = "id_peminjaman";
            this.id_peminjaman.HeaderText = "ID Peminjaman";
            this.id_peminjaman.Name = "id_peminjaman";
            this.id_peminjaman.ReadOnly = true;
            // 
            // id_anggota
            // 
            this.id_anggota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_anggota.DataPropertyName = "id_anggota";
            this.id_anggota.HeaderText = "ID Anggota";
            this.id_anggota.Name = "id_anggota";
            this.id_anggota.ReadOnly = true;
            // 
            // nama
            // 
            this.nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama.DataPropertyName = "nama";
            this.nama.HeaderText = "Nama";
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            // 
            // nama_alat
            // 
            this.nama_alat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama_alat.DataPropertyName = "nama_alat";
            this.nama_alat.HeaderText = "Nama Alat";
            this.nama_alat.Name = "nama_alat";
            this.nama_alat.ReadOnly = true;
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
            // Rusak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(748, 484);
            this.Controls.Add(this.labelrusak);
            this.Controls.Add(this.txtrusak);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnCetakAL);
            this.Controls.Add(this.dgvalatrusak);
            this.Controls.Add(this.label1);
            this.Name = "Rusak";
            this.Text = "Rusak";
            this.Load += new System.EventHandler(this.Rusak_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Rusak_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvalatrusak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvalatrusak;
        private System.Windows.Forms.Button BtnCetakAL;
        public System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.TextBox txtrusak;
        private System.Windows.Forms.Label labelrusak;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_peminjaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_anggota;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_alat;
        private System.Windows.Forms.DataGridViewTextBoxColumn letak;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}