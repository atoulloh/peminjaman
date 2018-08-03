using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using peminjaman.Services;

namespace peminjaman.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Bak Pake Keys
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnMasuk.PerformClick();
            }

            else if (e.KeyCode == Keys.Escape)
            {
                BtnKeluar.PerformClick();
            }
        }

        //Bak Pake Keys
        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnMasuk.PerformClick();
            }

            else if (e.KeyCode == Keys.Escape)
            {
                BtnKeluar.PerformClick();
            }
        }

        private void Bersihkan()
        {
            TxtID.Text = "";
            TxtPassword.Text = "";
        }
         //Login cek
        LoginServ login = new LoginServ();
        Menu menu = new  Menu ();
        private void BtnMasuk_Click(object sender, EventArgs e)
        {
            string id = TxtID.Text.Trim();
            string pw = TxtPassword.Text.Trim();

            if (login.LoginCek(id, pw) == true)
            {
                string cek = login.CekStat(id).Rows[0][0].ToString();

                menu.username = id;

                if (cek == "Tidak Login")
                {
                    login.Ubah(TxtID.Text, " Sedang Login");
                    menu.Show();
                    Hide();
                }

                else
                {
                    MessageBox.Show("User sedang Login", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("ID atau Password anda salah !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }
        //Batal Login dan keluar
        private void BtnKeluar_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Apakah anda akan keluar ?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //    Application.Exit();
            Bersihkan();
        }

        private void BtnCloseLogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda akan keluar ?",
                "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

       

    }
}
