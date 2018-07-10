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

namespace peminjaman.View
{
    public partial class Menu : Form
    {
        int hasil = 0;

        public string username;
        public Menu()
        {
            InitializeComponent();
            GrpAlat.Visible = false;
            GrpAlat.Left = 400;
            GrpAlat.Top = 100;
            GrpAlat.Width = 500;
            GrpAlat.Height = 200;
            GrpAlat.BringToFront();
            dgvNamaAlat.AutoGenerateColumns = false;
            dgvanggota.AutoGenerateColumns = false;
            DgvKNamaAlat.AutoGenerateColumns = false;


            grpAnggota.Visible = false;
        }

        private void AmbilForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Visible = true;
            FormHosts.Controls.Clear();
            FormHosts.Controls.Add(form);
        }

        //ikut peminjaman.
        void BersihPinjam()
        {
            PinjamServ pb = new PinjamServ();
            TxtIdPeminjaman.Text = pb.KDPinjamOtomatis();
            TxtIdAnggota.Text = "";
            TxtNamaAnggota.Text ="";
            txtjumlah.Text = "";

            DgvAl.Rows.Clear();
            DgvAl.Refresh();
            DTPtglpinjam.ResetText();

        }
        //ikut peminjaman
        private void BtnPinjam_Click(object sender, EventArgs e)
        {
            PinjamServ pb = new PinjamServ();
            TxtIdPeminjaman.Text = pb.KDPinjamOtomatis();
            try
            {
                if
                   (string.IsNullOrEmpty(TxtIdPeminjaman.Text) || 
                    string.IsNullOrEmpty(TxtIdAnggota.Text) ||
                    string.IsNullOrEmpty(TxtNamaAnggota.Text) ||
                    //string.IsNullOrEmpty(TxtKodeAlat.Text) ||
                    string.IsNullOrEmpty(txtjumlah.Text))
                {
                    MessageBox.Show("Mohon Data di isi semua \nTidak boleh ada yang kosong ",
                         "Informasi", MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                    
                }
                else 
                {
                    
                    pb.IdPeminjaman = TxtIdPeminjaman.Text.Trim();
                    pb.IdAnggota = TxtIdAnggota.Text.Trim();
                    pb.Nama = TxtNamaAnggota.Text.Trim();
                    pb.Jumlah = int.Parse(txtjumlah.Text.Trim());
                    //pb.Jam_Pinjam = TxtJamPinjam.Text.Trim();
                    //pb.Tanggal_Pinjam = DTPtglpinjam.Value.ToString("yyyy/mm/dd");
                    
                    //MessageBox.Show("Data Berhasil di Simpan. ",
                        //  "Informasi", MessageBoxButtons.OK,
                        //  MessageBoxIcon.Information);
                    if (DgvAl.Rows.Count > 0)
                    {
                        PinjamServ p = new PinjamServ();

                        pb.SimpanPeminjam();
                        foreach (DataGridViewRow row in DgvAl.Rows)
                        {
                           
                            string nama_alat = row.Cells[0].Value.ToString();
                            //string jumlah = row.Cells[1].Value.ToString();
                            pb.IdPinjaman = p.PinjamOtomatis();
                            pb.Nama_Alat = nama_alat;
                            //pb.Jumlah = int.Parse(jumlah);
                            pb.SimpanPinjaman();
                        }

                        MessageBox.Show("Data Berhasil di Simpan. ",
                              "Informasi", MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                        BersihPinjam();
                    }
                    else
                    {
                        MessageBox.Show("belum menambahkan pinjaman");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Data gagal di Simpan. ",
                       "Informasi", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
            }          
        }

       // private string pinjamotomatis()
       // {
         //   throw new NotImplementedException();
        //}
        
        //bagian anggota
        void Bersihkan()
        {
            AnggotaServ das = new AnggotaServ();
            TxtId.Text = das.IDAnggotaOtomatis();

            TxtNis.Text = "";
            TxtNama.Text = "";
            RB_L.Checked = false;
            RB_P.Checked = false;
            CmbKelas.Text = "---Pilih---";
            CmbJurusan.Text = "---Pilih Kelas Dulu ---";
            TxtHP.Text = "";
            TxtAlamat.Text = "";
            TxtNis.Focus();
        }
        //bagian anggota
        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            AnggotaServ ag = new AnggotaServ();

            if (string.IsNullOrEmpty(TxtId.Text) || string.IsNullOrEmpty(TxtNis.Text)
                || string.IsNullOrEmpty(TxtNama.Text) || string.IsNullOrEmpty(RB_L.Text)
                || string.IsNullOrEmpty(RB_P.Text) || string.IsNullOrEmpty(CmbKelas.Text)
                || string.IsNullOrEmpty(CmbJurusan.Text) || string.IsNullOrEmpty(TxtHP.Text)
                || string.IsNullOrEmpty(TxtAlamat.Text))
            {
                MessageBox.Show("Mohon data di isi semua \nTidak boleh ada yang kosong",
                    "Informasi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Bersihkan();
            }

            else
            {
                ag.ID_Anggota = TxtId.Text.Trim();
                ag.Nis = TxtNis.Text.Trim();
                ag.Nama = TxtNama.Text.Trim();

                if (RB_L.Checked == true)
                {
                    ag.Jenis_Kelamin = "Laki-laki";
                }
                else if (RB_P.Checked == true)
                {
                    ag.Jenis_Kelamin = "Perempuan";
                }
                ag.Kelas = CmbKelas.Text.Trim();
                ag.Jurusan = CmbJurusan.Text.Trim();
                ag.No_Hp =  TxtHP.Text.Trim();
                ag.Alamat = TxtAlamat.Text.Trim();
                ag.Simpan_Anggota();
                MessageBox.Show("Data berhasil di simpan.",
                    "Informasi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Bersihkan();
            }

}
        //bagian anggota
        private void BtnAnggota_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = (tabPage2);
            Bersihkan();

        }
        //bagian menu
        private void BtnLainnya_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = (tabPage6);
        }

        private void BtnManagerLogin_Click(object sender, EventArgs e)
        {
            AmbilForm(new ManagerLogin());
        }

        private void BtnLihatAlat_Click(object sender, EventArgs e)
        {
            AmbilForm(new Alat());
        }

        private void BtnLihatAnggota_Click(object sender, EventArgs e)
        {
           AmbilForm(new Anggota());
       
        }
        //bagian anggota
        private void CmbKelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string jur = CmbKelas.SelectedItem.ToString();
            if (CmbKelas.SelectedItem == "TKR-1" || CmbKelas.SelectedItem == "TKR-2" || CmbKelas.SelectedItem == "TKR-3" || CmbKelas.SelectedItem == "TKR-4" || CmbKelas.SelectedItem == "TKR-5")
            {
                CmbJurusan.Text = "Teknik Kendaraan Ringan";

            }

            else if (CmbKelas.SelectedItem == "TKJ-1" || CmbKelas.SelectedItem == "TKJ-2" || CmbKelas.SelectedItem == "TKJ-3" || CmbKelas.SelectedItem == "TKJ-4" || CmbKelas.SelectedItem == "TKJ-5")
            {
                CmbJurusan.Text = "Teknik Komputer Jaringan";
            }

            else if (CmbKelas.SelectedItem == "AK-1" || CmbKelas.SelectedItem == "AK-2" || CmbKelas.SelectedItem == "AK-3" || CmbKelas.SelectedItem == "AK-4" || CmbKelas.SelectedItem == "AK-5")
            {
                CmbJurusan.Text = "Akutansi";
            }
            else if (CmbKelas.SelectedItem == "PBS-1" || CmbKelas.SelectedItem == "PBS-2" || CmbKelas.SelectedItem == "PBS-3" || CmbKelas.SelectedItem == "PBS-4" || CmbKelas.SelectedItem == "PBS-5")
            {
                CmbJurusan.Text = "Perbankan Syariah";
            }
        }

        private void panelanggota_Paint(object sender, PaintEventArgs e)
        {

        }
        //bagian anggota
        private void BtnBersih_Click(object sender, EventArgs e)
        {
            Bersihkan();
        }

        //menu keluar aplikasi
        LoginServ logout = new LoginServ();
        private void btnKeluarAplikasi_Click(object sender, EventArgs e)
        {
            logout.Ubah(username, "Tidak Login");
            if (MessageBox.Show("Apakah anda akan keluar ? ",
                "peringatan ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        //menu
        private void BtnAlat_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = (tabPage3);
            AlatServ alat = new AlatServ();
            dgvAlat.DataSource = alat.CekAlat(TxtCariAlat.Text);


        }
        //button pinjam alat
        private void BtnPinjamAlat_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = (tabPage4);
            PinjamServ pb = new PinjamServ();
            TxtIdPeminjaman.Text = pb.KDPinjamOtomatis();
            //PinjamServ pb = new PinjamServ();
           //TxtP.Text = pb.PinjamOtomatis();
            //int numRows = DgvAl.Rows.Count;
            //TxtJumlah.Text = numRows.ToString();
        }
        //pengembalian alat
        private void BtnKembaliAlat_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = (tabPage5);
            PinjamServ pjm = new PinjamServ();
            dgvKembali.DataSource = pjm.TampilSemuaPeminjam();

        }

        //cari alat
        
        private void BtnCariAlat_Click(object sender, EventArgs e)
        {
            AlatServ alat = new AlatServ();
            dgvAlat.DataSource = alat.CariAlat(TxtCariAlat.Text);

        }

       /* String kategori;
        private void CmbCariAlat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = CmbCariAlat.Text;

            switch (x)
            {
                case "Kode Alat":
                    kategori = "kode_alat";
                    break;
                case " Nama Alat":
                    kategori = "nama_alat";
                    break;
                case "Jenis Alat":
                    kategori = "jenis_alat";
                    break;
                case "Letak":
                    kategori = "letak";
                    break;
                case "Tahun Pembelian":
                    kategori = "tahun_pembelian";
                    break;
            }
        }*/
        //cari data alat
        private void TxtCariAlat_TextChanged(object sender, EventArgs e)
        {
            AlatServ alt = new AlatServ();
            dgvAlat.DataSource = alt.CariAlat(TxtCariAlat.Text).DefaultView;
            
        }
        void BersihkanAlat()
        {
            //CmbCariAlat.Text = "------Pilih------";
            TxtCariAlat.Text = "";
        }

        private void CariAlat_Click(object sender, EventArgs e)
        {
            GrpAlat.Visible = true;
            AlatServ alt = new AlatServ();
            dgvNamaAlat.DataSource = alt.CariAlat(TxtCariAl.Text);
          
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
        //peminjaman alat
        private void TxtCariAl_TextChanged(object sender, EventArgs e)
        {
            AlatServ alt = new AlatServ();
            dgvNamaAlat.DataSource = alt.CekAlat(TxtCariAl.Text);
        }

        //peminjaman alat
        private void btnOk_Click(object sender, EventArgs e)
        {
            PinjamServ pb = new PinjamServ();
            int numRows = DgvAl.Rows.Count;
            txtjumlah.Text = numRows.ToString();
            
           // TxtP.Text = pb.PinjamOtomatis();
            if (!string.IsNullOrEmpty(TxtCariAl.Text.Trim()))
            {
                DgvAl.Rows.Add(TxtCariAl.Text);
                GrpAlat.Visible = false;
                TxtCariAl.Clear();
               
            }
            else
            {
                MessageBox.Show("tambahkan");
            }
        }
        //bagian peminjaman
        private void dgvNamaAlat_Click(object sender, EventArgs e)
        {
            if (dgvNamaAlat.SelectedRows.Count > 0)
            {
                string nama = dgvNamaAlat.SelectedRows[0].Cells[0].Value.ToString();
                //string max = dgvNamaAlat.SelectedRows[0].Cells[1].Value.ToString();
              //  string id = dgvNamaAlat.SelectedRows[0].Cells[2].Value.ToString();
                //TxtP.Text = id;
                TxtCariAl.Text = nama;
               // NumJumlahPinjam.Maximum = decimal.Parse(max);
                dgvNamaAlat.ClearSelection();
                //MessageBox.Show(nama);
                //GrpAlat.Visible = false;
                //DgvAl.Rows.Add(nama);
            }
        }
        //ikut peminjaman alat
        private void BtnXTbh_Click(object sender, EventArgs e)
        {
            GrpAlat.Visible = false;
            TxtCariAl.Clear();
           // NumJumlahPinjam.Value = 0;
         
        }

        private void CariIDAg_Click(object sender, EventArgs e)
        {
            grpAnggota.Visible = true;
            AnggotaServ agg = new AnggotaServ();
            dgvanggota.DataSource = agg.CekAnggota(txtanggota.Text);

        }

        private void txtanggota_TextChanged(object sender, EventArgs e)
        {
            grpAnggota.Visible = true;
            AnggotaServ agg = new AnggotaServ();
            dgvanggota.DataSource = agg.CekAnggota(txtanggota.Text);
        }


        /*private void dgvanggota_Click(object sender, EventArgs e)
        {
            if(dgvanggota.SelectedRows.Count > 0)
            {
                string IdAnggota = dgvanggota.SelectedRows[0].Cells[0].Value + string.Empty;
                string NamaAnggota = dgvanggota.SelectedRows[0].Cells[1].Value + string.Empty;

                TxtIdAnggota.Text = IdAnggota;
                TxtNamaAnggota.Text = NamaAnggota;

                grpAnggota.Visible = false;
                }
        }*/
        //ikut bagian peminjaman alat
        private void dgvanggota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvanggota.Rows[e.RowIndex];

                TxtIdAnggota.Text = row.Cells[0].Value.ToString();
                TxtNamaAnggota.Text = row.Cells[1].Value.ToString();

                grpAnggota.Visible = false;
            }
        }

        private void TxtIdPeminjaman_TextChanged(object sender, EventArgs e)
        {

        }
        //bagian peminjaman
        private void TxtJumlah_TextChanged(object sender, EventArgs e)
        {
            //int numRows = DgvAl.Rows.Count;
            //TxtJumlah.Text = numRows.ToString();
        }
        //bagian peminjaman
        private void DgvAl_DoubleClick(object sender, EventArgs e)
        {
            
            foreach (DataGridViewCell oneCell in DgvAl.SelectedCells)
            {
                if (oneCell.Selected)
                    DgvAl.Rows.RemoveAt(oneCell.RowIndex);
            }
        }

        private void DgvAl_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void DgvAl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnDaftarPeminjam_Click(object sender, EventArgs e)
        {
            AmbilForm(new Peminjam());
        }

        private void BtnBatal_Click(object sender, EventArgs e)
        {
            BersihPinjam();
        }
        //ikut kembali
        private void TxtCariKodePinjam_TextChanged(object sender, EventArgs e)
        {
            PinjamServ pjm = new PinjamServ();
            dgvKembali.DataSource =pjm.CekP(TxtCariKodePinjam.Text);
        }
        //ikut kembali
        private void dgvKembali_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvKembali.Rows[e.RowIndex];

                TxtIdP.Text = row.Cells[0].Value.ToString();
                TxtIDA.Text = row.Cells[1].Value.ToString();
                TxtNamaKembali.Text = row.Cells[2].Value.ToString();
                DTPPJalat.Text = row.Cells[3].Value.ToString();

                //grpAnggota.Visible = false;
            }
        }
        //ikut pengembalian alat
        private void TxtIdP_TextChanged(object sender, EventArgs e)
        {
            PinjamServ pjm = new PinjamServ();
            DgvKNamaAlat.DataSource = pjm.TampilPinjaman(TxtIdP.Text);
        }
        //ikut pengembalian
        private void BtnSimpanKembali_Click(object sender, EventArgs e)
        {


        }

        private void dgvanggota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            int numRows = DgvAl.Rows.Count;
            txtjumlah.Text = numRows.ToString();
            // int sum = 0;
            //for (int i = 0; i < DgvAl.Rows.Count; ++i)
            //{
            //  sum += Convert.ToInt32(DgvAl.Rows[i].Cells[1].Value);
            //}
            //TxtJumlah.Text = sum.ToString();

        }
    }
}
