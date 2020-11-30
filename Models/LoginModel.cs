using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w1673746.Models

{
    class LoginModel
    {
        public DataTable executeLoginSQL(string name, string pass)
        {
            //Console.WriteLine("name is " + name);

            string sqlServer = string.Empty;
            sqlServer = "SELECT * FROM loginTB  WHERE username = '" + name + "' AND password = '" + pass + "'";

            DataTable userData = Connection.DbConnection.executeSQL(sqlServer);
            return userData;



        }
    }
}
