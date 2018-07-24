using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using peminjaman.Services;
using peminjaman.Service;

namespace peminjaman.View
{
    public partial class Hilang : Form
    {
        public Hilang()
        {
            InitializeComponent();
        }

        private void DgvKNamaAlat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Hilang_Load(object sender, EventArgs e)
        {
            KembaliServ km = new KembaliServ();
            dataGridView1.DataSource =km.Hilang();
        }
    }
}
