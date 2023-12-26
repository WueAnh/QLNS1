using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TongLuong
    {
		private string maLuongTong;
		private string maNV;
		private string tenNV;
        private string tuNgay;
        private string denNgay;
		private int soNgayCong;
		private float luonngCB;
		private float tongBaoHiem;
		private float tongTienThuong;
		private float tongTienPhat;   
		private float tongLuong;

        public DTO_TongLuong(string maLuongTong, string maNV, string tenNV, string tuNgay, string denNgay, int soNgayCong, float luonngCB, float tongBaoHiem, float tongTienThuong, float tongTienPhat, float tongLuong)
        {
            MaLuongTong = maLuongTong;
            MaNV = maNV;
            TenNV = tenNV;
            TuNgay = tuNgay;
            DenNgay = denNgay;
            SoNgayCong = soNgayCong;
            LuonngCB = luonngCB;
            TongBaoHiem = tongBaoHiem;
            TongTienThuong = tongTienThuong;
            TongTienPhat = tongTienPhat;
            TongLuong = tongLuong;
        }

        public string MaLuongTong { get => maLuongTong; set => maLuongTong = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string TuNgay { get => tuNgay; set => tuNgay = value; }
        public string DenNgay { get => denNgay; set => denNgay = value; }
        public int SoNgayCong { get => soNgayCong; set => soNgayCong = value; }
        public float LuonngCB { get => luonngCB; set => luonngCB = value; }
        public float TongBaoHiem { get => tongBaoHiem; set => tongBaoHiem = value; }
        public float TongTienThuong { get => tongTienThuong; set => tongTienThuong = value; }
        public float TongTienPhat { get => tongTienPhat; set => tongTienPhat = value; }
        public float TongLuong { get => tongLuong; set => tongLuong = value; }
    }
}
