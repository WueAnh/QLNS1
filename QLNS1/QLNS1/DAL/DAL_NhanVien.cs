using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using DAL;
using System.Data;

namespace DAL
{
   public class DAL_NhanVien
    {
        public DataTable GetData()
        {
            DataTable dt = DataConnection.Instance.ExecuteQuery("select * from NhanVien");
            return dt;
        }
        // lay thong tin nhan vien thong qua tai khoan
        public DTO_NhanVien GetNhanVienByUserName(string userName)
        {
            DataTable data = DataConnection.Instance.ExecuteQuery("select * from NhanVien where UserName = '" + userName + "'");
            foreach (DataRow item in data.Rows)
            {
                return new DTO_NhanVien(item);
            }
            return null;
        }
        //code thêm Nhân Viên
        public bool InsertNhanVien(DTO_NhanVien nv)
        {
            string query = string.Format("insert into NhanVien(MaNV,TenNV,gioiTinh,ngaySinh,queQuan,sDT,diaChi,cmnd,email,tenTDHV,cNganh,ChucVu,TinhTrang,NgayVaolam,UserName,maPhong,maBP)values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',{5},N'{6}',{7},N'{8}',N'{9}',N'{10}',N'{11}',N'{12}',N'{13}',N'{14}',N'{15}',N'{16}')", nv.MaNV,nv.TenNV,nv.GioiTinh,nv.NgaySinh,nv.QueQuan,nv.SDT,nv.DiaChi,nv.Cmnd,nv.Email,nv.TenTDHV,nv.CNganh,nv.ChucVu,nv.TinhTrang,nv.NgayVaoLam,nv.UserName,nv.MaPhong,nv.MaBP);
            int result = DataConnection.Instance.ExecuteNonQuery(query); // sửa lại cho đúng đi lol chỗ nào sql viet hoa viet thuong gi cung nhan ma, chạy thử coi
            return result > 0;
        }
        //code sửa Nhân Viên
        public bool UpdateNhanVien(DTO_NhanVien nv)
        {
            string query = string.Format($"update NhanVien set  tenNV= N'{nv.TenNV}', gioiTinh= N'{nv.GioiTinh}',ngaySinh='{nv.NgaySinh}', queQuan= N'{nv.QueQuan}', sDT={nv.SDT},diaChi = N'{nv.DiaChi}',cmnd={nv.Cmnd},email= N'{nv.Email}',tenTDHV= N'{nv.TenTDHV}',cNganh= N'{nv.CNganh}',ChucVu= N'{nv.ChucVu}',TinhTrang= N'{nv.TinhTrang}',ngayvaolam='{nv.NgayVaoLam}',UserName='{nv.UserName}',maPhong='{nv.MaPhong}',maBP='{nv.MaBP}'where maNV='{nv.MaNV}'" );
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        // code xóa Nhân viên
        public bool DeleteNhanVien(string maNV)
        {
            string query = string.Format("delete NhanVien where MaNV=N'{0}'", maNV);
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //code check NhanVien với UserName truyền vào
        public bool CheckMaNVByUserName(string userName)
        {
            string query = string.Format($"select * from NhanVien where UserName = N'{userName}'");
            return DataConnection.Instance.CheckExist(query);
        }
        // check NhanVien với MaNV truyền vào
        public bool CheckMaNV(string maNV)
        {
            string query = string.Format($"select * from NhanVien where MaNV = N'{maNV}'");
            return DataConnection.Instance.CheckExist(query);
        }
    }
}
