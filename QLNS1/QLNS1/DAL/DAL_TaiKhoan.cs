using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data;
using DTO;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class DAL_TaiKhoan
    {
        //Lấy dữ liệu hiển thị
        public DataTable GetData()
        {
            DataTable dt = DataConnection.Instance.ExecuteQuery("select UserName, DisplayName, Type from Account");
            return dt;
        }
        // Lấy thông tin tài khoản username
        public DTO_Accounts GetAccountByUserName(string userName)
        {
            DataTable data = DataConnection.Instance.ExecuteQuery("select * from Account where UserName = '" + userName + "'");
            foreach (DataRow item in data.Rows)
            {
                return new DTO_Accounts(item);
            }
            return null;
        }
        // Lấy dữ liệu Account
        public DataTable GetListAccount()
        {
            return DataConnection.Instance.ExecuteQuery("select * from Account");
        }
      

        // Code sử lý đổi thông tin và mật khẩu
           public bool ChangeAccount(string userName, string displayname, string password, string newpassword)
           {
               try
               {
                   using (OracleConnection connection = Connectiondk.ChuoiKetNoi())
                   {
                       connection.Open();

                       using (OracleCommand command = new OracleCommand("sp_ChangeAccount", connection))
                       {
                           command.CommandType = CommandType.StoredProcedure;
                           command.Parameters.Add("userName", OracleDbType.NVarchar2).Value = userName;
                           command.Parameters.Add("displayname", OracleDbType.NVarchar2).Value = displayname;
                           command.Parameters.Add("password", OracleDbType.NVarchar2).Value = password;
                           command.Parameters.Add("newpassword", OracleDbType.NVarchar2).Value = newpassword;

                           int result = command.ExecuteNonQuery();
                           return result > 0;
                       }
                   }
               }
               catch (Exception ex)
               {
                   // Handle exceptions appropriately (log or throw)
                   Console.WriteLine($"Error in ChangeAccount: {ex.Message}");
                   return false;
               }
           }



        // Code sử lý đăng nhập và mã hóa mật khẩu
         public bool Login(string userName, string password)
           {
               try
               {
                   using (OracleConnection connection = Connectiondk.ChuoiKetNoi())
                   {
                       //connection.Open();
                       string sp_LoginAccount = string.Format($"select * from Account where USERNAME = '{userName}'");
                       return DataConnection.Instance.CheckExist(sp_LoginAccount);
                    //using (OracleCommand command = new OracleCommand("sp_LoginAccount", connection))
                    //{
                    //    command.CommandType = CommandType.StoredProcedure;
                    //    command.Parameters.Add("userName", OracleDbType.NVarchar2).Value = userName;
                    //    command.Parameters.Add("password", OracleDbType.NVarchar2).Value = password;

                    //    using (OracleDataReader reader = command.ExecuteReader())
                    //    {
                    //        return reader.HasRows;
                    //    }
                    //}
                }
               }
               catch (Exception ex)
               {
                   // Handle exceptions appropriately (log or throw)
                   Console.WriteLine($"Error in Login: {ex.Message}");
                   return false;
               }
           }

           private string HashPassword(string password)
           {
               using (SHA256 sha256 = SHA256.Create())
               {
                   byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                   return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
               }
           }


       

        // code sử lý thêm tài khoản
        public bool InsertAccount(DTO_Accounts ac)
        {
            string query = string.Format("insert into Account(UserName, DisplayName, Type)values(N'{0}', N'{1}', {2})", ac.UserName, ac.DisplayName, ac.Type);
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        // code sử lý sửa tài khoản
        public bool UpdateAccount(DTO_Accounts ac)
        {
            string query = string.Format("update Account set DisplayName= N'{0}', Type={1} where UserName='{2}'", ac.DisplayName, ac.Type, ac.UserName);
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        // code sử lý xóa tài khoản 
        public bool DeleteAccount(string userName)
        {
            string query = string.Format("delete Account where UserName=N'{0}'", userName);
            int result = DataConnection.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        // code check Account với UserName truyền vào
        public bool CheckAccount(string userName)
        {
            string query = string.Format($"select * from Account where UserName = '{userName}'");
            return DataConnection.Instance.CheckExist(query);
        }
    }
}