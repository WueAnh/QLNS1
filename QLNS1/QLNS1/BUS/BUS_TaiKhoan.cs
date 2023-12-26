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
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan dalTaiKhoan = new DAL_TaiKhoan();
        public DataTable GetAllAccount()
        {
            return dalTaiKhoan.GetData();
        }
        public bool Login(string userName, string password)
        {
            return dalTaiKhoan.Login(userName, password);
        }
        public DTO_Accounts GetAccountByUserName(string userName)
        {
            return dalTaiKhoan.GetAccountByUserName(userName);
        }
        public bool ChangeAccount(string userName, string displayname, string password, string newpassword)
        {
            return dalTaiKhoan.ChangeAccount(userName, displayname, password, newpassword);
        }
        public DataTable GetListAccount()
        {
            return dalTaiKhoan.GetListAccount();
        }
        public bool CheckAccount(string userName)
        {
            return dalTaiKhoan.CheckAccount(userName);
        }
        public bool InsertAccount(DTO_Accounts ac)
        {
            return dalTaiKhoan.InsertAccount(ac);
        }
        public bool UpdateAccount(DTO_Accounts ac)
        {
            return dalTaiKhoan.UpdateAccount(ac);
        }
        public bool DeleteAccount(string userName)
        {
            return dalTaiKhoan.DeleteAccount(userName);
        }
    }
}