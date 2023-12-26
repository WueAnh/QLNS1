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
    public partial class ReportChamCongChiTiet : Form
    {
        BUS_ReportChamCong busrpchamcong = new BUS_ReportChamCong();
        public ReportChamCongChiTiet()
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

        private void btnLoc_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busrpchamcong.GetFindTenNV(cbMaNV.Text, cbTenNV.Text, dateNgayBatDau.Text, dateNgayKetThuc.Text);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            List<DTO_ChamCong> lst = new List<DTO_ChamCong>();
            lst.Clear();

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                lst.Add(new DTO_ChamCong
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
                    dataGridView1.Rows[i].Cells[9].Value.ToString()
                ));
            }
            ReportDataSource rds = new ReportDataSource("DataSetChamCongCT", lst);
            ViewRPChamCongCT frm = new ViewRPChamCongCT(rds);
            frm.Show();
        }

        private void ReportChamCongChiTiet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.dataSet.NHANVIEN);

        }
    }
}
