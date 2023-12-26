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
    public partial class DanhSachBaoHiem : Form
    {
        BUS_BaoHiem busBaoHiem = new BUS_BaoHiem();
        public DanhSachBaoHiem()
        {
            InitializeComponent();
        }

        private void DanhSachBaoHiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.dataSet.NHANVIEN);
            // TODO: This line of code loads data into the 'dataSetBoPhanToPhongBang.NhanVien' table. You can move, or remove it, as needed.

            dataGridView1.DataSource = busBaoHiem.GetData();
            cbLoaiBH.SelectedIndex = 0;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            float tienBH;
            if (txtTienBH.Text.Length == 0)
            {
                tienBH = 0;
            }
            else if (!IsNumber(txtTienBH.Text))
            {
                MessageBox.Show("Phí BH không Phải là số, vui lòng nhập lại!", "Thông báo !!");
                txtTienBH.Clear();
                return;
            }
            else
            {
                tienBH = float.Parse(txtTienBH.Text);
            }
            // gán data cho DTO_BaoHiem
            DTO_BaoHiem bh = new DTO_BaoHiem(txtMaBH.Text, cbMaNV.Text, cbTenNV.Text, cbLoaiBH.Text, txtMaTheBH.Text, dtNgayCap.Value.ToString("MM/dd/yyyy"), dtNgayHH.Value.ToString("MM/dd/yyyy"), txtNoiCap.Text, tienBH);
            if (busBaoHiem.CheckBHIsExists(cbMaNV.Text, cbLoaiBH.Text, dtNgayCap.Value.ToString("MM/dd/yyyy"), dtNgayHH.Value))
            {
                MessageBox.Show("Bảo hiểm của bạn đang còn hạn hoặc thông tin không hợp lệ", "Thông báo !!");
                return;
            }

            if (busBaoHiem.InsertBaoHiem(bh))
            {
                MessageBox.Show("Thêm bảo hiểm mới thành công", "Thông báo !!");
            }
            else
                MessageBox.Show("Thêm bảo hiểm thất bại", "Thông báo !!");

            dataGridView1.DataSource = busBaoHiem.GetData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!busBaoHiem.CheckMaBH(txtMaBH.Text))
            {
                MessageBox.Show("Mã bảo hiểm không tồn tại, vui lòng click vào danh sách mới có thể để xóa!", "Thông báo !!");
                return;
            }

            if (busBaoHiem.DeleteBaoHiem(txtMaBH.Text))
            {
                MessageBox.Show("Xóa bảo hiểm mới thành công", "Thông báo !!");
            }
            else
                MessageBox.Show("Xóa bảo hiểm thất bại", "Thông báo !!");

            dataGridView1.DataSource = busBaoHiem.GetData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!busBaoHiem.CheckMaBH(txtMaBH.Text))
            {
                MessageBox.Show("Mã bảo hiểm không tồn tại, vui lòng click vào danh sách mới có thể để sửa!", "Thông báo !!");
                return;
            }
            float tienBH;
            if (txtTienBH.Text.Length == 0)
            {
                tienBH = 0;
            }
            else if (!IsNumber(txtTienBH.Text))
            {
                MessageBox.Show("Phí BH không Phải là số, vui lòng nhập lại!", "Thông báo !!");
                txtTienBH.Clear();
                return;
            }
            else
            {
                tienBH = float.Parse(txtTienBH.Text);
            }

            // gán data cho DTO_BaoHiem
            DTO_BaoHiem bh = new DTO_BaoHiem(txtMaBH.Text, cbMaNV.Text, cbTenNV.Text, cbLoaiBH.Text, txtMaTheBH.Text, dtNgayCap.Value.ToString("MM/dd/yyyy"), dtNgayHH.Value.ToString("MM/dd/yyyy"), txtNoiCap.Text, tienBH);
            if (busBaoHiem.UpdateBaoHiem(bh))
            {
                MessageBox.Show("Sửa bảo hiểm mới thành công", "Thông báo !!");
            }
            else
                MessageBox.Show("Sửa bảo hiểm thất bại", "Thông báo !!");

            dataGridView1.DataSource = busBaoHiem.GetData();
        }

        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[0-9]\d*\.?[0]*$");
            return regex.IsMatch(pText);
        }


        private void cbTenNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            txtMaBH.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbMaNV.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbTenNV.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbLoaiBH.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtMaTheBH.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtNgayCap.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            dtNgayHH.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtNoiCap.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtTienBH.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void txtMaBH_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
               ("Bạn có chắc muốn thoát không?", "Thông báo !!", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            dataGridView1_CellContentClick_1(sender, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
   
}
