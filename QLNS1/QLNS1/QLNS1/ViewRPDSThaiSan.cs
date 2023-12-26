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
    public partial class ViewRPDSThaiSan : Form
    {
        BUS_ReportNhanVien busRPThaiSan = new BUS_ReportNhanVien();
        public ViewRPDSThaiSan()
        {
            InitializeComponent();
        }

        private void ViewRPDSThaiSan_Load(object sender, EventArgs e)
        {
            this.DSThaiSanTableAdapter.Fill(this.DataSet.DSTHAISAN);

            List<DTO_ThaiSan> listTS = busRPThaiSan.ListAllDSThaiSan();
            ReportDataSource rds = new ReportDataSource("DataSetDSThaiSan", listTS);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
