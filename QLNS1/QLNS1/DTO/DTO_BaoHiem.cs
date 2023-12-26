using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BaoHiem
    {
        private string maBH;
        private string maNV;
        private string tenNV;
        private string loaiBH;
        private string maTheBH;
        private string ngayCap;
        private string ngayHetHan;
        private string noiCap;
        private float phiBaoHiem;

        public DTO_BaoHiem(DataRow row)
        {
            this.MaBH = row["MaBH"].ToString();
            this.MaNV = row["MaNV"].ToString();
            this.TenNV = row["TenNV"].ToString();
            this.LoaiBH = row["LoaiBH"].ToString();
            this.MaTheBH = row["MaTheBH"].ToString();
            this.NgayCap = row["NgayCap"].ToString();
            this.NgayHetHan = row["NgayHetHan"].ToString();
            this.NoiCap = row["NoiCap"].ToString();
            this.PhiBaoHiem = float.Parse(row["PhiBaoHiem"].ToString());
        }

        public DTO_BaoHiem(string maBH, string maNV, string tenNV, string loaiBH, string maTheBH, string ngayCap, string ngayHetHan, string noiCap, float phiBaoHiem)
        {
            MaBH = maBH;
            MaNV = maNV;
            TenNV = tenNV;
            LoaiBH = loaiBH;
            MaTheBH = maTheBH;
            NgayCap = ngayCap;
            NgayHetHan = ngayHetHan;
            NoiCap = noiCap;
            PhiBaoHiem = phiBaoHiem;
        }

        public string MaBH { get => maBH; set => maBH = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string LoaiBH { get => loaiBH; set => loaiBH = value; }
        public string MaTheBH { get => maTheBH; set => maTheBH = value; }
        public string NgayCap { get => ngayCap; set => ngayCap = value; }
        public string NgayHetHan { get => ngayHetHan; set => ngayHetHan = value; }
        public string NoiCap { get => noiCap; set => noiCap = value; }
        public float PhiBaoHiem { get => phiBaoHiem; set => phiBaoHiem = value; }
        

        
    }
}
