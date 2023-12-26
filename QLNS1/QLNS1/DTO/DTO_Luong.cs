using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_Luong
    {
        private int maLuong;
        private string tenNV;
        private float luongCB;
        private string maNV;

        public DTO_Luong(int maLuong, string tenNV, int luongCB, string maNV)
        {
            this.MaLuong = maLuong;
            this.TenNV = tenNV;
            this.LuongCB = luongCB;
            this.MaNV = maNV;
        }

        public int MaLuong { get => maLuong; set => maLuong = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public float LuongCB { get => luongCB; set => luongCB = value; }
        public string MaNV { get => maNV; set => maNV = value; }
    }
}
