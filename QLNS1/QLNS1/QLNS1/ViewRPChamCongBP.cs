using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS1
{
    public partial class ViewRPChamCongBP : Form
    {
        private ReportDataSource rds;
        public ViewRPChamCongBP(ReportDataSource rds)
        {
            RDS = rds;
            InitializeComponent();
        }
        ReportDataSource RDS
        {
            get { return rds; }
            set { rds = value; }
        }

        private void ViewRPChamCongBP_Load(object sender, EventArgs e)
        {
            //frm.reportViewer1.LocalReport.ReportPath = "ReportChamCong.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(RDS);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
