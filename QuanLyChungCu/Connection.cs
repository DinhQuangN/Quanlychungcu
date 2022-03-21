using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu
{
    class Connection
    {
        public static string conn = @"Data Source=DINHQUANG\SQLEXPRESS;Initial Catalog=QLCC;User ID=sa; Password=123456";
        public static DataTable select(string sql)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                using (SqlDataAdapter dad = new SqlDataAdapter(sql, con))
                {
                    using (DataSet dst = new DataSet())
                    {
                        dad.Fill(dst);
                        return dst.Tables[0];
                    }
                }
            }
        }
        public static void inupde(string sql)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.CommandType = CommandType.Text;
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                con.Close();
                con.Dispose();
            }
        }
    }
}
