using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HopDong
    {
        // code hiển thỉ bảng Hợp Đồng
        public DataTable GetData()
        {
            DataTable dt = DataConnection.Instance.ExecuteQuery("select * from HopDong");
            return dt;
        }

        // code thêm hợp đồng
        public bool InsertHopDong(DTO_HopDong hd)
        {
            string query = string.Format("insert into HopDong(MaHD,MaNV,TenNV,MaBP,tenBP,MaPhong,TenPhong,LoaiHD,NgayBD,NgayKT)values(N'{0}', N'{1}', N'{2}', N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}')", hd.MaHD, hd.MaNV, hd.TenNV, hd.MaBP, hd.TenBP, hd.MaPhong, hd.TenPhong, hd.LoaiHD, hd.NgayBD, hd.NgayKT);
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //code sửa hợp đồng
        public bool UpdateHopDong(DTO_HopDong hd)
        {
            string query = string.Format("update HopDong set LoaiHD=N'{0}', MaNV='{1}', TenNV=N'{2}', MaBP='{3}', tenBP=N'{4}', MaPhong='{5}', TenPhong=N'{6}', NgayBD='{7}', NgayKT='{8}' where MaHD='{9}'", hd.LoaiHD, hd.MaNV, hd.TenNV, hd.MaBP, hd.TenBP, hd.MaPhong, hd.TenPhong, hd.NgayBD, hd.NgayKT, hd.MaHD);
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        // code xóa hợp đồng
        public bool DeleteHopDong(string maHD)
        {
            string query = string.Format("delete HopDong where MaHD=N'{0}'", maHD);
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        // code check bảng hợp đồng với mã hợp đồng truyền vào
        public bool CheckMaHopDong(string MaHD)
        {
            string query = string.Format($"select * from HopDong where MaHD = N'{MaHD}'");
            return DataConnection.Instance.CheckExist(query);
        }
    }
}
