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
    public class BUS_NhanVien
    {
        DAL_NhanVien dalNhanVien = new DAL_NhanVien();
        public DataTable GetAllNhanVien()
        {
            return dalNhanVien.GetData();
        }
        public bool InsertNhanVien(DTO_NhanVien nv)
        {
            return dalNhanVien.InsertNhanVien(nv);
        }
        public bool DeleteNhanVien(string maNV)
        {
            return dalNhanVien.DeleteNhanVien(maNV);
        }
        public bool UpdateNhanVien(DTO_NhanVien nv)
        {
            return dalNhanVien.UpdateNhanVien(nv);
        }
        public bool CheckMaNV(string maNV)
        {
            return dalNhanVien.CheckMaNV(maNV);
        }
        public bool CheckMaNVByUserName(string userName)
        {
            return dalNhanVien.CheckMaNVByUserName(userName);
        }
        public DTO_NhanVien GetNhanVienByUserName(string userName)
        {
            return dalNhanVien.GetNhanVienByUserName(userName);
        }
    }
}
