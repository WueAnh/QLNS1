using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ThaiSan
    {
        private string maThaiSan;
        private string maNV;
        private string tenNV;
        private string ngayBatDau;
        private string ngayKetThuc;
        private string trangThai;

        public DTO_ThaiSan(string maThaiSan, string maNV, string tenNV, string ngayBatDau, string ngayKetThuc, string trangThai)
        {
            MaThaiSan = maThaiSan;
            MaNV = maNV;
            TenNV = tenNV;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            TrangThai = trangThai;
        }
        public DTO_ThaiSan(DataRow row)
        {
            this.MaThaiSan = row["MaThaiSan"].ToString();
            this.MaNV = row["MaNV"].ToString();
            this.TenNV = row["TenNV"].ToString();
            this.NgayBatDau = row["NgayBatDau"].ToString();
            this.NgayKetThuc = row["NgayKetThuc"].ToString();
            this.TrangThai = row["TrangThai"].ToString();
            
        }
        public string MaThaiSan { get => maThaiSan; set => maThaiSan = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public string NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
