using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w1673746.Models
{
    class IncomeModel
    {
        //add income query
        public DataTable executeAddIncome(string description, string type, DateTime date, float amount, int user_id, int con_id)
        {
            string sqlServer = string.Empty;
            sqlServer += "INSERT INTO incomeTB (user_ID,contact_ID,paymentDescription,paymentType,amount,IncomeDate)";
            sqlServer += "VALUES('" + user_id + "','" + con_id + "','" + description + "','" + type + "','" + amount + "','" + date + "')";
            DataTable userData = Connection.DbConnection.executeSQL(sqlServer);
            return userData;
        }
        //get the payment from by given id
        public DataTable executeDisplayPaymentFromList(int id)
        {
            string incomeSQL = "SELECT contact_ID, first_Name AS Payment_From FROM contactTB WHERE user_ID = '" + id + "'";
            DataTable incomeData = Connection.DbConnection.executeSQL(incomeSQL);
            return incomeData;
        }
        //get all the incomes
        public DataTable executeAllIncome(int id)
        {
            string sqlServer = "SELECT i.income_ID, c.first_Name AS Payment_From, i.paymentDescription, i.paymentType, i.IncomeDate, i.amount FROM incomeTB AS i INNER JOIN contactTB AS c ON i.contact_ID = c.contact_ID WHERE i.user_ID = '" + id + "'";
            DataTable userData = Connection.DbConnection.executeSQL(sqlServer);
            return userData;
        }
        //search income by given id
        public DataTable executeSearchIncome(string name, int id)
        {
            string sqlServer = "SELECT i.income_ID, c.first_Name AS Payment_From, i.paymentDescription, i.paymentType, i.IncomeDate, i.amount FROM incomeTB AS i INNER JOIN contactTB AS c ON i.contact_ID = c.contact_ID WHERE c.first_Name LIKE '" + name + "%' AND i.user_ID='" + id + "'";
            DataTable incomeData = Connection.DbConnection.executeSQL(sqlServer);
            return incomeData;
        }

        //delete income by given id
        public DataTable executeDeleteIncome(object id)
        {
            string sqlServer = "DELETE FROM incomeTB WHERE income_ID = '" + id + "'";
            DataTable incomeData = Connection.DbConnection.executeSQL(sqlServer);
            return incomeData;
        }
        //update income 
        public DataTable executeUpdateIncome(string description, string type, DateTime date, float amount, int conId, int incomeId)
        {
            string incomeSQL = "UPDATE incomeTB SET paymentDescription = '" + description + "',paymentType ='" + type + "',IncomeDate = '" + date + "',  amount = '" + amount + "', contact_ID = '" + conId + "' WHERE income_ID = '" + incomeId + "'";
            DataTable incomeData = Connection.DbConnection.executeSQL(incomeSQL);
            return incomeData;
        }
        //display income by given id
        public DataTable executeDisplayIncomeById(int id)
        {
            string sqlServer = "SELECT paymentDescription, paymentType,IncomeDate, amount, c.first_Name AS Payment_From, i.contact_ID FROM incomeTB AS i INNER JOIN contactTB AS c ON i.contact_ID = c.contact_ID WHERE income_ID = '" + id + "'";
            DataTable incomeData = Connection.DbConnection.executeSQL(sqlServer);
            return incomeData;

        }

    }
}

