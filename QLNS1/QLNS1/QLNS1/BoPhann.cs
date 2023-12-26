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
using BUS;
using DTO;

namespace QLNS1
{
   
    public partial class BoPhann : Form
    {
        BUS_BoPhan busBoPhan = new BUS_BoPhan();
        public BoPhann()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtMBP_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void dtNgayTl_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            txtMBP.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttenBP.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtNgayTl.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtghichu.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            ////////////-- Xử lý kiểm tra điều kiện phải nhập đủ thông tin của Bộ Phận
            if (txtMBP.Text == "")// chưa nhập dữ liệu
            {
                MessageBox.Show("Chưa nhập mã Bộ Phận");
                txtMBP.Focus();// Đưa con trỏ chuột vào chỗ nhập mã bộ phận
                return;//Không thực hiện các lệnh sau return nếu chưa nhập mã
            }
            if (txttenBP.Text == "")// chưa nhập dữ liệu
            {
                MessageBox.Show("Chưa nhập tên Bộ Phận");
                txttenBP.Focus();// Đưa con trỏ chuột vào chỗ nhập tên bộ phận
                return;//Không thực hiện các lệnh sau return nếu chưa nhập mã
            }
            /////////////////////////////////////////////////////////////
            ///

            if (busBoPhan.CheckMaBoPhan(txtMBP.Text))  // Kiểm tra tồn tại mã bộ phận trong bảng Bộ phận
            {
                MessageBox.Show("Mã bộ phận đã tồn tại");
            }
            else
            {
                // Thêm data vào DTO_BoPhan
                DTO_BoPhan bp = new DTO_BoPhan(txtMBP.Text, txttenBP.Text, dtNgayTl.Value.ToString("MM/dd/yyyy"), txtghichu.Text);
                if (busBoPhan.InsertBoPhan(bp)) // Thêm dữ liệu vào table BoPhan với DTO_BoPhan truyền vào
                {
                    MessageBox.Show("Thêm bộ phận thành công");
                }
                else
                {
                    MessageBox.Show("Thêm bộ phận thất bại");
                }
                // Show dữ liệu lên dataGridView
                dataGridView1.DataSource = busBoPhan.GetAllBoPhan();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (!busBoPhan.CheckMaBoPhan(txtMBP.Text))  // Kiểm tra tồn tại mã bộ phận trong bảng Bộ phận
            {
                MessageBox.Show("Mã bộ phận không tồn tại");
            }
            else
            {
                if (busBoPhan.DeleteBoPhan(txtMBP.Text)) // Xóa dữ liệu vào table BoPhan với Mã BP truyền vào
                {
                    MessageBox.Show("Xóa tài Bộ Phận thành công");
                }
                else
                {
                    MessageBox.Show("Xóa Bộ Phận thất bại");
                }
                // show dữ liệu lên dgv khi load form
                dataGridView1.DataSource = busBoPhan.GetAllBoPhan();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!busBoPhan.CheckMaBoPhan(txtMBP.Text))  // Kiểm tra tồn tại mã bộ phận trong bảng Bộ phận
            {
                MessageBox.Show("Mã bộ phận không tồn tại");
            }
            else
            {
                // Thêm data vào DTO_BoPhan
                DTO_BoPhan bp = new DTO_BoPhan(txtMBP.Text, txttenBP.Text, dtNgayTl.Value.ToString("MM/dd/yyyy"), txtghichu.Text);
                if (busBoPhan.UpdateBoPhan(bp)) // Sửa dữ liệu vào table BoPhan với DTO_BoPhan truyền vào
                {
                    MessageBox.Show("Cập nhật Bộ Phận thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật Bộ Phận thất bại");
                }
                // show dữ liệu lên dgv khi load form
                dataGridView1.DataSource = busBoPhan.GetAllBoPhan();

            
        }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BoPhann_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busBoPhan.GetAllBoPhan();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
               ("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
