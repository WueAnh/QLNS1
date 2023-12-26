using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_BaoHiem
    {
        DAL_BaoHiem dalBaoHiem = new DAL_BaoHiem();
        public DataTable GetData()
        {
            return dalBaoHiem.GetData();
        }
        public List<DTO_BaoHiem> ListAllBaoHiem()
        {
            return dalBaoHiem.ListAllBaoHiem();
        }
        public bool InsertBaoHiem(DTO_BaoHiem bh)
        {
            return dalBaoHiem.InsertBaoHiem(bh);
        }
        public bool UpdateBaoHiem(DTO_BaoHiem bh)
        {
            return dalBaoHiem.UpdateBaoHiem(bh);
        }
        public bool DeleteBaoHiem(string maBH)
        {
            return dalBaoHiem.DeleteBaoHiem(maBH);
        }
        public bool CheckMaBH(string maBH)
        {
            return dalBaoHiem.CheckMaBH(maBH);
        }
        public bool CheckBHIsExists(string maNV, string loaiBH, string tuNgay, DateTime denNgay)
        {
            return dalBaoHiem.CheckBHIsExists(maNV, loaiBH, tuNgay, denNgay);
        }
    }
}
