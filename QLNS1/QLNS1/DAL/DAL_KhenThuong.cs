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
    public class DAL_KhenThuong
    {
        // code hiển thỉ bảng khen thưởng
        public DataTable GetData()
        {
            DataTable dt = DataConnection.Instance.ExecuteQuery("select * from DSKhenThuong");
            return dt;
        }
        public List<DTO_KhenThuong> ListAllDSKhenThuong()
        {
            List<DTO_KhenThuong> lstBH = new List<DTO_KhenThuong>();
            DataTable data = DataConnection.Instance.ExecuteQuery("select * from DSKhenThuong");
            lstBH.Clear();
            foreach (DataRow item in data.Rows)
            {
                lstBH.Add(new DTO_KhenThuong(item));
            }
            return lstBH;
        }

        //code thêm khen thưởng
        public bool InsertKhenThuong(DTO_KhenThuong kt)
        {
            string query = string.Format($"insert into DSKhenThuong(MaNV, TenNV, NgayThuong, LyDo, HinhThuc, TienThuong)values(N'{kt.MaNV}', N'{kt.TenNV}', '{kt.NgayThuong}', N'{kt.LyDo}', N'{kt.HinhThuc}', {kt.TienThuong})");
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //code sửa khen thưởng
        public bool UpdateKhenThuong(DTO_KhenThuong kt)
        {
            string query = string.Format($"update DSKhenThuong set MaNV='{kt.MaNV}', TenNV=N'{kt.TenNV}', NgayThuong= '{kt.NgayThuong}', LyDo=N'{kt.LyDo}', HinhThuc=N'{kt.HinhThuc}', TienThuong= {kt.TienThuong} where MaThuong={kt.MaThuong}");
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        // code xóa khen thưởng
        public bool DeleteKhenThuong(string maThuong)
        {
            string query = string.Format($"delete DSKhenThuong where MaThuong= {maThuong}");
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        // code check DSKhenThuong với MaThuong truyền vào
        public bool CheckMaThuong(string maThuong)
        {
            string query = string.Format($"select * from DSKhenThuong where MaThuong = '{maThuong}'");
            return DataConnection.Instance.CheckExist(query);
        }
    }
}
