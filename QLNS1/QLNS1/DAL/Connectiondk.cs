using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    class Connectiondk
    {
        public static OracleConnection ChuoiKetNoi()
        {
            OracleConnection Conn = new OracleConnection("User Id=QLNhansu1;Password=qlns;Data Source=localhost;");
            return Conn;
        }
    }
}
