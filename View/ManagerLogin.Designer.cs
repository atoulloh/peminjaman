namespace peminjaman
{
    partial class ManagerLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerLogin));
            this.BtnUbah = new System.Windows.Forms.Button();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.CmbLevel = new System.Windows.Forms.ComboBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvmanagerLogin = new System.Windows.Forms.DataGridView();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurusan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Hapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmanagerLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnUbah
            // 
            this.BtnUbah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnUbah.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnUbah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUbah.FlatAppearance.BorderSize = 0;
            this.BtnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUbah.ForeColor = System.Drawing.Color.Black;
            this.BtnUbah.Image = ((System.Drawing.Image)(resources.GetObject("BtnUbah.Image")));
            this.BtnUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUbah.Location = new System.Drawing.Point(243, 341);
            this.BtnUbah.Name = "BtnUbah";
            this.BtnUbah.Size = new System.Drawing.Size(139, 41);
            this.BtnUbah.TabIndex = 5;
            this.BtnUbah.Text = "Ubah Data";
            this.BtnUbah.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUbah.UseVisualStyleBackColor = false;
            this.BtnUbah.Click += new System.EventHandler(this.BtnUbah_Click);
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSimpan.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSimpan.FlatAppearance.BorderSize = 0;
            this.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSimpan.ForeColor = System.Drawing.Color.Black;
            this.BtnSimpan.Image = ((System.Drawing.Image)(resources.GetObject("BtnSimpan.Image")));
            this.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSimpan.Location = new System.Drawing.Point(12, 341);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(158, 41);
            this.BtnSimpan.TabIndex = 4;
            this.BtnSimpan.Text = "Simpan Data";
            this.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSimpan.UseVisualStyleBackColor = false;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // CmbLevel
            // 
            this.CmbLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmbLevel.BackColor = System.Drawing.Color.DimGray;
            this.CmbLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbLevel.ForeColor = System.Drawing.Color.White;
            this.CmbLevel.FormattingEnabled = true;
            this.CmbLevel.Items.AddRange(new object[] {
            "Admin",
            "Petugas",
            "Kepala jurusan"});
            this.CmbLevel.Location = new System.Drawing.Point(665, 285);
            this.CmbLevel.Name = "CmbLevel";
            this.CmbLevel.Size = new System.Drawing.Size(141, 28);
            this.CmbLevel.TabIndex = 85;
            this.CmbLevel.Text = "---Pilihan---";
            // 
            // TxtUser
            // 
            this.TxtUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtUser.BackColor = System.Drawing.Color.DimGray;
            this.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.ForeColor = System.Drawing.Color.White;
            this.TxtUser.Location = new System.Drawing.Point(168, 285);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(141, 22);
            this.TxtUser.TabIndex = 83;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(38, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 24);
            this.label11.TabIndex = 88;
            this.label11.Text = "Username";
            // 
            // TxtPass
            // 
            this.TxtPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtPass.BackColor = System.Drawing.Color.DimGray;
            this.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.ForeColor = System.Drawing.Color.White;
            this.TxtPass.Location = new System.Drawing.Point(435, 285);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(141, 22);
            this.TxtPass.TabIndex = 84;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(326, 285);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 24);
            this.label18.TabIndex = 86;
            this.label18.Text = "Password";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(604, 289);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 24);
            this.label20.TabIndex = 87;
            this.label20.Text = "Level";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 82;
            this.label1.Text = "DATA USER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvmanagerLogin
            // 
            this.dgvmanagerLogin.AllowUserToAddRows = false;
            this.dgvmanagerLogin.AllowUserToDeleteRows = false;
            this.dgvmanagerLogin.AllowUserToResizeColumns = false;
            this.dgvmanagerLogin.AllowUserToResizeRows = false;
            this.dgvmanagerLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvmanagerLogin.BackgroundColor = System.Drawing.Color.White;
            this.dgvmanagerLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvmanagerLogin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvmanagerLogin.ColumnHeadersHeight = 33;
            this.dgvmanagerLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvmanagerLogin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nama,
            this.jurusan,
            this.tanggal,
            this.jam});
            this.dgvmanagerLogin.GridColor = System.Drawing.Color.White;
            this.dgvmanagerLogin.Location = new System.Drawing.Point(12, 56);
            this.dgvmanagerLogin.Name = "dgvmanagerLogin";
            this.dgvmanagerLogin.ReadOnly = true;
            this.dgvmanagerLogin.Size = new System.Drawing.Size(859, 223);
            this.dgvmanagerLogin.TabIndex = 81;
            this.dgvmanagerLogin.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmanagerLogin_CellDoubleClick);
            // 
            // nama
            // 
            this.nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama.DataPropertyName = "username";
            this.nama.HeaderText = "Username";
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            // 
            // jurusan
            // 
            this.jurusan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jurusan.DataPropertyName = "password";
            this.jurusan.HeaderText = "Password";
            this.jurusan.Name = "jurusan";
            this.jurusan.ReadOnly = true;
            // 
            // tanggal
            // 
            this.tanggal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tanggal.DataPropertyName = "status";
            this.tanggal.HeaderText = "Status";
            this.tanggal.Name = "tanggal";
            this.tanggal.ReadOnly = true;
            // 
            // jam
            // 
            this.jam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jam.DataPropertyName = "level";
            this.jam.HeaderText = "Level";
            this.jam.Name = "jam";
            this.jam.ReadOnly = true;
            // 
            // btn_Hapus
            // 
            this.btn_Hapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Hapus.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Hapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Hapus.FlatAppearance.BorderSize = 0;
            this.btn_Hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hapus.ForeColor = System.Drawing.Color.Black;
            this.btn_Hapus.Image = ((System.Drawing.Image)(resources.GetObject("btn_Hapus.Image")));
            this.btn_Hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Hapus.Location = new System.Drawing.Point(457, 341);
            this.btn_Hapus.Name = "btn_Hapus";
            this.btn_Hapus.Size = new System.Drawing.Size(129, 41);
            this.btn_Hapus.TabIndex = 89;
            this.btn_Hapus.Text = "Hapus [F8]";
            this.btn_Hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Hapus.UseVisualStyleBackColor = false;
            this.btn_Hapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // ManagerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(883, 403);
            this.Controls.Add(this.btn_Hapus);
            this.Controls.Add(this.BtnUbah);
            this.Controls.Add(this.BtnSimpan);
            this.Controls.Add(this.CmbLevel);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvmanagerLogin);
            this.Name = "ManagerLogin";
            this.Text = "ManagerLogin";
            this.Load += new System.EventHandler(this.ManagerLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmanagerLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUbah;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.ComboBox CmbLevel;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvmanagerLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurusan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn jam;
        private System.Windows.Forms.Button btn_Hapus;
    }
}

