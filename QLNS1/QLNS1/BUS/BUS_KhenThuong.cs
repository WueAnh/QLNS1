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
    public class BUS_KhenThuong
    {
        DAL_KhenThuong dalKhenThuong = new DAL_KhenThuong();
        public DataTable GetData()
        {
            return dalKhenThuong.GetData();
        }
        public bool InsertKhenThuong(DTO_KhenThuong kt)
        {
            return dalKhenThuong.InsertKhenThuong(kt);
        }
        public bool UpdateKhenThuong(DTO_KhenThuong kt)
        {
            return dalKhenThuong.UpdateKhenThuong(kt);
        }
        public bool DeleteKhenThuong(string maThuong)
        {
            return dalKhenThuong.DeleteKhenThuong(maThuong);
        }
        public bool CheckMaThuong(string maThuong)
        {
            return dalKhenThuong.CheckMaThuong(maThuong);
        }
    }
}
