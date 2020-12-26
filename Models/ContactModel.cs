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
            string sqlServer = "SELECT contact_ID,first_Name,job_role,phone_no,address FROM contactTB WHERE user_ID='" + id + "'";
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

        public DataTable executeDisplayContactById(int id)
        {
            string sqlServer = "SELECT contact_ID, first_Name, last_Name, phone_no, job_role, address FROM contactTB WHERE contact_ID = '" + id + "'";
            DataTable contactData = Connection.DbConnection.executeSQL(sqlServer);
            return contactData;
        }

        public DataTable executeUpdateContact(string first_Name, string last_Name, string phone_no, string job_role, string address, int id)
        {
            string contactSQL = "UPDATE contactTB SET first_Name = '" + first_Name + "', last_Name = '" + last_Name + "', phone_no = '" + phone_no + "', job_role = '" + job_role + "',  address = '" + address + "' WHERE contact_ID = '" + id + "'";
            DataTable contactData = Connection.DbConnection.executeSQL(contactSQL);
            return contactData;
        }

        public DataTable executeSearchContact(string name)
        {
            string contactSQL = "SELECT * FROM contactTB WHERE first_Name LIKE '" + name + "%'";
            DataTable contactData = Connection.DbConnection.executeSQL(contactSQL);
            return contactData;
        }



    }
}
