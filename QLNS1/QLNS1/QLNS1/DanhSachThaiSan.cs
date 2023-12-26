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
    public partial class DanhSachThaiSan : Form
    {
        BUS_ThaiSan busThaiSan = new BUS_ThaiSan();
        public DanhSachThaiSan()
        {
            InitializeComponent();
        }

        private void DanhSachThaiSan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.dataSet.NHANVIEN);
            dataGridView1.DataSource = busThaiSan.GetData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // gán data cho DTO_ThaiSan
            DTO_ThaiSan ts = new DTO_ThaiSan(txtMaThaiSan.Text, cbMaNV.Text, cbTenNV.Text, dtNgayBD.Value.ToString("MM/dd/yyyy"), dtNgayKT.Value.ToString("MM/dd/yyyy"), txtTrangThai.Text);
            if (busThaiSan.InsertThaiSan(ts))
            {
                MessageBox.Show("Thêm bảo hiểm mới thành công", "Thông báo !!");
            }
            else
                MessageBox.Show("Thêm bảo hiểm thất bại", "Thông báo !!");

            dataGridView1.DataSource = busThaiSan.GetData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (busThaiSan.DeleteThaiSan(txtMaThaiSan.Text))
            {
                MessageBox.Show("Xóa bảo hiểm mới thành công", "Thông báo !!");
            }
            else
                MessageBox.Show("Xóa bảo hiểm thất bại", "Thông báo !!");

            dataGridView1.DataSource = busThaiSan.GetData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // gán data cho DTO_ThaiSan
            DTO_ThaiSan ts = new DTO_ThaiSan(txtMaThaiSan.Text, cbMaNV.Text, cbTenNV.Text, dtNgayBD.Value.ToString("MM/dd/yyyy"), dtNgayKT.Value.ToString("MM/dd/yyyy"), txtTrangThai.Text);
            if (busThaiSan.UpdateThaiSan(ts))
            {
                MessageBox.Show("Sửa bảo hiểm mới thành công", "Thông báo !!");
            }
            else
                MessageBox.Show("Sửa bảo hiểm thất bại", "Thông báo !!");

            dataGridView1.DataSource = busThaiSan.GetData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            txtMaThaiSan.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbMaNV.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbTenNV.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtNgayBD.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtNgayKT.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTrangThai.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
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
