using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_ThaiSan
    {
        DAL_ThaiSan dalThaiSan = new DAL_ThaiSan();
        public DataTable GetData()
        {
            return dalThaiSan.GetData();
        }
        public bool InsertThaiSan(DTO_ThaiSan ts)
        {
            return dalThaiSan.InsertThaiSan(ts);
        }
        public bool UpdateThaiSan(DTO_ThaiSan ts)
        {
            return dalThaiSan.UpdateThaiSan(ts);
        }
        public bool DeleteThaiSan(string maThaiSan)
        {
            return dalThaiSan.DeleteThaiSan(maThaiSan);
        }
    }
}
