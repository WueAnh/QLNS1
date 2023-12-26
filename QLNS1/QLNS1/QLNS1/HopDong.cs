using BUS;
using DTO;
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
    public partial class HopDong : Form
    {
        BUS_HopDong busHopDong = new BUS_HopDong();
        public HopDong()
        {
            InitializeComponent();
        }

        private void HopDongg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.PhongBan' table. You can move, or remove it, as needed.
            this.phongBanTableAdapter.Fill(this.dataSet.PHONGBAN);
            // TODO: This line of code loads data into the 'dataSet.BoPhan' table. You can move, or remove it, as needed.
            this.boPhanTableAdapter.Fill(this.dataSet.BOPHAN);
            // TODO: This line of code loads data into the 'dataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.dataSet.NHANVIEN);
            dataGridView1.DataSource = busHopDong.GetAllHopDong();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            txtMaHD.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbMaNV.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbTenNV.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbMaBP.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbTenBP.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbMaPhong.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbTenPhong.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtLoaiHD.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            dtNgayBD.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            dtNgayKT.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (busHopDong.CheckMaHopDong(txtMaHD.Text))  // Kiểm tra tồn tại mã bộ phận trong bảng Bộ phận
            {
                MessageBox.Show("Mã bộ phận đã tồn tại", "Thông báo !!");
            }
            else
            {
                // Thêm data vào DTO_HopDong
                DTO_HopDong hd = new DTO_HopDong(txtMaHD.Text, cbMaNV.Text, cbTenNV.Text, cbMaBP.Text, cbTenBP.Text, cbMaPhong.Text, cbTenPhong.Text, txtLoaiHD.Text, dtNgayBD.Value.ToString("MM/dd/yyyy"), dtNgayKT.Value.ToString("MM/dd/yyyy"));
                if (busHopDong.InsertHopDong(hd)) // Thêm dữ liệu vào table Hợp đồng với DTO_HopDong truyền vào 
                {
                    MessageBox.Show("Thêm hợp đồng thành công", "Thông báo !!");
                }
                else
                {
                    MessageBox.Show("Thêm hợp đồng thất bại", "Thông báo !!");
                }
                // Show dữ liệu lên dataGridView
                dataGridView1.DataSource = busHopDong.GetAllHopDong();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!busHopDong.CheckMaHopDong(txtMaHD.Text))  // Kiểm tra tồn tại mã bộ phận trong bảng Bộ phận
            {
                MessageBox.Show("Mã hợp đồng không tồn tại", "Thông báo !!");
            }
            else
            {
                if (busHopDong.DeleteHopDong(txtMaHD.Text)) // Xóa dữ liệu vào table BoPhan với Mã BP truyền vào
                {
                    MessageBox.Show("Xóa hợp đồng thành công", "Thông báo !!");
                }
                else
                {
                    MessageBox.Show("Xóa hợp đồng thất bại", "Thông báo !!");
                }
                // show dữ liệu lên dgv khi load form
                dataGridView1.DataSource = busHopDong.GetAllHopDong();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!busHopDong.CheckMaHopDong(txtMaHD.Text))  // Kiểm tra tồn tại mã bộ phận trong bảng Bộ phận
            {
                MessageBox.Show("Mã hợp đồng không tồn tại", "Thông báo !!");
            }
            else
            {
                // Thêm data vào DTO_BoPhan
                DTO_HopDong hd = new DTO_HopDong(txtMaHD.Text, cbMaNV.Text, cbTenNV.Text, cbMaBP.Text, cbTenBP.Text, cbMaPhong.Text, cbTenPhong.Text, txtLoaiHD.Text, dtNgayBD.Value.ToString("MM/dd/yyyy"), dtNgayKT.Value.ToString("MM/dd/yyyy"));
                if (busHopDong.UpdateHopDong(hd)) // Sửa dữ liệu vào table BoPhan với DTO_BoPhan truyền vào
                {
                    MessageBox.Show("Cập nhật hợp đồng thành công", "Thông báo !!");
                }
                else
                {
                    MessageBox.Show("Cập nhật hợp đồng thất bại", "Thông báo !!");
                }
                // show dữ liệu lên dgv khi load form
                dataGridView1.DataSource = busHopDong.GetAllHopDong();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            dataGridView1_CellContentClick(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
               ("Bạn có chắc muốn thoát không?", "Thông báo !!", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
