using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using peminjaman.Service;
using peminjaman.Services;

namespace peminjaman
{
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();
        }

        void manager()
        {
            LoginServ manager = new LoginServ();
            dgvmanagerLogin.DataSource = manager.ManagerLogin();
        }

        LoginServ Is = new LoginServ();
        void Simpan()
        {
            if (string.IsNullOrEmpty(TxtUser.Text) || string.IsNullOrEmpty(TxtPass.Text) || string.IsNullOrEmpty(CmbLevel.Text))
            {
                MessageBox.Show(" Data masih kosong", "pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                if (!Is.isExistData(TxtUser.Text))
                {
                    Is.Username = TxtUser.Text.Trim();
                    Is.Password = TxtPass.Text.Trim();
                    Is.Status = "Tidak Login";
                    Is.Level = CmbLevel.Text.Trim();
                    Is.Simpan();
                    MessageBox.Show("Data berhasil disimpan", " Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Bersihkan();
                }
                else
                {
                    if (MessageBox.Show("Data tersebut sudah ada.\nApakah data tersebut akan di ubah ?", "Ubah Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Is.Password = TxtPass.Text.Trim();
                        Is.Status = " Tidak Login";
                        Is.Level = CmbLevel.Text.Trim();
                        Is.UbahDataIsExist(TxtUser.Text);
                        MessageBox.Show("Data berhasil diubah", "Ubah data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Bersihkan();
                    }
                }
            }
        }

        void Hapus()
        {
            LoginServ login = new LoginServ();

            try
            {
                string cek = login.CekStat(dgvmanagerLogin.Rows[dgvmanagerLogin.CurrentCell.RowIndex].Cells[0].Value.ToString()).Rows[0][0].ToString();
                if (cek == "Sedang Login")
                {
                    MessageBox.Show("Sedang Login.. Tidak dapat menghapus data !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (Is.isExistData(dgvmanagerLogin.Rows[dgvmanagerLogin.CurrentCell.RowIndex].Cells[0].Value.ToString()))
                {

                    if (MessageBox.Show("Apakah data tersebut akan dihapus?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        Is.Hapus(dgvmanagerLogin.Rows[dgvmanagerLogin.CurrentCell.RowIndex].Cells[0].Value.ToString());
                        MessageBox.Show("Data Berhasil di hapus.  ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        manager();
                    }



                    else if (!Is.isExistData(dgvmanagerLogin.Rows[dgvmanagerLogin.CurrentCell.RowIndex].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Delum ada data yg dipilih.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Terjadi Kesalahan tidak dapat menghapus data !", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void Ubah()
        {
            Is.Username = TxtUser.Text.Trim();
            Is.Password = TxtPass.Text.Trim();
            Is.Status = "Tidak Login";
            Is.Level = CmbLevel.Text.Trim();
            Is.UbahData(this.dgvmanagerLogin.CurrentRow.Cells[0].Value.ToString());
            MessageBox.Show("data berhasil di ubah", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //BtnSimpan.Visible = true;
            //BtnUbah.Visible = true;
            Bersihkan();
            manager();
        }

        void Get()
        {
            TxtUser.Text = this.dgvmanagerLogin.CurrentRow.Cells[0].Value.ToString();
            TxtPass.Text = this.dgvmanagerLogin.CurrentRow.Cells[1].Value.ToString();
            CmbLevel.Text = this.dgvmanagerLogin.CurrentRow.Cells[3].Value.ToString();
        }

        void Bersihkan()
        {
            TxtUser.Text = "";
            TxtPass.Text = "";
            CmbLevel.Text = "---Pilih---";
        }


           
   


        private void ManagerLogin_Load(object sender, EventArgs e)
        {
            manager();
            //BtnUbah.Visible = false;
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            Simpan();
            manager();
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            Ubah();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            Hapus();
        }

        public string username { get; set; }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            Hapus();
        }

        private void dgvmanagerLogin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvmanagerLogin.Rows[e.RowIndex];

                TxtUser.Text = row.Cells[0].Value.ToString();
                TxtPass.Text = row.Cells[1].Value.ToString();
                CmbLevel.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
