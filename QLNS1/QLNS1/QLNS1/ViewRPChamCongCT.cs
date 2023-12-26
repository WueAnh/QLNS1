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

    public partial class ViewRPChamCongCT : Form
    {
        private ReportDataSource rds;
        public ViewRPChamCongCT(ReportDataSource rds)
        {
            RDS = rds;
            InitializeComponent();
        }
        ReportDataSource RDS
        {
            get { return rds; }
            set { rds = value; }
        }
        
        private void ViewRPChamCongCT_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(RDS);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

    }
}
