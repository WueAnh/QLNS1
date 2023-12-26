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
using Microsoft.Reporting.WinForms;

namespace QLNS1
{
    public partial class ViewRPDSKhenThuong : Form
    {
        BUS_ReportNhanVien busRPNhanVien = new BUS_ReportNhanVien();
        public ViewRPDSKhenThuong()
        {
            InitializeComponent();
        }

        private void ReportDSKhenThuong_Load(object sender, EventArgs e)
        {
            List<DTO_KhenThuong> listBH = busRPNhanVien.ListAllDSKhenThuong();
            ReportDataSource rds = new ReportDataSource("DataSetDSKhenThuong", listBH);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
