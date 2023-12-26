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
    public class DAL_BoPhan
    {
        // code hiển thỉ bảng bộ phận
        public DataTable GetData()
        {
            DataTable dt = DataConnection.Instance.ExecuteQuery("select * from BoPhan");
            return dt;
        }
        //code thêm bộ phận
        public bool InsertBoPhan(DTO_BoPhan bp)
        {
            string query = string.Format("insert into BoPhan(MaBP,TenBP,NgayTL,GhiChu)values(N'{0}', N'{1}', N'{2}', N'{3}')", bp.MaBP,bp.TenBP,bp.NgayTL,bp.GhiChu);
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //code sửa bộ phận
        public bool UpdateBoPhan(DTO_BoPhan bp)
        {
            string query = string.Format("update BoPhan set TenBP= N'{0}', NgayTL='{1}', GhiChu= N'{2}' where MaBP='{3}'", bp.TenBP, bp.NgayTL, bp.GhiChu, bp.MaBP);
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        // code xóa bộ phận
        public bool DeleteBoPhan(string maBP)
        {
            string query = string.Format("delete BoPhan where MaBP=N'{0}'", maBP);
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        // code check bảng bộ phận với mã bộ phận truyền vào
        public bool CheckMaBoPhan(string MaBP)
        {
            string query = string.Format($"select * from BoPhan where MaBP = N'{MaBP}'");
            return DataConnection.Instance.CheckExist(query);
        }
    }
}
