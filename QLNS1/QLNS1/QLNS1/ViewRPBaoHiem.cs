using BUS;
using DTO;
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
    public partial class ViewRPBaoHiem : Form
    {
        BUS_BaoHiem busBaoHiem = new BUS_BaoHiem();
        public ViewRPBaoHiem()
        {
            InitializeComponent();
        }
        private void ReportBaoHiem_Load(object sender, EventArgs e)
        {
            List<DTO_BaoHiem> listBH = busBaoHiem.ListAllBaoHiem();
            ReportDataSource rds = new ReportDataSource("DataSetBaoHiem", listBH);
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
