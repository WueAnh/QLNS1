using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
   public class BUS_ReportNhanVien
    {
        DAL_ReportNhanVien dalRPNhanVien = new DAL_ReportNhanVien();

        public List<DTO_KyLuat> ListAllDSKyLuat()
        {
            return dalRPNhanVien.ListAllDSKyLuat();
        }
       
        public List<DTO_KhenThuong> ListAllDSKhenThuong()
        {
            return dalRPNhanVien.ListAllDSKhenThuong();
        }
        public DataTable GetNhanVienByMaBP(string maBP)
        {
            return dalRPNhanVien.GetNhanVienByMaBP(maBP);
        }
        public List<DTO_ThaiSan> ListAllDSThaiSan()
        {
            return dalRPNhanVien.ListAllDSThaiSan();
        }
        public DataTable GetGioiTinh(string gioiTinh)
        {
            return dalRPNhanVien.GetGioiTinh(gioiTinh);
        }
        public DataTable GetHopDong(string ngayBatDau,string ngayKetThuc)
        {
            return dalRPNhanVien.GetHopDong(ngayBatDau,ngayKetThuc);
        }
        public List<DTO_RPThamNien> ListAllThamNien()
        {
            return dalRPNhanVien.ListAllThamNien();
        }

    }

}
