using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_PhongBan
    {
        public static DataTable GetData()
        {
            DataTable dt = DataConnection.Instance.ExecuteQuery("select * from PhongBan");
            return dt;
        }

        //code thêm phòng ban
        public bool InsertPhongBan(DTO_PhongBan pb)
        {
            string query = string.Format("insert into PhongBan(MaPhong,MaBP,TenBP,TenPhong,DiaChi)values(N'{0}', N'{1}', N'{2}', N'{3}', N'{4}')", pb.MaPhong, pb.MaBP, pb.TenBP, pb.TenPhong, pb.DiaChi);
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //code sửa phòng ban
        public bool UpdatePhongBan(DTO_PhongBan pb)
        {
            string query = string.Format("update PhongBan set MaBP='{0}', tenBP='{1}', TenPhong=N'{2}', DiaChi=N'{3}' where MaPhong='{4}'", pb.MaBP, pb.TenBP, pb.TenPhong, pb.DiaChi, pb.MaPhong);
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        // code xóa phòng ban
        public bool DeletePhongBan(string maphong)
        {
            string query = string.Format("delete PhongBan where MaPhong=N'{0}'", maphong);
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        // code check bảng phòng ban với mã phòng ban truyền vào
        public bool CheckMaPhongBan(string maphong)
        {
            string query = string.Format($"select * from PhongBan where MaPhong = N'{maphong}'");
            return DataConnection.Instance.CheckExist(query);
        }
    }
}
