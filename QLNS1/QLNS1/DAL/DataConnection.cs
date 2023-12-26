using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
 

    public class DataConnection
    {
        private static string connectionString = "User Id=QLNhansu1;Password=qlns;Data Source=localhost;";
        private static DataConnection instance;

        public static DataConnection Instance
        {
            get { if (instance == null) instance = new DataConnection(); return DataConnection.instance; }
            private set { DataConnection.instance = value; }
        }

        public DataTable ExecuteQuery(string query, OracleParameter[] parameters = null)
        {
            DataTable data = new DataTable();

            using (OracleConnection connection = Connectiondk.ChuoiKetNoi())
            {
                connection.Open();

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        adapter.Fill(data);
                    }
                }

                connection.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query, OracleParameter[] parameters = null)
        {
            int data = 0;

            using (OracleConnection connection = Connectiondk.ChuoiKetNoi())
            {
                connection.Open();

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    data = command.ExecuteNonQuery();
                }

                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, OracleParameter[] parameters = null)
        {
            object data = 0;

            using (OracleConnection connection = Connectiondk.ChuoiKetNoi())
            {
                connection.Open();

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    data = command.ExecuteScalar();
                }

                connection.Close();
            }

            return data;
        }

        public bool CheckExist(string query, OracleParameter[] parameters = null)
        {
            using (OracleConnection connection = Connectiondk.ChuoiKetNoi())
            {
                connection.Open();

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    using (OracleDataReader dr = command.ExecuteReader())
                    {
                        return dr.Read();
                    }
                }
            }
        }

        public OracleDataReader LoadData(string query, OracleParameter[] parameters = null)
        {
            OracleConnection con = Connectiondk.ChuoiKetNoi();
            con.Open();

            using (OracleCommand cmd = new OracleCommand(query, con))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                OracleDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return dr;
            }
        }
    }
}
