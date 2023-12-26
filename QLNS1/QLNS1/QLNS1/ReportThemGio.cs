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
    public partial class ReportThemGio : Form
    {
        BUS_ReportChamCong busRPChamCong = new BUS_ReportChamCong();
        public ReportThemGio()
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
            List<DTO_RPTangCa> lst = new List<DTO_RPTangCa>();
            lst.Clear();

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                lst.Add(new DTO_RPTangCa
                (
                    int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()),
                    dataGridView1.Rows[i].Cells[1].Value.ToString(),
                    dataGridView1.Rows[i].Cells[2].Value.ToString(),
                    dataGridView1.Rows[i].Cells[3].Value.ToString(),
                    dataGridView1.Rows[i].Cells[4].Value.ToString(),
                    dataGridView1.Rows[i].Cells[5].Value.ToString(),
                    dataGridView1.Rows[i].Cells[6].Value.ToString(),
                    dataGridView1.Rows[i].Cells[7].Value.ToString(),
                    dataGridView1.Rows[i].Cells[8].Value.ToString(),
                    dataGridView1.Rows[i].Cells[9].Value.ToString(),
                    dataGridView1.Rows[i].Cells[10].Value.ToString()

                ));
            }
            ReportDataSource rds = new ReportDataSource("DataSetThemGio", lst);
            ViewRPThemGio frm = new ViewRPThemGio(rds);
            frm.Show();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busRPChamCong.GetThemGio(dateTungay.Text, datedenngay.Text);
        }

        private void ReportThemGioo_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
