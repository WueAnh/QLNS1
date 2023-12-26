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
    public partial class ChamCong : Form
    {
        private DTO_NhanVien nhanVienDTO;
        BUS_ChamCong busChamCong = new BUS_ChamCong();

        public ChamCong(DTO_NhanVien acc)
        {
            this.nhanVienDTO = acc;
            InitializeComponent();
            ChangeChamCong();
        }

        public DTO_NhanVien NhanVienDTO
        {
            get { return nhanVienDTO; }
            set { nhanVienDTO = value; }
        }
        void ChangeChamCong()
        {
            txtAccount.Text = $"{NhanVienDTO.UserName}";
            txtMaNV.Text = $"{NhanVienDTO.MaNV}";
            txtTenNV.Text = $"{NhanVienDTO.TenNV}";
        }

        void AddChamCong(string maNV, string username, string tenNV, string ngayCham, string gioVao, string statusIn, string diTre)
        {
            if (busChamCong.InsertChamCong(maNV, username, tenNV, ngayCham, gioVao, statusIn, diTre))
            {
                MessageBox.Show("Đã Ghi Nhận");
            }
            else
            {
                MessageBox.Show("Lỗi Time In");
            }
            dataGridView1.DataSource = busChamCong.GetChamCongByMaNV(NhanVienDTO.MaNV);

        }
        void EditChamCong(string userName, string gioRa, string statusOut)
        {
            if (busChamCong.UpdateChamCong(userName, gioRa, statusOut))
            {
                MessageBox.Show("Đã Ghi Nhận!!!.Kết Thúc Giờ Làm");
            }
            else
            {
                MessageBox.Show("Lỗi Time Out");
            }
            dataGridView1.DataSource = busChamCong.GetChamCongByMaNV(NhanVienDTO.MaNV);

        }
        private void btntimein_Click(object sender, EventArgs e)
        {
            //// Kiểm Tra Chấm Công
            if (busChamCong.CheckChamCongExists(txtMaNV.Text, DateTime.Now.ToString("MM/dd/yyyy")))
            {
                MessageBox.Show("Hôm Nay Bạn đã chấm công rồi !!! ");
                return;
            }
            if (!busChamCong.GioRaIsNull(NhanVienDTO.UserName))
            {
                DateTime a = DateTime.Parse(dtGioLamViec.Value.ToShortTimeString());
                DateTime b = DateTime.Parse(DateTime.Now.ToShortTimeString());
                int result = DateTime.Compare(b, a);//so sánh giờ làm việc với giờ time in 
                string diTre;
                if (result < 0)
                    diTre = null;
                else
                    diTre = "Trễ giờ làm";
                
                string ngayCham = label3.Text = DateTime.Now.ToString("MM/dd/yyyy");
                string gioVao = txtdate.Text = DateTime.Now.ToString("HH:mm");
                string statusIn = btntimein.Text = "Time In";

                AddChamCong(nhanVienDTO.MaNV, nhanVienDTO.UserName, nhanVienDTO.TenNV, ngayCham, gioVao, statusIn, diTre);
            }
            else
                MessageBox.Show("Bạn đã ghi nhận giờ vào!");


        }
        private void btntimeout_Click(object sender, EventArgs e)
        {
            // kiểm tra ghi nhận giờ vào 
            if (busChamCong.GioRaIsNull(NhanVienDTO.UserName))
            {
                string giora = label3.Text = DateTime.Now.ToString("HH:mm");
                string statusOut = btntimeout.Text = "Time Out";

                EditChamCong(NhanVienDTO.UserName, giora, statusOut);
            }
            else
                MessageBox.Show("Bạn chưa ghi nhận giờ vào!");

        }

    

    private void ChamCong_Load(object sender, EventArgs e)
        {
            //hiển thị dữ liệu1
            dataGridView1.DataSource = busChamCong.GetChamCongByMaNV(NhanVienDTO.MaNV);
            timer1.Start();

    }



        private void timer1_Tick(object sender, EventArgs e)
        {
            // show time va date hiện tại
          

        }

        private void dtGioLamViec_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
