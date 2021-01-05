using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w1673746.Models
{
    class ReportModel
    {
        //load all the report information by given id
        public DataTable executeDisplayAllReportData(int id)
        {
            string sqlServer = "SELECT report_ID,name,type,start_Date,end_Date,created FROM reportTB WHERE user_ID = '" + id + "'";
            DataTable reportData = Connection.DbConnection.executeSQL(sqlServer);
            return reportData;
        }
        //add query for report data
        public DataTable executeAddReportData(string name, string type, DateTime startDate, DateTime endDate, DateTime created, int id)
        {
            string reportSQL = string.Empty;
            reportSQL += "INSERT INTO reportTB (name, type, start_Date, end_Date, created, user_ID)";
            reportSQL += "VALUES ('" + name + "','" + type + "','" + startDate + "','" + endDate + "','" + created + "','" + id + "')";

            DataTable reportData = Connection.DbConnection.executeSQL(reportSQL);
            return reportData;
        }
        //

        public DataTable executeGetIncomeSummary(int id, DateTime startDate, DateTime endDate)
        {
            string reportSQL = "SELECT paymentType, SUM(amount) as Total_Amount FROM incomeTB WHERE user_ID = '" + id + "' AND IncomeDate BETWEEN '" + startDate + "' AND '" + endDate + "' group by paymentType order by paymentType asc";
            DataTable reportData = Connection.DbConnection.executeSQL(reportSQL);
            return reportData;
        }

        public DataTable executeGetExpenseSummary(int id, DateTime startDate, DateTime endDate)
        {
            string reportSQL = "SELECT expenseType, SUM(amount) as Total_Amount FROM expenseTB WHERE user_ID = '" + id + "' AND expenseDate BETWEEN '" + startDate + "' AND '" + endDate + "' group by expenseType order by expenseType asc";
            DataTable reportData = Connection.DbConnection.executeSQL(reportSQL);
            return reportData;
        }
        //pdf to total income by type
        public DataTable executeGetIncomePDF(int id)
        {
            string reportSQL = "SELECT  paymentType, SUM(amount) as Total_Income FROM incomeTB WHERE user_ID = '" + id + "' group by paymentType order by paymentType asc";
            DataTable reportData = Connection.DbConnection.executeSQL(reportSQL);
            return reportData;
        }
        //pdf to total expenses by type
        public DataTable executeGetExpensePDF(int id)
        {
            string reportSQL = "SELECT expenseType, SUM(amount) as Total_Amount FROM expenseTB WHERE user_ID = '" + id + "' group by expenseType order by expenseType asc";
            DataTable reportData = Connection.DbConnection.executeSQL(reportSQL);
            return reportData;
        }

        public DataTable executeDeleteReport(object id)
        {
            string sqlServer = "DELETE FROM reportTB WHERE report_ID = '" + id + "'";
            DataTable expenseData = Connection.DbConnection.executeSQL(sqlServer);
            return expenseData;

        }
    }
}
