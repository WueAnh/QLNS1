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
    public class BUS_KyLuat
    {
        DAL_KyLuat dalKyLuat = new DAL_KyLuat();
        public DataTable GetData()
        {
            return dalKyLuat.GetData();
        }
        public bool InsertKyLuat(DTO_KyLuat kl)
        {
            return dalKyLuat.InsertKyLuat(kl);
        }
        public bool UpdateKyLuat(DTO_KyLuat kl)
        {
            return dalKyLuat.UpdateKyLuat(kl);
        }
        public bool DeleteKyLuat(string maKyLuat)
        {
            return dalKyLuat.DeleteKyLuat(maKyLuat);
        }
        public bool CheckMaKyLuat(string maKyLuat)
        {
            return dalKyLuat.CheckMaKyLuat(maKyLuat);
        }
    }
}
