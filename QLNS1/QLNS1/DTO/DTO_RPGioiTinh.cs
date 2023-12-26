using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_RPGioiTinh
    {
        private string maNV;
        private string tenNV;
        private string gioiTinh;
        private string chucVu;
        private string email;
        private string sDT;
        private string diaChi;

        public DTO_RPGioiTinh(string maNV, string tenNV, string gioiTinh, string chucVu, string email, string sDT, string diaChi)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.gioiTinh = gioiTinh;
            this.chucVu = chucVu;
            this.email = email;
            this.sDT = sDT;
            this.diaChi = diaChi;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string Email { get => email; set => email = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
