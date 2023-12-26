using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DAL;

namespace QLNS1
{
    public partial class loadingForm : Form
    {
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();
        private string userName;
        public loadingForm(string userName)
        {
          
            this.userName = userName;
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 8;
            if(panel2.Width>=610)
            {
                timer1.Stop();
                DTO_Accounts loginAccount = busTaiKhoan.GetAccountByUserName(userName);
                TrangChu s = new TrangChu(loginAccount);
                this.Hide();
                s.Show();
              
            }
        }
    }
}
