using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CrystalDecisions.CrystalReports.Engine;

namespace peminjaman.Reports
{
    public partial class FrmLaporan : Form
    {
        public FrmLaporan()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

           // this.reportViewer1.RefreshReport();
           // this.reportViewer2.RefreshReport();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void CrpPeminjam1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
