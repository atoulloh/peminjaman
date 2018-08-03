using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using peminjaman.Service;
using peminjaman.Reports;

namespace peminjaman.View
{
    public partial class Peminjam : Form
    {
      PinjamServ pbs = new PinjamServ();
        public Peminjam()
        {
            InitializeComponent();
            grpdetail.Left = 400;
            grpdetail.Top = 100;
            grpdetail.Width = 500;
            grpdetail.Height = 200;
            grpdetail.BringToFront();
            dgvdetail.AutoGenerateColumns = false;

            grpdetail.Visible = false;
        }
        

        private void Peminjam_Load(object sender, EventArgs e)
        {
            //PinjamServ pbs = new PinjamServ();
            //DgvPeminjam.DataSource = pbs.TampilSemuaPeminjam();
            TampilPeminjam();

            //hitung kode alat otomatis
            PinjamServ pjm = new PinjamServ();
            int x = Convert.ToInt32(pjm.HitungPeminjam().Rows[0][0].ToString());

            labeljumlah.Text = "Jumlah Peminjam : " + dgvPeminjam.RowCount.ToString();

            //full screen
            WindowState = FormWindowState.Maximized;

            TxtCariDtPinjam.Focus();

        }

        
        void TampilPeminjam()
        {
            PinjamServ pbs = new PinjamServ();
            dgvPeminjam.DataSource = pbs.TampilSemuaPeminjam();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            TampilPeminjam();
        }

        private void BtnBackPinjam_Click(object sender, EventArgs e)
        {
            Close();
        }

       /* String kategori;
        private void CmbCariPeminjam_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = CmbCariPeminjam.Text;

            switch (x)
            {
                case " Id Peminjam":
                    kategori = " id_peminjaman";
                    break;
                case " Id Anggota":
                    kategori = "id_anggota";
                    break;
                case " Nama Anggota":
                    kategori = "nama";
                    break;
                case " Tanggal Pinjam":
                    kategori = " tanggal_pijam";
                    break;
            }
        }*/

        private void btncariPinjam_Click(object sender, EventArgs e)
        {
            //btncariPinjam.PerformClick();
            PinjamServ pinjam = new PinjamServ();
            dgvPeminjam.DataSource = pinjam.CariPeminjam(TxtCariDtPinjam.Text, "").DefaultView;
        
        }

        private void btncariPinjam_TextChanged(object sender, EventArgs e)
        {
            btncariPinjam.PerformClick();
        
        }

        private void TxtCariDtPinjam_TextChanged(object sender, EventArgs e)
        {
            //btncariPinjam.PerformClick();
            PinjamServ pinjam = new PinjamServ();
            dgvPeminjam.DataSource = pinjam.CariPeminjam(TxtCariDtPinjam.Text, "").DefaultView;
        }

        private void BtnHapusPeminjam_Click(object sender, EventArgs e)
        {
            PinjamServ pjm = new PinjamServ();
            try
            {
                if(pjm.isExistPeminjam(dgvPeminjam.Rows[dgvPeminjam.CurrentCell.RowIndex].Cells[0].Value.ToString()))
                {
                    if (MessageBox.Show("Apakah data tersebut akan dihapus?" , "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        pjm.HapusPeminjam(dgvPeminjam.Rows[dgvPeminjam.CurrentCell.RowIndex].Cells[0].Value.ToString());
                        MessageBox.Show("Data Berhasil di hapus.  ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TampilPeminjam();
                    }
                }

                else if (!pjm.isExistPeminjam(dgvPeminjam.Rows[dgvPeminjam.CurrentCell.RowIndex].Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Belum ada data yang dipilih. ", " Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
                catch
            {
                MessageBox.Show("Terjadi kesalahan tidak dapat menghapus data !", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        //Detail Pinjam

        void Detail()
        {
            PinjamServ dpm = new PinjamServ();
           // DetailPinjam dpm = new DetailPinjam();
            if (dgvPeminjam.Rows.Count == 0)
            {
                MessageBox.Show("Data belum ada yang dipilih.  ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            else
            {
                txtdetail.Text = this.dgvPeminjam.CurrentRow.Cells[0].Value.ToString();
                //dpm.ShowDialog();
            }
        }

        private void BtnDetailPinjam_Click(object sender, EventArgs e)
        {
            grpdetail.Visible = true;
            Detail();
        }

        private void DgvPeminjam_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Detail();
           // DetailPinjam dpm = new DetailPinjam();
           
           
          /* if (e.RowIndex >= 0)
           {
               DataGridViewRow row = this.DgvPeminjam.Rows[e.RowIndex];

               txtdetail.Text = row[0].Cells[0].Value.ToString();
               //TxtNamaAnggota.Text = row.Cells[1].Value.ToString();

               grpdetail.Visible = true;
           }*/

            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtCariD_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtCariD_TextChanged_1(object sender, EventArgs e)
        {
            //PinjamServ pjm = new PinjamServ();
           // dgvDetailPinjam.DataSource = pjm.TampilDetailPinjam(TxtCariD.Text);
        }

        private void txtdetail_TextChanged(object sender, EventArgs e)
        {
            PinjamServ pjm = new PinjamServ();
            dgvdetail.DataSource = pjm.TampilPinjaman(txtdetail.Text).DefaultView;
        }

        private void Peminjam_Load_1(object sender, EventArgs e)
        {
            PinjamServ pbs = new PinjamServ();
            dgvPeminjam.DataSource = pbs.TampilSemuaPeminjam();
            int numRows = dgvPeminjam.Rows.Count;
            labeljumlah.Text = " Jumlah Peminjam : " + numRows.ToString();
        }

        private void dgvPeminjam_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            PinjamServ pjm = new PinjamServ();
            if (e.RowIndex >= 0)
           {
               DataGridViewRow row = this.dgvPeminjam.Rows[e.RowIndex];

               txtdetail.Text = row.Cells[0].Value.ToString();
               //TxtNamaAnggota.Text = row.Cells[1].Value.ToString();

               grpdetail.Visible = true;
           }
            /*if (dgvPeminjam.SelectedRows.Count > 0)
            {
                string id = dgvPeminjam.SelectedRows[0].Cells[0].Value + string.Empty;
                txtdetail.Text = id;
                grpdetail.Visible = true;
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpdetail.Visible = false;
        }

        private void BtnCetak_Click(object sender, EventArgs e)
        {
              Peminjam pm = new Peminjam();
            FrmLaporan rp = new FrmLaporan();
            rp.Show();
        }

    }
}
