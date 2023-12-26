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
using Microsoft.Reporting.WinForms;
using BUS;

namespace QLNS1
{
    public partial class ViewRPThamNien : Form
    {
        BUS_ReportNhanVien busRPNhanVien = new BUS_ReportNhanVien();
        public ViewRPThamNien()
        {
            InitializeComponent();
        }

        private void ViewThamNien_Load(object sender, EventArgs e)
        {
            List<DTO_RPThamNien> listTN = busRPNhanVien.ListAllThamNien();
            ReportDataSource rds = new ReportDataSource("DataSetThamNien", listTN);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
