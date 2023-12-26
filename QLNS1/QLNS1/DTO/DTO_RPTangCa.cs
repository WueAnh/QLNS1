using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_RPTangCa
    {
        private int maCC;
        private string userName;
        private string maNV;
        private string tenNV;
        private string ngayCham;
        private string gioVao;
        private string statusIn;
        private string gioRa;
        private string statusOut;
        private string diTre;
        private string gioLamThem;

        public DTO_RPTangCa(int maCC, string userName, string maNV, string tenNV, string ngayCham, string gioVao, string statusIn, string gioRa, string statusOut, string diTre, string gioLamThem)
        {
            MaCC = maCC;
            UserName = userName;
            MaNV = maNV;
            TenNV = tenNV;
            NgayCham = ngayCham;
            GioVao = gioVao;
            StatusIn = statusIn;
            GioRa = gioRa;
            StatusOut = statusOut;
            DiTre = diTre;
            GioLamThem = gioLamThem;
        }

        public int MaCC { get => maCC; set => maCC = value; }
        public string UserName { get => userName; set => userName = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string NgayCham { get => ngayCham; set => ngayCham = value; }
        public string GioVao { get => gioVao; set => gioVao = value; }
        public string StatusIn { get => statusIn; set => statusIn = value; }
        public string GioRa { get => gioRa; set => gioRa = value; }
        public string StatusOut { get => statusOut; set => statusOut = value; }
        public string DiTre { get => diTre; set => diTre = value; }
        public string GioLamThem { get => gioLamThem; set => gioLamThem = value; }
    }
}
