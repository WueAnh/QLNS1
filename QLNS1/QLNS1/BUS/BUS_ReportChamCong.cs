using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_ReportChamCong
    {
        DAL_ReportChamCong dalRPChamCong = new DAL_ReportChamCong();
        public DataTable GetChamCongByBP(string maBP, string ngayBatDau, string ngayKetThuc)
        {
            return dalRPChamCong.GetChamCongByBP(maBP, ngayBatDau, ngayKetThuc);
        }
        public DataTable GetNhanVienDiTre(string maNV ,string ngayBatDau, string ngayKetThuc)
        {
            return dalRPChamCong.GetNhanVienDiTre(maNV,ngayBatDau, ngayKetThuc);
        }
        public DataTable GetFindTenNV(string maNV, string tenNV, string ngayBatDau, string ngayKetThuc)
        {
            return dalRPChamCong.GetDataFindTenNV(maNV, tenNV, ngayBatDau, ngayKetThuc);
        }
        public DataTable GetThemGio(string ngayBatDau, string ngayKetThuc)
        {
            return dalRPChamCong.GetThemGio(ngayBatDau,ngayKetThuc);
        }
       

    }
}
