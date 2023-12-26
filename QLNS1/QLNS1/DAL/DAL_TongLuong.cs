using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using Oracle.ManagedDataAccess.Client;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_TongLuong
    {
        public DataTable GetALLTongLuong()
        {
            DataTable dt = DataConnection.Instance.ExecuteQuery("select * from TongLuong");
            return dt;
        }


        public bool InsertTongLuong(DTO_TongLuong tl)
        {
            string query = "INSERT INTO TongLuong(MaNV, TenNV, TuNgay, DenNgay, SoNgayCong, LuongCB, TongPhiBH, TongTienThuong, TongTienPhat, TongLuong) " +
                           "VALUES (:MaNV, :TenNV, TO_DATE(:TuNgay, 'DD/MM/YYYY'), TO_DATE(:DenNgay, 'DD/MM/YYYY'), :SoNgayCong, :LuonngCB, :TongBaoHiem, :TongTienThuong, :TongTienPhat, :TongLuong)";
            OracleParameter[] parameters = {
                new OracleParameter(":MaNV", tl.MaNV),
                new OracleParameter(":TenNV", tl.TenNV),
                new OracleParameter(":TuNgay", tl.TuNgay),
                new OracleParameter(":DenNgay", tl.DenNgay),
                new OracleParameter(":SoNgayCong", tl.SoNgayCong),
                new OracleParameter(":LuonngCB", tl.LuonngCB),
                new OracleParameter(":TongBaoHiem", tl.TongBaoHiem),
                new OracleParameter(":TongTienThuong", tl.TongTienThuong),
                new OracleParameter(":TongTienPhat", tl.TongTienPhat),
                new OracleParameter(":TongLuong", tl.TongLuong)
            };
            int result = DataConnection.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool UpdateTongLuong(DTO_TongLuong tl)
        {
            string query = "UPDATE TongLuong " +
                           "SET TenNV = :TenNV, TuNgay = TO_DATE(:TuNgay, 'DD/MM/YYYY'), DenNgay = TO_DATE(:DenNgay, 'DD/MM/YYYY'), " +
                           "SoNgayCong = :SoNgayCong, LuongCB = :LuonngCB, PhiBaoHiem = :TongBaoHiem, TienThuong = :TongTienThuong, " +
                           "TongTienPhat = :TongTienPhat, TongTien = :TongLuong " +
                           "WHERE MaNV = :MaNV";
            OracleParameter[] parameters = {
                new OracleParameter(":TenNV", tl.TenNV),
                new OracleParameter(":TuNgay", tl.TuNgay),
                new OracleParameter(":DenNgay", tl.DenNgay),
                new OracleParameter(":SoNgayCong", tl.SoNgayCong),
                new OracleParameter(":LuonngCB", tl.LuonngCB),
                new OracleParameter(":TongBaoHiem", tl.TongBaoHiem),
                new OracleParameter(":TongTienThuong", tl.TongTienThuong),
                new OracleParameter(":TongTienPhat", tl.TongTienPhat),
                new OracleParameter(":TongLuong", tl.TongLuong),
                new OracleParameter(":MaNV", tl.MaNV)
            };
            int result = DataConnection.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public DataTable LoadTienThuong(string maNV, string ngayBatDau, DateTime ngayKetThuc)
        {
            string query = "SELECT SUM(TienThuong) AS TotalTienThuong FROM DSKhenThuong " +
                           "WHERE MaNV = :MaNV AND NgayThuong BETWEEN TO_DATE(:NgayBatDau, 'DD/MM/YYYY') AND :NgayKetThuc";
            OracleParameter[] parameters = {
        new OracleParameter(":MaNV", maNV),
        new OracleParameter(":NgayBatDau", ngayBatDau),
        new OracleParameter(":NgayKetThuc", ngayKetThuc)
    };

            OracleDataReader reader = DataConnection.Instance.LoadData(query, parameters);
            DataTable dataTable = new DataTable();

            // Load data from OracleDataReader into DataTable
            dataTable.Load(reader);

            // Close the OracleDataReader after loading data
            reader.Close();

            return dataTable;
        }
        public DataTable LoadTienPhat(string maNV, string ngayBatDau, DateTime ngayKetThuc)
        {
            string query = "SELECT SUM(TienPhat) AS TotalTienPhat FROM DSKyLuat " +
                           "WHERE MaNV = :MaNV AND NgayKyLuat BETWEEN TO_DATE(:NgayBatDau, 'DD/MM/YYYY') AND :NgayKetThuc";
            OracleParameter[] parameters = {
        new OracleParameter(":MaNV", maNV),
        new OracleParameter(":NgayBatDau", ngayBatDau),
        new OracleParameter(":NgayKetThuc", ngayKetThuc)
    };

            OracleDataReader reader = DataConnection.Instance.LoadData(query, parameters);
            DataTable dataTable = new DataTable();

            // Load data from OracleDataReader into DataTable
            dataTable.Load(reader);

            // Close the OracleDataReader after loading data
            reader.Close();

            return dataTable;
        }
        public DataTable LoadTienBH(string maNV)
        {
            string query = "SELECT SUM(PhiBaoHiem) AS TotalPhiBaoHiem FROM DSBaoHiem WHERE MaNV = :MaNV";
            OracleParameter[] parameters = {
        new OracleParameter(":MaNV", OracleDbType.Varchar2) { Value = maNV }
    };

            OracleDataReader reader = DataConnection.Instance.LoadData(query, parameters);
            DataTable dataTable = new DataTable();

            // Load data from OracleDataReader into DataTable
            dataTable.Load(reader);

            // Close the OracleDataReader after loading data
            reader.Close();

            return dataTable;
        }



        public DataTable LoadNgayLamViec(string maNV, string ngayBatDau, DateTime ngayKetThuc)
        {
            string query = "SELECT COUNT(MaNV) AS TotalNgayLamViec FROM ChamCong " +
                           "WHERE MaNV = :MaNV AND NgayCham BETWEEN TO_DATE(:NgayBatDau, 'DD/MM/YYYY HH24:MI:SS') AND :NgayKetThuc";
            OracleParameter[] parameters = {
        new OracleParameter(":MaNV", maNV),
        new OracleParameter(":NgayBatDau", ngayBatDau),
        new OracleParameter(":NgayKetThuc", ngayKetThuc)
    };

            OracleDataReader reader = DataConnection.Instance.LoadData(query, parameters);
            DataTable dataTable = new DataTable();

            // Load data from OracleDataReader into DataTable
            dataTable.Load(reader);

            // Close the OracleDataReader after loading data
            reader.Close();

            return dataTable;
        }

        // Add similar adjustments to other methods...
    }
}
        // code check nhân viên thai sản
        //public bool CheckNVThaiSan(string maNV, string ngayBatDau, string ngayKetThuc)
        //{
        //    string query = string.Format($"exec sp_CheckNVThaiSan '{maNV}', '{ngayBatDau}', '{ngayKetThuc}'");
        //    return DataConnection.Instance.CheckExist(query);
        //}

