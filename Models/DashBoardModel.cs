using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w1673746.Models
{
    class DashBoardModel
    {
        public DataTable executeGetIncomeTypeOverview(int id)
        {
            string incomeSQL = "SELECT paymentType, count(income_ID) as Total from incomeTB where user_ID = '" + id + "' group by paymentType order by paymentType asc";
            DataTable incomeData = Connection.DbConnection.executeSQL(incomeSQL);
            return incomeData;
        }

        public DataTable executeGetExpenseTypeOverview(int id)
        {

            string expenseSQL = "SELECT expenseType, count(expense_ID) as Total FROM expenseTB where user_ID = '" + id + "' group by expenseType order by expenseType asc";
            DataTable expenseData = Connection.DbConnection.executeSQL(expenseSQL);
            return expenseData;

        }
    }
}
