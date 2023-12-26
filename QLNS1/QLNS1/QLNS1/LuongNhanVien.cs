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
using System.Text.RegularExpressions;


namespace QLNS1
{
    public partial class LuongNhanVien : Form
    {
        BUS_Luong busLuong = new BUS_Luong();
        public LuongNhanVien()
        {
            InitializeComponent();
        }

        private void LuongNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.dataSet.NHANVIEN);
            dataGridView1.DataSource = busLuong.GetAllLuong();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            // Kiểm Tra Lương CB Phải là số
            float tienLuongCB;
            if (txtLuongCb.Text.Length == 0)
            {
                tienLuongCB = 0;
            }
            else if (!IsNumber(txtLuongCb.Text))
            {
                MessageBox.Show("Lương Cơ Bản Không Hợp Lệ !!!", "Thông báo !!");
                txtLuongCb.Clear();
                return;
            }
            else
            {
                tienLuongCB = float.Parse(txtLuongCb.Text);
            }
            // kiểm tra lương cb đã được nhập chưa
            if (txtLuongCb.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập lương !!!", "Thông báo !!");
            }
            else
            {
                if (busLuong.UpdateLuong(float.Parse(txtLuongCb.Text), cbmanv.Text))
                {
                    MessageBox.Show("Cập nhật Lương thành công", "Thông báo !!");
                }
                else
                {
                    MessageBox.Show("Cập nhật Lương thất bại", "Thông báo !!");
                }
                // show dữ liệu lên dgv khi load form
                dataGridView1.DataSource = busLuong.GetAllLuong();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            cbmanv.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbTennhanvien.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLuongCb.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbVitri.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[0-9]\d*\.?[0]*$");
            return regex.IsMatch(pText);
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
    }
}
