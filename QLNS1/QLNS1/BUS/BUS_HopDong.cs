using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_HopDong
    {
        DAL_HopDong dalHopDong = new DAL_HopDong();
        public DataTable GetAllHopDong()
        {
            return dalHopDong.GetData();
        }
        public bool InsertHopDong(DTO_HopDong hd)
        {
            return dalHopDong.InsertHopDong(hd);
        }
        public bool DeleteHopDong(string maHD)
        {
            return dalHopDong.DeleteHopDong(maHD);
        }
        public bool UpdateHopDong(DTO_HopDong hd)
        {
            return dalHopDong.UpdateHopDong(hd);
        }
        public bool CheckMaHopDong(string maHD)
        {
            return dalHopDong.CheckMaHopDong(maHD);
        }
    }
}
