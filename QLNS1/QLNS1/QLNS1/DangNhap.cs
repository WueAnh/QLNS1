using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using DTO;
using BUS;
using DAL;

namespace QLNS1
{
    public partial class DangNhap : Form
    {
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();
        public DangNhap()
        {
           
            InitializeComponent();
        }
       
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnLogin.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
            txtUser.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                ("Bạn có chắc muốn thoát không?", "Thông báo !!", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            string password = txtPass.Text;
            if (busTaiKhoan.Login(userName, password))
            {
                this.Hide();
                loadingForm splashScreen = new loadingForm(userName);
                splashScreen.Show();
            }
           
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                txtUser.Focus();
                txtUser.Clear();
                txtPass.Clear();
            }
           
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            txtUser.BackColor = Color.LightYellow;
            txtUser.BackColor = Color.White;
        }

        private void txtUser_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
