using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_ChamCong
    {
        DAL_ChamCong dalChamCong = new DAL_ChamCong();
        public DataTable GetChamCongByMaNV(string maNV)
        {
            return dalChamCong.GetData(maNV);
        }
        public bool InsertChamCong(string manv, string username, string tennv, string ngaycham, string giovao, string statusin, string diTre)
        {
            return dalChamCong.InsertChamCong(manv, username, tennv, ngaycham, giovao, statusin, diTre);
        }
        public bool UpdateChamCong(string userName, string gioRa, string statusOut)
        {
            return dalChamCong.UpdateChamCong(userName, gioRa, statusOut);
        }
        public bool GioRaIsNull(string userName)
        {
            return dalChamCong.GioRaIsNull(userName);
        }
        public bool CheckChamCongExists(string maNV, string ngayCham)
        {
            return dalChamCong.CheckChamCongExists(maNV, ngayCham);
        }
        public DataTable GetChamCongByBP(string maBP, string ngayBatDau, string ngayKetThuc)
        {
            return dalChamCong.GetChamCongByBP(maBP, ngayBatDau, ngayKetThuc);
        }
    }

}