using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w1673746.Models
{
    class ExpenseModel
    {
        //add expense query
        public DataTable executeAddExpense(string description, string type, DateTime date, float amount, int user_id, int con_id)
        {
            string sqlServer = string.Empty;
            sqlServer += "INSERT INTO expenseTB (user_ID,contact_ID,expenseDescription,expenseType,amount,expenseDate)";
            sqlServer += "VALUES('" + user_id + "','" + con_id + "','" + description + "','" + type + "','" + amount + "','" + date + "')";
            DataTable userData = Connection.DbConnection.executeSQL(sqlServer);
            return userData;
        }
        //get the contact name from contact DB
        public DataTable executeDisplayPaymentToList(int id)
        {
            string expenseSQL = "SELECT contact_ID, first_Name AS Payment_From FROM contactTB WHERE user_ID = '" + id + "'";
            DataTable expenseData = Connection.DbConnection.executeSQL(expenseSQL);
            return expenseData;
        }
        //get the all the expenses by id
        public DataTable executeAllExpense(int id)
        {
            string sqlServer = "SELECT i.expense_ID, c.first_Name AS Payment_From, i.expenseDescription, i.expenseType, i.expenseDate, i.amount FROM expenseTB AS i INNER JOIN contactTB AS c ON i.contact_ID = c.contact_ID WHERE i.user_ID = '" + id + "'";
            DataTable userData = Connection.DbConnection.executeSQL(sqlServer);
            return userData;
        }
        //search query for expenses
        public DataTable executeSearchExpense(string name)
        {
            string sqlServer = "SELECT i.expense_ID, c.first_Name AS Payment_From, i.expenseDescription, i.expenseType, i.expenseDate,i.amount FROM expenseTB AS i INNER JOIN contactTB AS c ON i.contact_ID = c.contact_ID WHERE c.first_Name LIKE '" + name + "%'";
            DataTable expenseData = Connection.DbConnection.executeSQL(sqlServer);
            return expenseData;
        }
        //Delete query for expense
        public DataTable executeDeleteExpense(object id)
        {

            string sqlServer = "DELETE FROM expenseTB WHERE expense_ID = '" + id + "'";
            DataTable expenseData = Connection.DbConnection.executeSQL(sqlServer);
            return expenseData;

        }
        //display expense information by given id
        public DataTable executeDisplayExpenseById(int id)
        {
            string sqlServer = "SELECT expenseDescription, expenseType,expenseDate, amount, c.first_Name AS Payment_From, i.contact_ID FROM expenseTB AS i INNER JOIN contactTB AS c ON i.contact_ID = c.contact_ID WHERE expense_ID = '" + id + "'";
            DataTable expenseData = Connection.DbConnection.executeSQL(sqlServer);
            return expenseData;
        }



        //update expense query
        public DataTable executeUpdateExpense(string description, string type, DateTime date, float amount, int conId, int expenseId)
        {
            string expenseSQL = "UPDATE expenseTB SET expenseDescription = '" + description + "',expenseType ='" + type + "',expenseDate = '" + date + "',  amount = '" + amount + "', contact_ID = '" + conId + "' WHERE expense_ID = '" + expenseId + "'";
            DataTable expenseData = Connection.DbConnection.executeSQL(expenseSQL);
            return expenseData;
        }

    }
}
