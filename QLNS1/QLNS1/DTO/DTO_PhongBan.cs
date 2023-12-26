using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public  class DTO_PhongBan
    {
        private string maPhong;
        private string maBP;
        private string tenBP;
        private string tenPhong;
        private string diaChi;

        public DTO_PhongBan(string maPhong, string maBP, string tenBP, string tenPhong, string diaChi)
        {
            MaPhong = maPhong;
            MaBP = maBP;
            TenBP = tenBP;
            TenPhong = tenPhong;
            DiaChi = diaChi;
        }

        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string MaBP { get => maBP; set => maBP = value; }
        public string TenBP { get => tenBP; set => tenBP = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
