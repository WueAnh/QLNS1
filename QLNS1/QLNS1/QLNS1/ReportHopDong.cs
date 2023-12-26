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
    public partial class ReportHopDong : Form
    {
        BUS_ReportNhanVien busRPNhanVien = new BUS_ReportNhanVien();
        public ReportHopDong()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
               ("Bạn có chắc muốn thoát không?", "Thông báo !!", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            List<DTO_HopDong> lst = new List<DTO_HopDong>();
            lst.Clear();

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                lst.Add(new DTO_HopDong
                (
                    dataGridView1.Rows[i].Cells[0].Value.ToString(),
                    dataGridView1.Rows[i].Cells[1].Value.ToString(),
                    dataGridView1.Rows[i].Cells[2].Value.ToString(),
                    dataGridView1.Rows[i].Cells[3].Value.ToString(),
                    dataGridView1.Rows[i].Cells[4].Value.ToString(),
                    dataGridView1.Rows[i].Cells[5].Value.ToString(),
                    dataGridView1.Rows[i].Cells[6].Value.ToString(),
                    dataGridView1.Rows[i].Cells[7].Value.ToString(),
                    dataGridView1.Rows[i].Cells[8].Value.ToString(),
                    dataGridView1.Rows[i].Cells[9].Value.ToString()



                ));
            }
            ReportDataSource rds = new ReportDataSource("DataSetHopDong", lst);
            ViewRPHopDong frm = new ViewRPHopDong(rds);
            frm.Show();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busRPNhanVien.GetHopDong(dtNgayBD.Text, dtNgayKT.Text);
        }
    }
}
