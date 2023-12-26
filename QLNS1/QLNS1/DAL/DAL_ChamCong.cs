using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_ChamCong
    {
        public DataTable GetChamCongByBP(string maBP, string ngayBatDau, string ngayKetThuc)
        {
            DataTable dt = DataConnection.Instance.ExecuteQuery($"exec Rp_ChamCong '{maBP}','{ngayBatDau}','{ngayKetThuc}'");
            return dt;
        }
        // code hiển thỉ bảng Chấm Công
        public DataTable GetData(string maNV)
        {
            DataTable dt = DataConnection.Instance.ExecuteQuery($"select * from ChamCong where MaNV = '{maNV}'");
            return dt;
        }
        //code thêm Chấm Công
        public bool InsertChamCong(string manv, string username, string tennv, string ngaycham, string giovao, string statusin, string diTre)
        {
            string query = string.Format($"insert into ChamCong(MaNV,UserName,TenNV,NgayCham,GioVao,StatusIn, DiTre)values(N'{manv}', '{username}', N'{tennv}', '{ngaycham}', '{giovao}', '{statusin}', N'{diTre}')");
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //CODE Sửa Chấm công
        public bool UpdateChamCong(string userName, string gioRa, string statusOut)
        {
            string query = string.Format($"update ChamCong set GioRa = '{gioRa}', StatusOut = '{statusOut}' where UserName = '{userName}' and GioRa is null");
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //Code kiểm tra giờ ra theo manv
        public bool GioRaIsNull(string userName)
        {
            string query = string.Format($"select * from ChamCong where UserName = '{userName}' and GioRa is null");
            return DataConnection.Instance.CheckExist(query);
        }
        //Code kiểm tra đã chấm công chưa
        public bool CheckChamCongExists(string maNv, string ngayCham)
        {
            string query = string.Format($"sp_CheckChamCongExists '{maNv}', '{ngayCham}'");
            return DataConnection.Instance.CheckExist(query);
        }
    }

}
