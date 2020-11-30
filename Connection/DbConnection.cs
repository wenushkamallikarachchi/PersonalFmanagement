using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace w1673746.Connection
{
    class DbConnection
    {
        public static string stringConnection = "Data Source=DESKTOP-0RFPAEU;Initial Catalog=PersonalDB;Integrated Security=True";
        public static DataTable executeSQL(string sql)
        {

            SqlConnection con = new SqlConnection();
            SqlDataAdapter adapter = default(SqlDataAdapter);
            DataTable dt = new DataTable();

            try
            {
                con.ConnectionString = stringConnection;
                con.Open();

                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dt);
                con.Close();
                con = null;
                return dt;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("There is a problem called " + e.Message, "SQL Server Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
            }
            return dt;
        }
    }
}
