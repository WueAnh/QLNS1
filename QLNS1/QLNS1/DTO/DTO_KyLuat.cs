using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KyLuat
    {
        private string maKyLuat;
        private string maNV;
        private string tenNV;
        private string ngayKyLuat;
        private string lyDo;
        private string hinhThuc;
        private float tienPhat;

        public DTO_KyLuat(string maKyLuat, string maNV, string tenNV, string ngayKyLuat, string lyDo, string hinhThuc, float tienPhat)
        {
            this.MaKyLuat = maKyLuat;
            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.NgayKyLuat = ngayKyLuat;
            this.LyDo = lyDo;
            this.HinhThuc = hinhThuc;
            this.TienPhat = tienPhat;
        }
        public DTO_KyLuat(DataRow row)
        {
            this.MaKyLuat = row["MaKyLuat"].ToString();
            this.MaNV = row["MaNV"].ToString();
            this.TenNV = row["TenNV"].ToString();
            this.NgayKyLuat = row["NgayKyLuat"].ToString();
            this.LyDo = row["LyDo"].ToString();
            this.HinhThuc = row["HinhThuc"].ToString();
            this.TienPhat = float.Parse(row["TienPhat"].ToString());
        }

        public string MaKyLuat { get => maKyLuat; set => maKyLuat = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string NgayKyLuat { get => ngayKyLuat; set => ngayKyLuat = value; }
        public string LyDo { get => lyDo; set => lyDo = value; }
        public string HinhThuc { get => hinhThuc; set => hinhThuc = value; }
        public float TienPhat { get => tienPhat; set => tienPhat = value; }
    }
}
