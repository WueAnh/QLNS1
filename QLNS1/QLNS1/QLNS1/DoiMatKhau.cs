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
using DAL;
using BUS;


namespace QLNS1
{
    public partial class DoiMatKhau : Form
    {
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();
        private DTO_Accounts loginAccount;
        public DoiMatKhau(DTO_Accounts acc)
        {
            InitializeComponent();
            LoginAccount = acc;
            ChangeAccount(LoginAccount);
        }
        public DTO_Accounts LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
        void ChangeAccount(DTO_Accounts acc)
        {
            txtUser.Text = acc.UserName;
            txtDisPlayName.Text = acc.DisplayName;
        }
        private event EventHandler<AccountEvent> changeAccount;
        public event EventHandler<AccountEvent> ChangeAccout
        {
            add { changeAccount += value; }
            remove { changeAccount -= value; }
        }
        public class AccountEvent : EventArgs
        {
            private DTO_Accounts acc;
            public DTO_Accounts Acc
            {
                get { return acc; }
                set { acc = value; }
            }
            public AccountEvent(DTO_Accounts acc)
            {
                this.Acc = acc;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ form
            string username = txtUser.Text;
            string displayname = txtDisPlayName.Text;
            string password = txtPass.Text.Trim();
            string newpassword = txtNewPass.Text.Trim();
            string reenterPass = txtReEnterPass.Text.Trim();

            if (!newpassword.Equals(reenterPass))  // check mật khẩu mới có trùng khớp với nhập lại mk hay không!
            {
                MessageBox.Show("Vui lòng nhập lại đúng với mật khẩu mới", "Thông báo !!");
            }
            else
            {
                if (busTaiKhoan.ChangeAccount(username, displayname, password, newpassword))
                {
                    MessageBox.Show("Cập Nhật Thành Công", "Thông báo !!");
                    if (changeAccount != null)
                        changeAccount(this, new AccountEvent(busTaiKhoan.GetAccountByUserName(username)));
                    txtPass.Clear();
                    txtNewPass.Clear();
                    txtReEnterPass.Clear();
                }
                else
                {
                    MessageBox.Show("Vui Lòng điền đúng mật khẩu", "Thông báo !!");
                }
            }
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
               ("Bạn có chắc muốn thoát không?", "Thông báo !!", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }
    }
}
