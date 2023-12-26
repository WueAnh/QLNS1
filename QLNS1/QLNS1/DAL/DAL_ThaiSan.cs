using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_ThaiSan
    {
        // code hiển thỉ bảng thai sản
        public DataTable GetData()
        {
            DataTable dt = DataConnection.Instance.ExecuteQuery("select * from DSThaiSan");
            return dt;
        }
       
        //code thêm thai sản
        public bool InsertThaiSan(DTO_ThaiSan ts)
        {
            string query = string.Format($"insert into DSThaiSan(MaNV, TenNV, NgayBatDau, NgayKetThuc, TrangThai)values(N'{ts.MaNV}', N'{ts.TenNV}', '{ts.NgayBatDau}', '{ts.NgayKetThuc}', N'{ts.TrangThai}')");
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //code sửa thai sản
        public bool UpdateThaiSan(DTO_ThaiSan ts)
        {
            string query = string.Format($"update DSThaiSan set MaNV='{ts.MaNV}', TenNV=N'{ts.TenNV}', NgayBatDau='{ts.NgayBatDau}', NgayKetThuc='{ts.NgayKetThuc}', TrangThai=N'{ts.TrangThai}' where MaThaiSan={ts.MaThaiSan}");
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        // code xóa thai sản
        public bool DeleteThaiSan(string maThaiSan)
        {
            string query = string.Format($"delete DSThaiSan where MaThaiSan= {maThaiSan}");
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
