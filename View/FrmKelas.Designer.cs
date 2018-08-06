namespace peminjaman.View
{
    partial class FrmKelas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkelas = new System.Windows.Forms.TextBox();
            this.txtjurusan = new System.Windows.Forms.TextBox();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVKelas = new System.Windows.Forms.DataGridView();
            this.kelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurusan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVKelas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KELAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "JURUSAN";
            // 
            // txtkelas
            // 
            this.txtkelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkelas.Location = new System.Drawing.Point(86, 42);
            this.txtkelas.Name = "txtkelas";
            this.txtkelas.Size = new System.Drawing.Size(134, 22);
            this.txtkelas.TabIndex = 2;
            // 
            // txtjurusan
            // 
            this.txtjurusan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjurusan.Location = new System.Drawing.Point(87, 81);
            this.txtjurusan.Name = "txtjurusan";
            this.txtjurusan.Size = new System.Drawing.Size(133, 22);
            this.txtjurusan.TabIndex = 3;
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(127, 166);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(75, 23);
            this.btnhapus.TabIndex = 4;
            this.btnhapus.Text = "HAPUS";
            this.btnhapus.UseVisualStyleBackColor = true;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // btnsimpan
            // 
            this.btnsimpan.Location = new System.Drawing.Point(28, 166);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(75, 23);
            this.btnsimpan.TabIndex = 5;
            this.btnsimpan.Text = "SIMPAN";
            this.btnsimpan.UseVisualStyleBackColor = true;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "TAMBAH KELAS DAN JURUSAN BARU";
            // 
            // DGVKelas
            // 
            this.DGVKelas.AllowUserToAddRows = false;
            this.DGVKelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVKelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kelas,
            this.jurusan});
            this.DGVKelas.Location = new System.Drawing.Point(243, 39);
            this.DGVKelas.Name = "DGVKelas";
            this.DGVKelas.Size = new System.Drawing.Size(358, 150);
            this.DGVKelas.TabIndex = 7;
            // 
            // kelas
            // 
            this.kelas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kelas.DataPropertyName = "kelas";
            this.kelas.HeaderText = "Kelas";
            this.kelas.Name = "kelas";
            // 
            // jurusan
            // 
            this.jurusan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jurusan.DataPropertyName = "jurusan";
            this.jurusan.HeaderText = "Jurusan";
            this.jurusan.Name = "jurusan";
            // 
            // FrmKelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(650, 225);
            this.Controls.Add(this.DGVKelas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.txtjurusan);
            this.Controls.Add(this.txtkelas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmKelas";
            this.Text = "FrmKelas";
            this.Load += new System.EventHandler(this.FrmKelas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVKelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkelas;
        private System.Windows.Forms.TextBox txtjurusan;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGVKelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn kelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurusan;
    }
}