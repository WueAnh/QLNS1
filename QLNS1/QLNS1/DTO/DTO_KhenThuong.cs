using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class DTO_KhenThuong
    {
        private string maThuong;
        private string maNV;
        private string tenNV;
        private string ngayThuong;
        private string lyDo;
        private string hinhThuc;
        private float tienThuong;

        public DTO_KhenThuong(DataRow row)
        {
            this.MaThuong = row["MaThuong"].ToString();
            this.MaNV = row["MaNV"].ToString();
            this.TenNV = row["TenNV"].ToString();
            this.NgayThuong = row["NgayThuong"].ToString();
            this.LyDo = row["LyDo"].ToString();
            this.HinhThuc = row["HinhThuc"].ToString();
            this.TienThuong = float.Parse(row["TienThuong"].ToString());
        }

        public DTO_KhenThuong(string maThuong, string maNV, string tenNV, string ngayThuong, string lyDo, string hinhThuc, float tienThuong)
        {
            MaThuong = maThuong;
            MaNV = maNV;
            TenNV = tenNV;
            NgayThuong = ngayThuong;
            LyDo = lyDo;
            HinhThuc = hinhThuc;
            TienThuong = tienThuong;
        }

        public string MaThuong { get => maThuong; set => maThuong = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string NgayThuong { get => ngayThuong; set => ngayThuong = value; }
        public string LyDo { get => lyDo; set => lyDo = value; }
        public string HinhThuc { get => hinhThuc; set => hinhThuc = value; }
        public float TienThuong { get => tienThuong; set => tienThuong = value; }
    }
}
