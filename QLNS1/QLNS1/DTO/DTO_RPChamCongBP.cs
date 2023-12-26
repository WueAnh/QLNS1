using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     class DTO_RPChamCongBP
    {
        private string maNV;
        private string maBP;
        private string tenNV;
        private string tenBP;
        private string ngayCham;

        public string MaNV { get => maNV; set => maNV = value; }
        public string MaBP { get => maBP; set => maBP = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string TenBP { get => tenBP; set => tenBP = value; }
        public string NgayCham { get => ngayCham; set => ngayCham = value; }
    }
}
