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
using static QLNS1.DoiMatKhau;
namespace QLNS1
{
    public partial class TrangChu : Form
    {
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        private DTO_Accounts loginAccount;
        public TrangChu(DTO_Accounts acc)
        {
            this.LoginAccount = acc;
            InitializeComponent();
            ChangeAccount1(LoginAccount.Type);
            
        }
        public DTO_Accounts LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }

        ///phân quyền nó nằm ở đây 
        void ChangeAccount1(int type)
        {
            AdminTool.Enabled = type == 0;
            QuanLyItem.Enabled = type == 1 || type == 0;
            CheDoItem.Enabled = type == 1 || type == 0;
            thongTinCaNhanMenuItem.Enabled = type == 1 || type == 2;
            btnChamCong.Enabled = type == 1 || type == 2;
            ThongTinItem.Text += $" ({LoginAccount.DisplayName})";
        }

        // cập nhật displayname trên hệ thống
        void dk_ChangeAccount(object sender, AccountEvent e)
        {
            ThongTinItem.Text = "Thông Tin Tài Khoản (" + e.Acc.DisplayName + ")";
        }

        private void nhanSuMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien fdm = new NhanVien(loginAccount);
            panel_show.Show();
            panel_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fdm);
            fdm.Show();

        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.WindowState = FormWindowState.Maximized;
            if (LoginAccount.Type == 0)
            {
                return;
            }
            if (!busNhanVien.CheckMaNVByUserName(LoginAccount.UserName))
            {
                MessageBox.Show("Thông tin nhân viên của bạn không tồn tại, vui lòng liên hệ quản lý cập nhật thông tin để sử dụng ứng dụng!", "Thông báo !!");
                this.Close();
                DangNhap dn = new DangNhap();
                dn.Show();
            }
        }

        private void qlTaiKhoanMenuItem_Click(object sender, EventArgs e)
        {
            DangKy fdm = new DangKy();
            panel_show.Show();
            panel_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void thongTinCaNhanMenuItem_Click(object sender, EventArgs e)
        {
            DTO_NhanVien nhanVienDTO = busNhanVien.GetNhanVienByUserName(LoginAccount.UserName);
            ThongTinNhanVien fttnv = new ThongTinNhanVien(nhanVienDTO);
            panel_show.Show();
            panel_show.Controls.Clear();
            fttnv.TopLevel = false;
            fttnv.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fttnv);
            fttnv.Show();
        }

        private void thayDoiThongTinMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau dk = new DoiMatKhau(LoginAccount);
            panel_show.Show();
            panel_show.Controls.Clear();
            dk.TopLevel = false;
            dk.Dock = DockStyle.Fill;
            panel_show.Controls.Add(dk);
            dk.Show();
            dk.ChangeAccout += dk_ChangeAccount;
        }


        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            ViewRPBaoHiem frpBH = new ViewRPBaoHiem();
            panel_show.Show();
            panel_show.Controls.Clear();
            frpBH.TopLevel = false;
            frpBH.Dock = DockStyle.Fill;
            panel_show.Controls.Add(frpBH);
            frpBH.Show();
        }

        private void ribbonButton14_Click(object sender, EventArgs e)
        {
            ViewRPDSKhenThuong frdskhenThuong = new ViewRPDSKhenThuong();
            panel_show.Show();
            panel_show.Controls.Clear();
            frdskhenThuong.TopLevel = false;
            frdskhenThuong.Dock = DockStyle.Fill;
            panel_show.Controls.Add(frdskhenThuong);
            frdskhenThuong.Show();
        }

        private void ribbonButton15_Click(object sender, EventArgs e)
        {
            ReportChamCongBoPhan frpBH = new ReportChamCongBoPhan();
            panel_show.Show();
            panel_show.Controls.Clear();
            frpBH.TopLevel = false;
            frpBH.Dock = DockStyle.Fill;
            panel_show.Controls.Add(frpBH);
            frpBH.Show();
        }

        private void ribbonButton16_Click(object sender, EventArgs e)
        {

            ReportChamCongChiTiet rpccct = new ReportChamCongChiTiet();
            panel_show.Show();
            panel_show.Controls.Clear();
            rpccct.TopLevel = false;
            rpccct.Dock = DockStyle.Fill;
            panel_show.Controls.Add(rpccct);
            rpccct.Show();
        }

        private void ribbonButton17_Click(object sender, EventArgs e)
        {
            ReportNhanVienBP rpnvbbp = new ReportNhanVienBP();
            panel_show.Show();
            panel_show.Controls.Clear();
            rpnvbbp.TopLevel = false;
            rpnvbbp.Dock = DockStyle.Fill;
            panel_show.Controls.Add(rpnvbbp);
            rpnvbbp.Show();
        }

        private void ribbonButton18_Click(object sender, EventArgs e)
        {
            ViewRPDSKyLuat rpdskl = new ViewRPDSKyLuat();
            panel_show.Show();
            panel_show.Controls.Clear();
            rpdskl.TopLevel = false;
            rpdskl.Dock = DockStyle.Fill;
            panel_show.Controls.Add(rpdskl);
            rpdskl.Show();
        }

        private void ribbonButton19_Click(object sender, EventArgs e)
        {
            ViewRPDSThaiSan rpdsts = new ViewRPDSThaiSan();
            panel_show.Show();
            panel_show.Controls.Clear();
            rpdsts.TopLevel = false;
            rpdsts.Dock = DockStyle.Fill;
            panel_show.Controls.Add(rpdsts);
            rpdsts.Show();
        }

        private void ribbonButton20_Click(object sender, EventArgs e)
        {
            ReportNhanVienDiTre rpnvdt = new ReportNhanVienDiTre();
            panel_show.Show();
            panel_show.Controls.Clear();
            rpnvdt.TopLevel = false;
            rpnvdt.Dock = DockStyle.Fill;
            panel_show.Controls.Add(rpnvdt);
            rpnvdt.Show();
        }

        private void ribbonButton21_Click(object sender, EventArgs e)
        {
            ReportThemGio rptg = new ReportThemGio();
            panel_show.Show();
            panel_show.Controls.Clear();
            rptg.TopLevel = false;
            rptg.Dock = DockStyle.Fill;
            panel_show.Controls.Add(rptg);
            rptg.Show();
        }

        private void ribbonButton22_Click(object sender, EventArgs e)
        {
            ReportGioiTinhh rpgt = new ReportGioiTinhh();
            panel_show.Show();
            panel_show.Controls.Clear();
            rpgt.TopLevel = false;
            rpgt.Dock = DockStyle.Fill;
            panel_show.Controls.Add(rpgt);
            rpgt.Show();
        }

        private void ribbonButton23_Click(object sender, EventArgs e)
        {
            ReportHopDong rphd = new ReportHopDong();
            panel_show.Show();
            panel_show.Controls.Clear();
            rphd.TopLevel = false;
            rphd.Dock = DockStyle.Fill;
            panel_show.Controls.Add(rphd);
            rphd.Show();
        }

        private void ribbonButton24_Click(object sender, EventArgs e)
        {
            ViewRPThamNien rptn = new ViewRPThamNien();
            panel_show.Show();
            panel_show.Controls.Clear();
            rptn.TopLevel = false;
            rptn.Dock = DockStyle.Fill;
            panel_show.Controls.Add(rptn);
            rptn.Show();
        }

        private void ribbonButton30_Click(object sender, EventArgs e)
        {
            PhongBan fpb = new PhongBan();
            panel_show.Show();
            panel_show.Controls.Clear();
            fpb.TopLevel = false;
            fpb.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fpb);
            fpb.Show();
        }

        private void ribbonButton31_Click(object sender, EventArgs e)
        {
            BoPhann fbp = new BoPhann();
            panel_show.Show();
            panel_show.Controls.Clear();
            fbp.TopLevel = false;
            fbp.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fbp);
            fbp.Show();
        }

        private void ribbonButton32_Click(object sender, EventArgs e)
        {
            LuongNhanVien lg = new LuongNhanVien();
            panel_show.Show();
            panel_show.Controls.Clear();
            lg.TopLevel = false;
            lg.Dock = DockStyle.Fill;
            panel_show.Controls.Add(lg);
            lg.Show();
        }

        private void ribbonPanel36_Click(object sender, EventArgs e)
        {
            
        }

        private void ribbonButton34_Click(object sender, EventArgs e)
        {
            HopDong frHopDong = new HopDong();
            panel_show.Show();
            panel_show.Controls.Clear();
            frHopDong.TopLevel = false;
            frHopDong.Dock = DockStyle.Fill;
            panel_show.Controls.Add(frHopDong);
            frHopDong.Show();
          
        }

        private void ribbonPanel39_Click(object sender, EventArgs e)
        {
            
        }

        private void ribbonButton35_Click(object sender, EventArgs e)
        {
            NhanVien fdm = new NhanVien(loginAccount);
            panel_show.Show();
            panel_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fdm);
            fdm.Show();
        }

        private void ribbonButton37_Click(object sender, EventArgs e)
        {
            DanhSachBaoHiem fbh = new DanhSachBaoHiem();
            panel_show.Show();
            panel_show.Controls.Clear();
            fbh.TopLevel = false;
            fbh.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fbh);
            fbh.Show();
        }

        private void ribbonButton38_Click(object sender, EventArgs e)
        {
            DanhSachKhenThuong fkt = new DanhSachKhenThuong();
            panel_show.Show();
            panel_show.Controls.Clear();
            fkt.TopLevel = false;
            fkt.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fkt);
            fkt.Show();
        }

        private void ribbonButton39_Click(object sender, EventArgs e)
        {
            DanhSachKyLuat fkl = new DanhSachKyLuat();
            panel_show.Show();
            panel_show.Controls.Clear();
            fkl.TopLevel = false;
            fkl.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fkl);
            fkl.Show();
        }

        private void ribbonButton40_Click(object sender, EventArgs e)
        {
            DanhSachThaiSan fts = new DanhSachThaiSan();
            panel_show.Show();
            panel_show.Controls.Clear();
            fts.TopLevel = false;
            fts.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fts);
            fts.Show();
        }

        

        private void ribbonButton33_Click(object sender, EventArgs e)
        {
            TinhLuong tl1 = new TinhLuong();
            tl1.Show();
            panel_show.Show();
            panel_show.Controls.Clear();
            tl1.TopLevel = false;
            tl1.Dock = DockStyle.Fill;
            panel_show.Controls.Add(tl1);   
        }

        private void ribbonButton36_Click(object sender, EventArgs e)
        {
            ReportChamCongChiTiet rpccct = new ReportChamCongChiTiet();
            rpccct.Show();
            panel_show.Show();
            panel_show.Controls.Clear();
            rpccct.TopLevel = false;
            rpccct.Dock = DockStyle.Fill;
            panel_show.Controls.Add(rpccct);
        }

        private void ribbonButton28_Click(object sender, EventArgs e)
        {

        }

        private void ribbonButton14_Click_1(object sender, EventArgs e)
        {
            ViewRPDSKhenThuong frdskhenThuong = new ViewRPDSKhenThuong();
            panel_show.Show();
            panel_show.Controls.Clear();
            frdskhenThuong.TopLevel = false;
            frdskhenThuong.Dock = DockStyle.Fill;
            panel_show.Controls.Add(frdskhenThuong);
            frdskhenThuong.Show();
        }

      

        private void ribbonButton36_DoubleClick(object sender, EventArgs e)
        {

        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

        private void ribbonButton2_Click_1(object sender, EventArgs e)
        {
            DTO_NhanVien nhanVienDTO = busNhanVien.GetNhanVienByUserName(LoginAccount.UserName);
            ChamCong cc = new ChamCong(nhanVienDTO);
            cc.Show();
            panel_show.Controls.Clear();
            cc.TopLevel = false;
            cc.Dock = DockStyle.Fill;
            panel_show.Controls.Add(cc);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                ("Bạn có chắc muốn thoát không?", "Thông báo !!", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
            DangNhap dn = new DangNhap();
            dn.Close();
        }

        private void btndangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap dn = new DangNhap();
            dn.Show();
        }
        bool drag = false;
        Point start_point = new Point(0, 0);
        private void ribbon1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void ribbon1_MouseMove(object sender, MouseEventArgs e)
        {
            if(drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void ribbonButton10_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void ribbon1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
