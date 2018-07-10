using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using peminjaman.Service;
namespace peminjaman.View
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        //Mengaktifkan Timer
        private void Welcome_Load(object sender, EventArgs e)
        {

            TimerWelcome.Enabled = true;
        }

        //Mengaktifkan Progres Bar
        private void TimerWelcome_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                TimerWelcome.Enabled = false;
                Menu login = new Menu();
                login.Show();
                Hide();
            }
            else
            {
                progressBar1.Value = progressBar1.Value + 10;
            }
        
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
