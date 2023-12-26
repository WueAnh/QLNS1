using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_BaoHiem
    {
        // code hiển thỉ bảng bảo hiểm
        public DataTable GetData()
        {
            DataTable dt = DataConnection.Instance.ExecuteQuery("select * from DSBaoHiem");
            return dt;
        }
        // Lấy danh sách data trên DataTable return về List<DTO_BaoHiem>
        public List<DTO_BaoHiem> ListAllBaoHiem()
        {
            List<DTO_BaoHiem> lstBH = new List<DTO_BaoHiem>();
            DataTable data = DataConnection.Instance.ExecuteQuery("select * from DSBaoHiem");
            lstBH.Clear();
            foreach (DataRow item in data.Rows)
            {
                lstBH.Add(new DTO_BaoHiem(item));
            }
            return lstBH;
        }
        //code thêm bảo hiểm
        public bool InsertBaoHiem(DTO_BaoHiem bh)
        {
            string query = string.Format($"insert into DSBaoHiem(MaNV, TenNV, LoaiBH, MaTheBH, NgayCap, NgayHetHan, NoiCap, PhiBaoHiem)values('{bh.MaNV}', N'{bh.TenNV}', N'{bh.LoaiBH}', '{bh.MaTheBH}', '{bh.NgayCap}', '{bh.NgayHetHan}', N'{bh.NoiCap}', '{bh.PhiBaoHiem}')");
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //code sửa bảo hiểm
        public bool UpdateBaoHiem(DTO_BaoHiem bh)
        {
            string query = string.Format($"update DSBaoHiem set MaNV='{bh.MaNV}', TenNV=N'{bh.TenNV}', LoaiBH=N'{bh.LoaiBH}', MaTheBH='{bh.MaTheBH}', NgayCap='{bh.NgayCap}', NgayHetHan='{bh.NgayHetHan}', NoiCap=N'{bh.NoiCap}', PhiBaoHiem = {bh.PhiBaoHiem} where MaBH={bh.MaBH}");
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        // code xóa bảo hiểm
        public bool DeleteBaoHiem(string maBH)
        {
            string query = string.Format($"delete DSBaoHiem where MaBH= {maBH}");
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        // code check DSBaoHiem với MaBH truyền vào có tồn tại không
        public bool CheckMaBH(string maBH)
        {
            string query = string.Format($"select * from DSBaoHiem where MaBH = '{maBH}'");
            return DataConnection.Instance.CheckExist(query);
        }
        // kiểm tra bảo hiểm đã quá hạn hoặc thông tin không hợp lệ
        public bool CheckBHIsExists(string maNV, string loaiBH, string tuNgay, DateTime denNgay)
        {
            string query = string.Format($"exec sp_CheckBaoHiemIsExists '{maNV}', N'{loaiBH}', '{tuNgay}', '{denNgay}'");
            return DataConnection.Instance.CheckExist(query);
        }
    }
}
