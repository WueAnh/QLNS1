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
    public partial class ViewRPDSKyLuat : Form
    {
        BUS_ReportNhanVien busRPKyLuat = new BUS_ReportNhanVien();
        public ViewRPDSKyLuat()
        {
            InitializeComponent();
        }

        private void ViewRPDSKiLuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet.DSKyLuat' table. You can move, or remove it, as needed.
            this.DSKyLuatTableAdapter.Fill(this.DataSet.DSKYLUAT);

            List<DTO_KyLuat> listKL = busRPKyLuat.ListAllDSKyLuat();
            ReportDataSource rds = new ReportDataSource("DataSetDSKyLuat", listKL);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();

        }
    }
}
