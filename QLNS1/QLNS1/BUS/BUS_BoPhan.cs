using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_BoPhan
    {
        DAL_BoPhan dalBoPhan = new DAL_BoPhan();
        public DataTable GetAllBoPhan()
        {
            return dalBoPhan.GetData();
        }
        public bool InsertBoPhan(DTO_BoPhan bp)
        {
            return dalBoPhan.InsertBoPhan(bp);
        }
        public bool DeleteBoPhan(string maBP)
        {
            return dalBoPhan.DeleteBoPhan(maBP);
        }
        public bool UpdateBoPhan(DTO_BoPhan bp)
        {
            return dalBoPhan.UpdateBoPhan(bp);
        }
        public bool CheckMaBoPhan(string maBP)
        {
            return dalBoPhan.CheckMaBoPhan(maBP);
        }

    }
}
