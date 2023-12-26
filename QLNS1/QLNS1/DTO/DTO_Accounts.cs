using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
   public class DTO_Accounts
    {
        private string userName;
        private string displayName;
        private string password;
        private int type;


        public DTO_Accounts(DataRow row)
        {
            this.UserName = row["UserName"].ToString();
            this.DisplayName = row["DisplayName"].ToString();
            this.Password = row["Password"].ToString();
            this.Type = (int)decimal.Parse(row["Type"].ToString());
        }

        public DTO_Accounts(string userName, string displayName, string password, int type)
        {
            UserName = userName;
            DisplayName = displayName;
            Password = password;
            Type = type;
        }

        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string Password { get => password; set => password = value; }
        public int Type { get => type; set => type = value; }
    }
}
