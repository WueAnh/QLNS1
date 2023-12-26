using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChamCong
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

        public DTO_ChamCong(DataRow row)
        {
            this.MaCC = int.Parse(row["MaCC"].ToString());
            this.UserName = row["UserName"].ToString();
            this.MaNV = row["MaNV"].ToString();
            this.TenNV = row["TenNV"].ToString();
            this.NgayCham = row["NgayCham"].ToString();
            this.GioVao = row["GioVao"].ToString();
            this.StatusIn = row["StatusIn"].ToString();
            this.GioRa = row["GioRa"].ToString();
            this.StatusOut = row["StatusOut"].ToString();
            this.DiTre = row["DiTre"].ToString();


        }

        public DTO_ChamCong(int maCC, string userName, string maNV, string tenNV, string ngayCham, string gioVao, string statusIn, string giora, string statusOut, string diTre)
        {
            MaCC = maCC;
            UserName = userName;
            MaNV = maNV;
            TenNV = tenNV;
            NgayCham = ngayCham;
            GioVao = gioVao;
            StatusIn = statusIn;
            GioRa = giora;
            StatusOut = statusOut;
            DiTre = diTre;
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
    }
}
