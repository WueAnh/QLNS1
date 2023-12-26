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
    public partial class DangKy : Form
    {
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();
        public DangKy()
        {
            InitializeComponent();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = !txtUserName.Enabled;
            txtDisplayName.Enabled = !txtDisplayName.Enabled;
            cbType.Enabled = !cbType.Enabled;
            btnDeleteAccount.Enabled = !btnDeleteAccount.Enabled;
            btnUpdateAccount.Enabled = !btnUpdateAccount.Enabled;
            btnSaveAccount.Enabled = !btnSaveAccount.Enabled;
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = !txtUserName.Enabled;
            txtDisplayName.Enabled = !txtDisplayName.Enabled;
            cbType.Enabled = !cbType.Enabled;
            btnAddAccount.Enabled = !btnAddAccount.Enabled;
            btnUpdateAccount.Enabled = !btnUpdateAccount.Enabled;
            btnSaveAccount.Enabled = !btnSaveAccount.Enabled;
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = !txtUserName.Enabled;
            txtDisplayName.Enabled = !txtDisplayName.Enabled;
            cbType.Enabled = !cbType.Enabled;
            btnDeleteAccount.Enabled = !btnDeleteAccount.Enabled;
            btnAddAccount.Enabled = !btnAddAccount.Enabled;
            btnSaveAccount.Enabled = !btnSaveAccount.Enabled;
        }

        private void btnSaveAccount_Click(object sender, EventArgs e)
        {
            ////////////-- Xử lý kiểm tra điều kiện phải nhập đủ thông tin của Bộ Phận
            if (txtUserName.Text == "")// chưa nhập dữ liệu
            {
                MessageBox.Show("Chưa nhập User Name");
                txtUserName.Focus();// Đưa con trỏ chuột vào chỗ user name
                return;//Không thực hiện các lệnh sau return nếu chưa nhập mã
            }
            if (txtDisplayName.Text == "")// chưa nhập dữ liệu
            {
                MessageBox.Show("Chưa nhập Display Name");
                txtDisplayName.Focus();// Đưa con trỏ chuột vào chỗ nhập display name
                return;//Không thực hiện các lệnh sau return nếu chưa nhập mã
            }
            // Xử lý khi nút thêm enabled
            if (btnAddAccount.Enabled)
            {
                string username = txtUserName.Text;
                string displayname = txtDisplayName.Text;
                int type = cbType.SelectedIndex;
                if (busTaiKhoan.CheckAccount(txtUserName.Text))  // Kiểm tra tồn tại UserName trong bảng Accounts
                {
                    MessageBox.Show("Tài khoản đã tồn tại","Thông báo !!");
                }
                else
                {
                    // Thêm data vào DTO_Account
                    DTO_Accounts ac = new DTO_Accounts(username, displayname, "", type);
                    if (busTaiKhoan.InsertAccount(ac))
                    {
                        MessageBox.Show("Thêm tài khoản thành công", "Thông báo !!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm tài khoản thất bại", "Thông báo !!");
                    }
                    // show dữ liệu lên dataGridView
                    dataGridView1.DataSource = busTaiKhoan.GetAllAccount();
                }
            }
            // Xử lý khi nút lưu enabled
            else if (btnUpdateAccount.Enabled)
            {
                // Lấy dữ liệu từ form
                string username = txtUserName.Text;
                string displayname = txtDisplayName.Text;
                int type = cbType.SelectedIndex;
                if (!busTaiKhoan.CheckAccount(username))
                {
                    MessageBox.Show("Tài khoản không tồn tại", "Thông báo !!");
                }
                else
                {
                    // Thêm data vào DTO_Accounts
                    DTO_Accounts ac = new DTO_Accounts(username, displayname, "", type);
                    if (busTaiKhoan.UpdateAccount(ac))
                    {
                        MessageBox.Show("Cập nhật tài khoản thành công", "Thông báo !!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật tài khoản thất bại", "Thông báo !!");
                    }
                    // show dữ liệu lên dataGridView
                    dataGridView1.DataSource = busTaiKhoan.GetAllAccount();
                }
            }
            // Xử lý khi nút xóa enabled
            else
            {
                string username = txtUserName.Text;
                if (!busTaiKhoan.CheckAccount(username))
                {
                    MessageBox.Show("Tài khoản không tồn tại", "Thông báo !!");
                }
                else
                {
                    if (busTaiKhoan.DeleteAccount(username))
                    {
                        MessageBox.Show("Xóa tài khoản thành công", "Thông báo !!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa tài khoản thất bại", "Thông báo !!");
                    }
                    // show dữ liệu lên dataGridView
                    dataGridView1.DataSource = busTaiKhoan.GetAllAccount();
                }
            }
            txtUserName.Enabled = !txtUserName.Enabled;
            txtDisplayName.Enabled = !txtDisplayName.Enabled;
            cbType.Enabled = !cbType.Enabled;
            btnAddAccount.Enabled = true;
            btnUpdateAccount.Enabled = true;
            btnDeleteAccount.Enabled = true;
            btnSaveAccount.Enabled = false;
            txtUserName.Clear();
            txtDisplayName.Clear();
        }
        // Xử lý khi click vào datagridview
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            txtUserName.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDisplayName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbType.SelectedIndex = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            dataGridView1.DataSource = busTaiKhoan.GetAllAccount();
        }
        private void DangKyy_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busTaiKhoan.GetAllAccount();
            txtUserName.Enabled = !txtUserName.Enabled;
            txtDisplayName.Enabled = !txtDisplayName.Enabled;
            cbType.Enabled = !cbType.Enabled;
            btnSaveAccount.Enabled = !btnSaveAccount.Enabled; 
            cbType.SelectedIndex = 2;
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

