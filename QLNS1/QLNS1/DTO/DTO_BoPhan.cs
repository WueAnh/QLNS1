using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_BoPhan
    {
        private string maBP;
        private string tenBP;
        private string ngayTL;
        private string ghiChu;

        public DTO_BoPhan(string maBP, string tenBP, string ngayTL, string ghiChu)
        {
            MaBP = maBP;
            TenBP = tenBP;
            NgayTL = ngayTL;
            GhiChu = ghiChu;
        }

        public string MaBP { get => maBP; set => maBP = value; }
        public string TenBP { get => tenBP; set => tenBP = value; }
        public string NgayTL { get => ngayTL; set => ngayTL = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
