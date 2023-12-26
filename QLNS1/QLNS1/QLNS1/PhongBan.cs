using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using BUS;
namespace QLNS1
{
    public partial class PhongBan : Form
    {
        BUS_PhongBan bus_PhongBan = new BUS_PhongBan();
        public PhongBan()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            txtmapb.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbmabp.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbtenbp.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txttenpb.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void PhongBann_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.BoPhan' table. You can move, or remove it, as needed.
            this.boPhanTableAdapter.Fill(this.dataSet.BOPHAN);
            dataGridView1.DataSource = BUS_PhongBan.GetAllPhongBan();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            ////////////-- Xử lý kiểm tra điều kiện phải nhập đủ thông tin của Phòng Ban
            if (txtmapb.Text == "")// chưa nhập dữ liệu
            {
                MessageBox.Show("Chưa nhập mã Phòng Ban", "Thông báo !!");
                txtmapb.Focus();// Đưa con trỏ chuột vào chỗ nhập mã Phòng Ban
                return;//Không thực hiện các lệnh sau return nếu chưa nhập mã
            }
            if (txttenpb.Text == "")// chưa nhập dữ liệu
            {
                MessageBox.Show("Chưa nhập tên Phòng Ban", "Thông báo !!");
                txttenpb.Focus();// Đưa con trỏ chuột vào chỗ nhập mã Phòng Ban
                return;//Không thực hiện các lệnh sau return nếu chưa nhập mã
            }
            if (txtDiaChi.Text == "")// chưa nhập dữ liệu
            {
                MessageBox.Show("Chưa nhập địa chỉ", "Thông báo !!");
                txtDiaChi.Focus();// Đưa con trỏ chuột vào chỗ nhập địa chỉ
                return;//Không thực hiện các lệnh sau return nếu chưa địa chỉ
            }



            // Kiểm tra tồn tại mã bộ phận trong bảng Bộ phận
            if (bus_PhongBan.CheckMaPhongBan(txtmapb.Text))
            {
                MessageBox.Show("Mã bộ phận đã tồn tại", "Thông báo !!");
            }
            else
            {
                // Thêm data vào DTO_PhongBan
                DTO_PhongBan pb = new DTO_PhongBan(txtmapb.Text, cbmabp.Text, cbtenbp.Text, txttenpb.Text, txtDiaChi.Text);
                if (bus_PhongBan.InsertPhongBan(pb))
                {
                    MessageBox.Show("Thêm Phòng Ban thành công", "Thông báo !!");
                }
                else
                {
                    MessageBox.Show("Thêm Phong Ban thất bại", "Thông báo !!");
                }
                dataGridView1.DataSource = BUS_PhongBan.GetAllPhongBan();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra tồn tại mã bộ phận trong bảng Bộ phận
            if (!bus_PhongBan.CheckMaPhongBan(txtmapb.Text))
            {
                MessageBox.Show("Mã bộ phận không tồn tại", "Thông báo !!");
            }
            else
            {

                if (bus_PhongBan.DeletePhongBan(txtmapb.Text))
                {
                    MessageBox.Show("Xóa Phòng Ban thành công", "Thông báo !!");
                }
                else
                {
                    MessageBox.Show("Xóa Phòng Ban thất bại", "Thông báo !!");
                }
                dataGridView1.DataSource = BUS_PhongBan.GetAllPhongBan();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (!bus_PhongBan.CheckMaPhongBan(txtmapb.Text))
            {
                MessageBox.Show("Mã bộ phận không tồn tại", "Thông báo !!");
            }
            else
            {
                DTO_PhongBan pb = new DTO_PhongBan(txtmapb.Text, cbmabp.Text, cbtenbp.Text, txttenpb.Text, txtDiaChi.Text);
                if (bus_PhongBan.UpdatePhongBan(pb))
                {
                    MessageBox.Show("Cập nhật Phòng Ban thành công", "Thông báo !!");
                }
                else
                {
                    MessageBox.Show("Cập nhật Phòng Ban thất bại", "Thông báo !!");
                }
                dataGridView1.DataSource = BUS_PhongBan.GetAllPhongBan();
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
               ("Bạn có chắc muốn thoát không?", "Thong Bao !!", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void boPhanBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtmapb_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbmabp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbtenbp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txttenpb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnTrangChu_Click(object sender, EventArgs e)
        {

        }
    }
}
