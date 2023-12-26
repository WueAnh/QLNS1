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
using DTO;
using BUS;

namespace QLNS1
{
    public partial class ViewRPHopDong : Form
    {
        BUS_ReportNhanVien busRPHopDong = new BUS_ReportNhanVien();
        private ReportDataSource rds;
        public ViewRPHopDong(ReportDataSource rds)
        {
            RDS = rds;
            InitializeComponent();
        }
        ReportDataSource RDS
        {
            get { return rds; }
            set { rds = value; }
        }


        private void ViewRPHopDong_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(RDS);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();



        }
    }
}
