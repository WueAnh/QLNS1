using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using Microsoft.Reporting.WinForms;

namespace QLNS1
{
    public partial class RpBoPhan : Form
    {
        BUS_ReportChamCong busrpChamCong = new BUS_ReportChamCong();
        ReportDataSource rs = new ReportDataSource();
        
        public RpBoPhan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RpBoPhan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetBoPhanToPhongBang.BoPhan' table. You can move, or remove it, as needed.
            this.boPhanTableAdapter.Fill(this.dataSetBoPhanToPhongBang.BoPhan);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateNgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busrpChamCong.GetAllChamCong(cbbMaBP.Text, dateNgayBatDau.Text, dateNgayKetThuc.Text);

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            List<DTO_RpChamCong> lst = new List<DTO_RpChamCong>();
            lst.Clear();

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                lst.Add(new DTO_RpChamCong
                {
                    MaNV = dataGridView1.Rows[i].Cells[0].Value.ToString(),
                    MaBP = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                    TenNV = dataGridView1.Rows[i].Cells[2].Value.ToString(),
                    TenBP = dataGridView1.Rows[i].Cells[3].Value.ToString(),
                    NgayCham = dataGridView1.Rows[i].Cells[4].Value.ToString()
                });
            }
            Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", lst);
            ViewChamCong frm = new ViewChamCong();
            //frm.reportViewer1.LocalReport.ReportPath = "ReportChamCong.rdlc";
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rds);
            frm.reportViewer1.LocalReport.Refresh();
            frm.ShowDialog();
        }
    }
}
