using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace QLNS1
{
    public partial class TinhLuong : Form
    {
        BUS_TongLuong busTongLuong = new BUS_TongLuong();
        public TinhLuong()
        {
            InitializeComponent();
        }

        private void TinhLuongg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.dataSet.NHANVIEN);
            // TODO: This line of code loads data into the 'dataSet.Luong' table. You can move, or remove it, as needed.
            this.luongTableAdapter.Fill(this.dataSet.LUONG);
            dataGridView2.DataSource = busTongLuong.GetAllTongLuong();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadData();
            if (cbLuongcb.Text == "0")
            {
                MessageBox.Show("Lương Cơ Bản Không Hợp Lệ Vui Lòng Nhập lại", "Thông báo !!");
                return;
            }
            // kiểm tra dữ liệu có đủ hay phù hợp chưa
            if (txtSoNgayLam.Text == "" || cbLuongcb.Text == "")
            {
                MessageBox.Show("Số Ngày Công hoặc Lương Cơ Bản Chưa Có Thông Tin Vui Lòng Bổ Sung Đầy Đủ !!!", "Thông báo !!");
                return;
            }
           
            
                if (txtTienBH.Text == "")
                {
                    txtTienBH.Text = "0";
                }
                if (txtTienThuong.Text == "")
                {
                    txtTienThuong.Text = "0";
                }
                if (txtTienPhat.Text == "")
                {
                    txtTienPhat.Text = "0";
                }

            
        }
        void LoadData()
        {
            // Hiển thị dữ liệu các của bảng liên quan
            DataTable dataTienThuong = busTongLuong.LoadTienThuong(cbMaNV.Text, dataTimeBatdau.Value.ToString("MM/dd/yyyy"), dataTimeKetThuc.Value);
            DataTable dataTienPhat = busTongLuong.LoadTienPhat(cbMaNV.Text, dataTimeBatdau.Value.ToString("MM/dd/yyyy"), dataTimeKetThuc.Value);
            DataTable dataTienBH = busTongLuong.LoadTienBH(cbMaNV.Text);
            DataTable dataNgayLamViec = busTongLuong.LoadNgayLamViec(cbMaNV.Text, dataTimeBatdau.Value.ToString("MM/dd/yyyy"), dataTimeKetThuc.Value);
            if (dataTienThuong.Rows.Count > 0 && dataTienPhat.Rows.Count > 0 && dataTienBH.Rows.Count > 0 && dataNgayLamViec.Rows.Count > 0)
            {
                txtTienThuong.Text = dataTienThuong.Rows[0]["TotalTienThuong"].ToString(); // Assuming "TotalTienThuong" is the column name
                txtTienPhat.Text = dataTienPhat.Rows[0]["TotalTienPhat"].ToString(); // Assuming "TotalTienPhat" is the column name
                txtTienBH.Text = dataTienBH.Rows[0]["TotalPhiBaoHiem"].ToString(); // Assuming "TotalPhiBaoHiem" is the column name
                txtSoNgayLam.Text = dataNgayLamViec.Rows[0]["TotalNgayLamViec"].ToString(); // Assuming "TotalNgayLamViec" is the column name
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đã đủ hay chưa
            if (cbLuongcb.Text == "" || txtTienBH.Text == "" || txtTienThuong.Text == "" || txtTienPhat.Text == "" || txtTongTien.Text == "" || txtSoNgayLam.Text == "")
            {
                MessageBox.Show("Chưa đủ dữ liệu vui lòng bổ sung !!!", "Thông báo !!");
                return;
            }
            // Thêm data vào DTO_TongLuong
            DTO_TongLuong tl = new DTO_TongLuong("", cbMaNV.Text, cbTenNV.Text, dataTimeBatdau.Value.ToString("MM/dd/yyyy"), dataTimeKetThuc.Value.ToString("MM/dd/yyyy"), int.Parse(txtSoNgayLam.Text), float.Parse(cbLuongcb.Text), float.Parse(txtTienBH.Text), float.Parse(txtTienThuong.Text), float.Parse(txtTienPhat.Text), float.Parse(txtTongTien.Text));
            if (busTongLuong.InsertTongLuong(tl)) // Thêm dữ liệu vào table BoPhan với DTO_BoPhan truyền vào
            {
                MessageBox.Show("Đã Lưu Thành Công", "Thông báo !!");
            }
            else
            {
                MessageBox.Show("Đã Lưu Thất Bại !!!", "Thông báo !!");
            }
            // Show dữ liệu lên dataGridView
            dataGridView2.DataSource = busTongLuong.GetAllTongLuong();
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            if (cbLuongcb.Text == "0")
            {
                MessageBox.Show("Lương Cơ Bản Không Hợp Lệ Vui Lòng Nhập lại", "Thông báo !!");
                return;
            }
            // kiểm tra dữ liệu có đủ hay phù hợp chưa
            if (txtSoNgayLam.Text == "" || cbLuongcb.Text == "")
            {
                MessageBox.Show("Số Ngày Công hoặc Lương Cơ Bản Chưa Có Thông Tin Vui Lòng Bổ Sung Đầy Đủ !!!", "Thông báo !!");
                return;
            }
            // Công thức tính toán
            float luongCB = float.Parse(cbLuongcb.Text);
            float tienThuong = float.Parse(txtTienThuong.Text);
            float tienPhat = float.Parse(txtTienPhat.Text);
            float tienBH = float.Parse(txtTienBH.Text);
            int soNgayLam = int.Parse(txtSoNgayLam.Text);
            float tongTien = (luongCB / 26) * soNgayLam + tienThuong - tienPhat + tienBH;
            txtTongTien.Text = tongTien.ToString();

        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLuongcb.Text = "";
            txtTienThuong.Text = "";
            txtTienPhat.Text = "";
            txtTienBH.Text = "";
            txtSoNgayLam.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                ("Bạn có chắc muốn thoát không?", "Thông báo !!", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

