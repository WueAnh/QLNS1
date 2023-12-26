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
    public class DAL_KyLuat
    {
        // code hiển thỉ bảng kỷ luật
        public DataTable GetData()
        {
            DataTable dt = DataConnection.Instance.ExecuteQuery("select * from DSKyLuat");
            return dt;
        }
       
        //code thêm kỷ luật
        public bool InsertKyLuat(DTO_KyLuat kl)
        {
            string query = string.Format($"insert into DSKyLuat(MaNV, TenNV, NgayKyLuat, LyDo, HinhThuc, TienPhat)values('{kl.MaNV}', N'{kl.TenNV}', '{kl.NgayKyLuat}', N'{kl.LyDo}', N'{kl.HinhThuc}', {kl.TienPhat})");
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //code sửa kỷ luật
        public bool UpdateKyLuat(DTO_KyLuat kl)
        {
            string query = string.Format($"update DSKyLuat set MaNV='{kl.MaNV}', TenNV=N'{kl.TenNV}', NgayKyLuat= '{kl.NgayKyLuat}', LyDo= N'{kl.LyDo}', HinhThuc= N'{kl.HinhThuc}', TienPhat= {kl.TienPhat} where MaKyLuat={kl.MaKyLuat}");
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        // code xóa kỷ luật
        public bool DeleteKyLuat(string maKyLuat)
        {
            string query = string.Format($"delete DSKyLuat where MaKyLuat= {maKyLuat}");
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        // code check DSKyLuat với MaKyLuat truyền vào
        public bool CheckMaKyLuat(string maKyLuat)
        {
            string query = string.Format($"select * from DSKyLuat where MaKyLuat = '{maKyLuat}'");
            return DataConnection.Instance.CheckExist(query);
        }
    }
}
