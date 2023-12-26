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
   public class BUS_Luong
    {
        DAL_Luong dalLuong = new DAL_Luong();
        public DataTable GetAllLuong()
        {
            return dalLuong.GetData();
        }
        public bool InsertLuong(string tennv, string manv,string chucvu)
        {
            return dalLuong.InsertLuong(tennv, manv,chucvu);
        }
        public bool UpdateLuong(float luongcb,string manv)
        {
            return dalLuong.UpdateLuong(luongcb,manv);
        }
    }
}
