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
        public DataTable executeIsDup(string name)
        {
            string isDup = "SELECT Username FROM loginTB where Username='" + name + "'";
            DataTable userDataCheckDup = Connection.DbConnection.executeSQL(isDup);
            return userDataCheckDup;
        }
        public DataTable executeRegSQL(string fname, string lname, string mail, string phNo, string username, string password)
        {
            //Console.WriteLine("name is " + name);

            string sqlServer = string.Empty;
            sqlServer += "INSERT INTO loginTB (first_name,last_name,email,phone_no,username,password)";
            sqlServer += "VALUES ('" + fname + "','" + lname + "','" + mail + "','" + phNo + "','" + username + "','" + password + "')";

            DataTable regUserData = Connection.DbConnection.executeSQL(sqlServer);
            return regUserData;
        }
    }
}
