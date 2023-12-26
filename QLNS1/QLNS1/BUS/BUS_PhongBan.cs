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
    public class BUS_PhongBan
    {
        DAL_PhongBan dalPhongBan = new DAL_PhongBan();
        public static DataTable GetAllPhongBan()
        {
            return DAL_PhongBan.GetData();
        }
        public bool InsertPhongBan(DTO_PhongBan pb)
        {
            return dalPhongBan.InsertPhongBan(pb);
        }
        public bool DeletePhongBan(string maPB)
        {
            return dalPhongBan.DeletePhongBan(maPB);
        }
        public bool UpdatePhongBan(DTO_PhongBan pb)
        {
            return dalPhongBan.UpdatePhongBan(pb);

        }
        public bool CheckMaPhongBan(string maPB)
        {
            return dalPhongBan.CheckMaPhongBan(maPB);
        }

    }
}
