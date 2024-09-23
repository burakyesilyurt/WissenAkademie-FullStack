using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataAccessLayer
    {
        public SqlConnection OpenConnection()
        {
            SqlConnection conn = new SqlConnection
                ("Data Source=DESKTOP-5789TGK\\MSSQL2022;Initial Catalog=NORTHWIND;User ID=sa;Password=123qweasdzxc..;TrustServerCertificate=true");

            if(conn.State == ConnectionState.Closed)
                conn.Open();

            return conn;
        }


        public void CloseConnection(SqlConnection conn) 
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public SqlCommand ExecuteCommand(string command)
        {
            SqlConnection conn = OpenConnection();
            SqlCommand cmd = new SqlCommand(command, conn);
            //CloseConnection(conn);
            return cmd;
        }
    }
}
