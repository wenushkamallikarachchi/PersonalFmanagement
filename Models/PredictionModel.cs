using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w1673746.Models
{
    class PredictionModel
    {
        public DataTable executeGetTotalExpensesDateRange(int id, DateTime startDate, DateTime endDate)
        {
            string expenseSQL = "SELECT SUM(amount) as Total from expenseTB where expenseDate BETWEEN '" + startDate + "' AND '" + endDate + "' AND user_ID = '" + id + "'";
            DataTable expenseData = Connection.DbConnection.executeSQL(expenseSQL);
            return expenseData;

        }

    }
}
