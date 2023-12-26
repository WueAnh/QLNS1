using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_RPNhanVienDiTre
    {
        private string maNV;
        private string tenNV;
        private string ngayCham;
        private string gioVao;
        private string diTre;

        public DTO_RPNhanVienDiTre(string maNV, string tenNV, string ngayCham, string gioVao, string diTre)
        {
            MaNV = maNV;
            TenNV = tenNV;
            NgayCham = ngayCham;
            GioVao = gioVao;
            DiTre = diTre;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string NgayCham { get => ngayCham; set => ngayCham = value; }
        public string GioVao { get => gioVao; set => gioVao = value; }
        public string DiTre { get => diTre; set => diTre = value; }
    }
}
