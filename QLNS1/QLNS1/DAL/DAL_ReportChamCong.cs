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
    public class DAL_ReportChamCong
    {
        public DataTable GetChamCongByBP(string maBP, string ngayBatDau, string ngayKetThuc)
        {
            DataTable dt = DataConnection.Instance.ExecuteQuery($"exec RP_ChamCongByMaBP '{maBP}','{ngayBatDau}','{ngayKetThuc}'");
            return dt;
        }
        public DataTable GetNhanVienDiTre(string maNV, string ngayBatDau, string ngayKetThuc)
        {
            DataTable dt = DataConnection.Instance.ExecuteQuery($"exec RP_NhanVienDiTre '{maNV}','{ngayBatDau}','{ngayKetThuc}'");
            return dt;
        }

        public DataTable GetDataFindTenNV(string maNV, string tenNV, string ngayBatdau, string ngayKetThuc)
        {
            DataTable dt = DataConnection.Instance.ExecuteQuery($"select * from ChamCong where MaNV like N'%{maNV}%' and TenNV like N'%{tenNV}%' and NgayCham between '{ngayBatdau}'and'{ngayKetThuc}'");
            return dt;
        }

        public DataTable GetThemGio( string ngayBatDau, string ngayKetThuc)
        {
            DataTable dt = DataConnection.Instance.ExecuteQuery($"exec RP_ThemGio '{ngayBatDau}','{ngayKetThuc}'");
            return dt;
        }
       


        public List<DTO_ChamCong> ListChamCongByNV(string maNV)
        {
            List<DTO_ChamCong> lstCC = new List<DTO_ChamCong>();
            DataTable data = DataConnection.Instance.ExecuteQuery($"select * from ChamCong where MaNV='{maNV}'");
            lstCC.Clear();
            foreach (DataRow item in data.Rows)
            {
                lstCC.Add(new DTO_ChamCong(item));
            }
            return lstCC;
        }

    }
}
