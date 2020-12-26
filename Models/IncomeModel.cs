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
        public DataTable executeAddIncome(string sas)
        {
            string sqlServer = string.Empty;
            sqlServer += "INSERT INTO incomeTB (user_ID,contact_ID,income_ID,paymentForm,paymentDescription,paymentType,amout,IncomeDate)";
            sqlServer += "VALUES('" + sas + "')";
            DataTable userData = Connection.DbConnection.executeSQL(sqlServer);
            return userData;
        }

        public DataTable executeDisplayPaymentFromList(int id)
        {
            string incomeSQL = "SELECT contact_ID, first_Name AS Payment_From FROM contactTB WHERE user_ID = '" + id + "'";
            DataTable incomeData = Connection.DbConnection.executeSQL(incomeSQL);
            return incomeData;
        }
    }
}

