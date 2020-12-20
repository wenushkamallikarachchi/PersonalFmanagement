using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w1673746.Models
{
    class ContactModel
    {
        public DataTable executeAllUserData(int id)
        {
            string sqlServer = "SELECT first_Name,job_role,phone_no,address FROM contactTB WHERE user_ID='" + id + "'";
            DataTable userData = Connection.DbConnection.executeSQL(sqlServer);
            return userData;
        }

        public DataTable executeDeleteUserData(object name)
        {
            Console.WriteLine(name);
            string sqlServer = "DELETE FROM contactTB WHERE first_Name = '" + name + "'";
            DataTable userData = Connection.DbConnection.executeSQL(sqlServer);
            return userData;
        }

        public DataTable executeAddContact(string first_name, string last_name, string phNumber, string job, string address, int id)
        {
            string sqlServer = string.Empty;
            sqlServer += "INSERT INTO contactTB (first_Name,last_Name,phone_No,address,job_role,user_ID)";
            sqlServer += "VALUES ('" + first_name + "','" + last_name + "','" + phNumber + "','" + address + "','" + job + "','" + id + "')";

            DataTable addContactData = Connection.DbConnection.executeSQL(sqlServer);
            return addContactData;
        }
    }
}
