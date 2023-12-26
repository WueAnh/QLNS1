using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLNS1
{
    public partial class DanhSachKhenThuong : Form
    {
        BUS_KhenThuong busKhenThuong = new BUS_KhenThuong();
        public DanhSachKhenThuong()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            float tienThuong;
            string ngayThuong = DateTime.Parse(dtNgayLP.Text).ToString("MM/dd/yyyy");
            if (txtTien.Text.Length == 0)
            {
                tienThuong = 0;
            }
            else if (!IsNumber(txtTien.Text))
            {
                MessageBox.Show("Tiền thưởng không Phải là số, vui lòng nhập lại!", "Thông báo !!");
                txtTien.Clear();
                return;
            }
            else
            {
                tienThuong = float.Parse(txtTien.Text);
            }

            // gán data cho DTO_KhenThuong
            DTO_KhenThuong kt = new DTO_KhenThuong(txtMaThuong.Text, cbMaNV.Text, cbTenNV.Text, ngayThuong, txtLyDo.Text, txtHinhThuc.Text, tienThuong);
            if (busKhenThuong.InsertKhenThuong(kt))
            {
                MessageBox.Show("Thêm thành công", "Thông báo !!");
            }
            else
                MessageBox.Show("Thêm thất bại", "Thông báo !!");

            dataGridView1.DataSource = busKhenThuong.GetData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!busKhenThuong.CheckMaThuong(txtMaThuong.Text))
            {
                MessageBox.Show("Mã thưởng không tồn tại, vui lòng click vào danh sách mới có thể để xóa!", "Thông báo !!");
                return;
            }
            if (busKhenThuong.DeleteKhenThuong(txtMaThuong.Text))
            {
                MessageBox.Show("Xóa thành công", "Thông báo !!");
            }
            else
                MessageBox.Show("Xóa thất bại", "Thông báo !!");

            dataGridView1.DataSource = busKhenThuong.GetData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!busKhenThuong.CheckMaThuong(txtMaThuong.Text))
            {
                MessageBox.Show("Mã thưởng không tồn tại, vui lòng click vào danh sách mới có thể để sửa!", "Thông báo !!");
                return;
            }
            string ngayThuong = DateTime.Parse(dtNgayLP.Text).ToString("MM/dd/yyyy");
            float tienThuong;
            if (txtTien.Text.Length == 0)
            {
                tienThuong = 0;
            }
            else if (!IsNumber(txtTien.Text))
            {
                MessageBox.Show("Tiền thưởng không Phải là số, vui lòng nhập lại!", "Thông báo !!");
                txtTien.Clear();
                return;
            }
            else
            {
                tienThuong = float.Parse(txtTien.Text);
            }
            // gán data cho DTO_KhenThuong
            DTO_KhenThuong kt = new DTO_KhenThuong(txtMaThuong.Text, cbMaNV.Text, cbTenNV.Text, ngayThuong, txtLyDo.Text, txtHinhThuc.Text, tienThuong);
            if (busKhenThuong.UpdateKhenThuong(kt))
            {
                MessageBox.Show("Sửa thành công", "Thông báo !!");
            }
            else
                MessageBox.Show("Sửa thất bại", "Thông báo !!");

            dataGridView1.DataSource = busKhenThuong.GetData();
        }

        private void BtnTrangChu_Click(object sender, EventArgs e)
        {

        }

        private void DanhSachKhenThuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.dataSet.NHANVIEN);
            // TODO: This line of code loads data into the 'dataSet.NhanVien' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'dataSetBoPhanToPhongBang.NhanVien' table. You can move, or remove it, as needed.
           
            dataGridView1.DataSource = busKhenThuong.GetData();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            txtMaThuong.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbMaNV.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbTenNV.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtNgayLP.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtLyDo.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtHinhThuc.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtTien.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            dataGridView1_CellContentClick(sender, e);
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[0-9]\d*\.?[0]*$");
            return regex.IsMatch(pText);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
               ("Bạn có chắc muốn thoát không?", "Thông báo !!", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }
    }
}
