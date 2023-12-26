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


namespace QLNS1
{
    public partial class ThongTinNhanVien : Form
    {
        private DTO_NhanVien dtoNhanVien;

        public ThongTinNhanVien()
        {
        }

        public ThongTinNhanVien(DTO_NhanVien acc)
        {
            this.DTONhanVien = acc;
            InitializeComponent();
            ChangeAccount();
        }
        public DTO_NhanVien DTONhanVien
        {
            get { return dtoNhanVien; }
            set { dtoNhanVien = value; }
        }
        void ChangeAccount()
        {
            lbMaNV.Text = DTONhanVien.MaNV;
            lbTenNV.Text = DTONhanVien.TenNV;
            lbGioiTinh.Text = DTONhanVien.GioiTinh;
            lbNgaySinh.Text = DTONhanVien.NgaySinh;
            lbTDHV.Text = DTONhanVien.TenTDHV;
            lbQueQuan.Text = DTONhanVien.QueQuan;
            lbSDT.Text = DTONhanVien.SDT;
            lbCMND.Text = DTONhanVien.Cmnd;
            lbEmail.Text = DTONhanVien.Email;
            lbDiaChi.Text = DTONhanVien.DiaChi;
            lbChuyenNganh.Text = DTONhanVien.CNganh;
            lbUserName.Text = DTONhanVien.UserName;
            lbMaPhong.Text = DTONhanVien.MaPhong;
            lbMaBP.Text = DTONhanVien.MaBP;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ThongTinNhanVienn_Load(object sender, EventArgs e)
        {

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
