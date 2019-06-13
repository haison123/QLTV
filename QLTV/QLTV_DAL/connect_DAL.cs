using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLTV_DAL
{
    public class connect_DAL
    {
        static string provider = @"Data Source=.\SQLEXPRE;Initial Catalog=QL_library;Integrated Security=True";
        SqlConnection connect = new SqlConnection(provider);

        public DataTable getdata(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(dt);
            return dt;
        }

        public void Execute(string sql)
        {
            connect.Open();
            SqlCommand command = new SqlCommand(sql, connect);
                command.ExecuteNonQuery();
            connect.Close();
        }
    }
}
