using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
   public class DAL_Luong
    {
        public DataTable GetData()
        {
            DataTable dt = DataConnection.Instance.ExecuteQuery("select * from Luong");
            return dt;
        }
        // lay thong tin nhan vien thong qua tai khoan
        public bool InsertLuong(string tennv,string manv,string chucvu)
        {
            string query = string.Format($"insert into Luong(TenNV,MaNV,ChucVu) values (N'{tennv}',N'{manv}',N'{chucvu}')");
            int result = DataConnection.Instance.ExecuteNonQuery(query); // sửa lại cho đúng đi lol chỗ nào sql viet hoa viet thuong gi cung nhan ma, chạy thử coi
            return result > 0;
        }
        public bool UpdateLuong(float luongcb, string manv)
        {
            string query = string.Format($"update Luong set LuongCB={luongcb} where MaNV='{manv}'");
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


    }
}
