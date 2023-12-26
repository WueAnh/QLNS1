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
    public partial class DanhSachKyLuat : Form
    {
        public DanhSachKyLuat()
        {
            InitializeComponent();
        }
        BUS_KyLuat buskyluat = new BUS_KyLuat();
        private void DanhSachKyLuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.dataSet.NHANVIEN);
            dataGridView1.DataSource = buskyluat.GetData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            txtMaPhat.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbMaNV.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbTenNV.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtNgayLP.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtLyDo.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txthinhThuc.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtTien.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            float tienKyLuat;
            if (txtTien.Text.Length == 0)
            {
                tienKyLuat = 0;
            }
            else if (!IsNumber(txtTien.Text))// check txtTien có phải là số hay không!
            {
                MessageBox.Show("Tiền phạt không Phải là số, vui lòng nhập lại!", "Thông báo !!");
                txtTien.Clear();
                return;
            }
            else
            {
                tienKyLuat = float.Parse(txtTien.Text);
            }
            // Thêm data vào DTO_Kyluat
            DTO_KyLuat kl = new DTO_KyLuat("", cbMaNV.Text, cbTenNV.Text, dtNgayLP.Value.ToString("MM/dd/yyyy"), txtLyDo.Text, txthinhThuc.Text, tienKyLuat);
            if (buskyluat.InsertKyLuat(kl)) // Thêm dữ liệu vào table BoPhan với DTO_BoPhan truyền vào
            {
                MessageBox.Show("Thêm Kỷ Luật thành công", "Thông báo !!");
            }
            else
            {
                MessageBox.Show("Thêm Kỷ Luật thất bại", "Thông báo !!");
            }
            // Show dữ liệu lên dataGridView
            dataGridView1.DataSource = buskyluat.GetData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // check xem MaKyLuat có tồn tại trên sql hay không
            if (!buskyluat.CheckMaKyLuat(txtMaPhat.Text))
            {
                MessageBox.Show("Mã phạt không tồn tại, vui lòng click vào danh sách mới có thể để xóa!", "Thông báo !!");
                return;
            }
            if (buskyluat.DeleteKyLuat(txtMaPhat.Text)) // Xóa dữ liệu vào table BoPhan với Mã BP truyền vào
            {
                MessageBox.Show("Xóa thành công", "Thông báo !!");
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo !!");
            }
            // show dữ liệu lên dgv khi load form
            dataGridView1.DataSource = buskyluat.GetData();
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[0-9]\d*\.?[0]*$");
            return regex.IsMatch(pText);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // check xem MaKyLuat có tồn tại trên sql hay không
            if (!buskyluat.CheckMaKyLuat(txtMaPhat.Text))
            {
                MessageBox.Show("Mã phạt không tồn tại, vui lòng click vào danh sách mới có thể để sửa!", "Thông báo !!");
                return;
            }
            float tienKyLuat;
            if (txtTien.Text.Length == 0)
            {
                tienKyLuat = 0;
            }
            else if (!IsNumber(txtTien.Text)) // check txtTien có phải là số hay không!
            {
                MessageBox.Show("Tiền phạt không Phải là số, vui lòng nhập lại!", "Thông báo !!");
                txtTien.Clear();
                return;
            }
            else
            {
                tienKyLuat = float.Parse(txtTien.Text);
            }
            // Thêm data vào DTO_Kyluat
            DTO_KyLuat kl = new DTO_KyLuat(txtMaPhat.Text, cbMaNV.Text, cbTenNV.Text, dtNgayLP.Value.ToString("MM/dd/yyyy"), txtLyDo.Text, txthinhThuc.Text, tienKyLuat);
            if (buskyluat.UpdateKyLuat(kl)) // Thêm dữ liệu vào table BoPhan với DTO_BoPhan truyền vào
            {
                MessageBox.Show("Sửa Kỷ Luật thành công", "Thông báo !!");
            }
            else
            {
                MessageBox.Show("Sửa kỷ Luật thất bại", "Thông báo !!");
            }
            // Show dữ liệu lên dataGridView
            dataGridView1.DataSource = buskyluat.GetData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                ("Bạn có chắc muốn thoát không?", "Thông báo !!", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void dtNgayLP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            dataGridView1_CellContentClick(sender, e);
        }
    }
}
