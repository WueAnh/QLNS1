using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_RPThamNien
    {
        private string maNV;
        private string tenNV;
        private string gioiTinh;
        private string ngaySinh;
        private string queQuan;
        private string sDT;
        private string diaChi;
        private string cmnd;
        private string email;
        private string tenTDHV;
        private string cNganh;
        private string chucVu;
        private string tinhtrang;
        private string ngayvaolam;
        private string userName;
        private string maPhong;
        private string maBP;
        private string thamNien;

        public DTO_RPThamNien(string maNV, string tenNV, string gioiTinh, string ngaySinh, string queQuan, string sDT, string diaChi, string cmnd, string email, string tenTDHV, string cNganh, string chucVu, string tinhtrang, string ngayvaolam, string userName, string maPhong, string maBP, string thamNien)
        {
            MaNV = maNV;
            TenNV = tenNV;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            QueQuan = queQuan;
            SDT = sDT;
            DiaChi = diaChi;
            Cmnd = cmnd;
            Email = email;
            TenTDHV = tenTDHV;
            CNganh = cNganh;
            ChucVu = chucVu;
            Tinhtrang = tinhtrang;
            Ngayvaolam = ngayvaolam;
            UserName = userName;
            MaPhong = maPhong;
            MaBP = maBP;
            ThamNien = thamNien;
        }

        public DTO_RPThamNien(DataRow row)
        {

            this.MaNV = row["MaNV"].ToString();
            this.TenNV = row["TenNV"].ToString();
            this.GioiTinh = row["GioiTinh"].ToString();
            this.ngaySinh = row["NgaySinh"].ToString();
            this.QueQuan = row["QueQuan"].ToString();
            this.SDT = row["SDT"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.Cmnd = row["Cmnd"].ToString();
            this.Email = row["Email"].ToString();
            this.TenTDHV = row["TenTDHV"].ToString();
            this.CNganh = row["CNganh"].ToString();
            this.chucVu = row["ChucVu"].ToString();
            this.tinhtrang = row["TinhTrang"].ToString();
            this.ngayvaolam = row["NgayVaoLam"].ToString();
            this.UserName = row["UserName"].ToString();
            this.MaPhong = row["MaPhong"].ToString();
            this.MaBP = row["MaBP"].ToString();
            this.ThamNien = row["ThamNien"].ToString();

        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Email { get => email; set => email = value; }
        public string TenTDHV { get => tenTDHV; set => tenTDHV = value; }
        public string CNganh { get => cNganh; set => cNganh = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
        public string Ngayvaolam { get => ngayvaolam; set => ngayvaolam = value; }
        public string UserName { get => userName; set => userName = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string MaBP { get => maBP; set => maBP = value; }
        public string ThamNien { get => thamNien; set => thamNien = value; }
    }
}
