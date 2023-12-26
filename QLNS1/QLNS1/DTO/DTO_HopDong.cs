using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HopDong
    {
        private string maHD;
        private string maNV;
        private string tenNV;
        private string maBP;
        private string tenBP;
        private string maPhong;
        private string tenPhong;
        private string loaiHD;
        private string ngayBD;
        private string ngayKT;

        public DTO_HopDong(string maHD, string maNV, string tenNV, string maBP, string tenBP, string maPhong, string tenPhong, string loaiHD, string ngayBD, string ngayKT)
        {
            MaHD = maHD;
            MaNV = maNV;
            TenNV = tenNV;
            MaBP = maBP;
            TenBP = tenBP;
            MaPhong = maPhong;
            TenPhong = tenPhong;
            LoaiHD = loaiHD;
            NgayBD = ngayBD;
            NgayKT = ngayKT;
        }

        public DTO_HopDong(DataRow row)
        {
            this.MaHD = row["MaHD"].ToString();
            this.MaNV = row["MaNV"].ToString();
            this.TenNV = row["TenNV"].ToString();
            this.MaBP = row["MaBP"].ToString();
            this.TenBP = row["TenBP"].ToString();
            this.MaPhong = row["MaPhong"].ToString();
            this.tenPhong = row["TenPhong"].ToString();
            this.LoaiHD = row["LoaiHD"].ToString();
            this.NgayBD = row["NgayBD"].ToString();
            this.NgayKT = row["NgayKT"].ToString();
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string MaBP { get => maBP; set => maBP = value; }
        public string TenBP { get => tenBP; set => tenBP = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public string LoaiHD { get => loaiHD; set => loaiHD = value; }
        public string NgayBD { get => ngayBD; set => ngayBD = value; }
        public string NgayKT { get => ngayKT; set => ngayKT = value; }
    }
}
