using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using w1673746.Models;
using w1673746.Views;

namespace w1673746
{
    public partial class MainForm : Form
    {
        //creating the model object
        static ContactModel contactModel = new ContactModel();
        static IncomeModel incomeModel = new IncomeModel();
        static ExpenseModel expenseModel = new ExpenseModel();
        static ReportModel reportModel = new ReportModel();
        static DashBoardModel dashModel = new DashBoardModel();

        //varibale initailizing here
        private int user_id;
        static String contId;
        static String incomeId;
        static String expenseId;
        DateTime startDate;
        DateTime endDate;

        public void setId(int id)
        {
            user_id = id;
        }


        public int getId()
        {
            return user_id;
        }
        public MainForm()
        {
            InitializeComponent();
        }



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            loadReportData();
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            loadUserData();
            loadIncomeData();
            loadExpenseData();
            loadReportData();
            loadIncomeTypeOverviewChart();
            loadExpenseTypeOverviewChart();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        /**Starting the contact implementation**/
        //load all the contact by given id
        private void loadUserData()
        {
            DataTable userData = contactModel.executeAllUserData(user_id);
            dataGridView1.DataSource = userData;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "First Name";
            dataGridView1.Columns[2].HeaderText = "Designation";
            dataGridView1.Columns[3].HeaderText = "Phone Number";
            dataGridView1.Columns[4].HeaderText = "Address";
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 200;
        }

        //delete method for contact
        private void deleteBt_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete this contact permanently?", "Delete this record", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {

                    contactModel.executeDeleteUserData(dataGridView1.CurrentRow.Cells[0].Value);
                    loadUserData();
                    MessageBox.Show("The selected record has been deletecd.", "Deleted Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {

                // and error occured
            }
        }
        //add method for contact
        private void addContactBt_Click(object sender, EventArgs e)
        {
            AddContactForm addContactForm = new AddContactForm();
            addContactForm.setId(user_id);
            addContactForm.ShowDialog();

        }

        //update method for contact
        private void updateBt_Click(object sender, EventArgs e)
        {
            UpdateContactForm updateContactForm = new UpdateContactForm();
            updateContactForm.setContactId(int.Parse(contId));
            updateContactForm.ShowDialog();
            loadUserData();
        }
        //set the contact id here
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            contId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Console.WriteLine("cont id is" + contId);
        }
        //search method in contact tab
        private void textSearchName_TextChanged(object sender, EventArgs e)
        {
            DataTable contactData = contactModel.executeSearchContact(textSearchContact.Text);
            dataGridView1.DataSource = contactData;
        }

        /**Starting Income implementation**/
        //load all the income by given id
        private void loadIncomeData()
        {
            DataTable incomeData = incomeModel.executeAllIncome(user_id);
            dataGridView2.DataSource = incomeData;
            dataGridView2.Columns[0].HeaderText = "ID";
            dataGridView2.Columns[1].HeaderText = "Payment From";
            dataGridView2.Columns[2].HeaderText = "Payment Description";
            dataGridView2.Columns[3].HeaderText = "Payment Type";
            dataGridView2.Columns[4].HeaderText = "Transaction Date";
            dataGridView2.Columns[5].HeaderText = "Amount";
            dataGridView2.Columns[0].Width = 200;
            dataGridView2.Columns[1].Width = 200;
            dataGridView2.Columns[2].Width = 200;
            dataGridView2.Columns[3].Width = 200;
            dataGridView2.Columns[4].Width = 200;
        }
        // search method in income tab
        private void textSearchIncome_TextChanged(object sender, EventArgs e)
        {
            DataTable incomeData = incomeModel.executeSearchIncome(textBoxIncome.Text);
            dataGridView2.DataSource = incomeData;
        }
        private void tabPage3_Click(object sender, EventArgs e)
        {
            loadIncomeData();
            loadIncomeTypeOverviewChart();
            loadExpenseTypeOverviewChart();
        }

        private void addIncome_Click(object sender, EventArgs e)
        {
            AddIncomeForm incomeForm = new AddIncomeForm();
            incomeForm.setId(user_id);
            // Console.WriteLine(user_id);
            incomeForm.ShowDialog();
        }
        //delete function for income
        private void deleteIncome_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete this income permanently?", "Delete this record", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {

                    incomeModel.executeDeleteIncome(dataGridView2.CurrentRow.Cells[0].Value);
                    loadIncomeData();
                    MessageBox.Show("The selected record has been deletecd.", "Deleted Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {

                // and error occured
            }
        }
        private void updateIncome_Click(object sender, EventArgs e)
        {
            UpdateIncomeForm updateIncome = new UpdateIncomeForm();
            updateIncome.setIncomeId(int.Parse(incomeId));
            updateIncome.setEnteredId(user_id);
            updateIncome.ShowDialog();
            loadIncomeData();
            loadIncomeTypeOverviewChart();
            loadExpenseTypeOverviewChart();
        }
        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            incomeId = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            Console.WriteLine("income id is" + incomeId);
        }

        /**end the income implementation**/

        /**starting the Expense Implementation**/
        //load all the expenses by given ID
        private void loadExpenseData()
        {
            DataTable expenseData = expenseModel.executeAllExpense(user_id);
            dataGridView3.DataSource = expenseData;
            dataGridView3.Columns[0].HeaderText = "ID";
            dataGridView3.Columns[1].HeaderText = "Payment To";
            dataGridView3.Columns[2].HeaderText = "Payment Description";
            dataGridView3.Columns[3].HeaderText = "Payment Type";
            dataGridView3.Columns[4].HeaderText = "Transaction Date";
            dataGridView3.Columns[5].HeaderText = "Amount";
            dataGridView3.Columns[0].Width = 200;
            dataGridView3.Columns[1].Width = 200;
            dataGridView3.Columns[2].Width = 200;
            dataGridView3.Columns[3].Width = 200;
            dataGridView3.Columns[4].Width = 200;


        }
        //add function for expenses
        private void addExpense(object sender, EventArgs e)
        {
            AddExpenseForm expenseForm = new AddExpenseForm();
            expenseForm.setId(user_id);
            Console.WriteLine("set here for expense" + user_id);
            expenseForm.ShowDialog();
        }
        //delete function for expense
        private void deleteExpense(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Do you want to delete this expense permanently?", "Delete this record", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {

                    expenseModel.executeDeleteExpense(dataGridView3.CurrentRow.Cells[0].Value);
                    loadExpenseData();
                    MessageBox.Show("The selected record has been deletecd.", "Deleted Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {

                // and error occured
            }
        }
        //search function for expense
        private void textSearchExpense_TextChanged(object sender, EventArgs e)
        {
            DataTable expenseData = expenseModel.executeSearchExpense(textBoxExpense.Text);
            dataGridView3.DataSource = expenseData;
        }
        //loadd the expense data by page click
        private void tabPage4_Click(object sender, EventArgs e)
        {
            loadExpenseData();
            loadIncomeTypeOverviewChart();
            loadExpenseTypeOverviewChart();
        }
        //update funtion for expense
        private void updateExpense_Click(object sender, EventArgs e)
        {
            UpdateExpenseForm updateExpenseForm = new UpdateExpenseForm();
            updateExpenseForm.setExpense(int.Parse(expenseId));
            updateExpenseForm.setEnteredId(user_id);
            updateExpenseForm.ShowDialog();
            loadExpenseData();
            loadIncomeTypeOverviewChart();
            loadExpenseTypeOverviewChart();
        }
        //load the expense id from the row click
        private void dataGridView3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            expenseId = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
            Console.WriteLine("expense id is" + expenseId);
        }

        /**end the expenses implementation**/

        /**Starting report**/
        //load all the report by given ID
        private void loadReportData()
        {
            DataTable reportData = reportModel.executeDisplayAllReportData(user_id);
            dataGridView4.DataSource = reportData;
            dataGridView4.Columns[0].HeaderText = "Name";
            dataGridView4.Columns[1].HeaderText = "Type";
            dataGridView4.Columns[2].HeaderText = "Start Date";
            dataGridView4.Columns[3].HeaderText = "End Date";
            dataGridView4.Columns[4].HeaderText = "Created";

        }
        // create new report funtion
        private void newReport_Click(object sender, EventArgs e)
        {
            NewReport newReport = new NewReport();
            newReport.setId(user_id);
            newReport.ShowDialog();
            loadReportData();
        }
        //display the total amount by clicking the table row
        private void dataGridReportView_RowHeaderClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //datagrid eke null awoth errors ennwa
            startDate = (DateTime)dataGridView4.Rows[e.RowIndex].Cells[2].Value;
            endDate = (DateTime)dataGridView4.Rows[e.RowIndex].Cells[3].Value;
            loadIncomeSummary(this.user_id, startDate, endDate);
            loadExpenseSummary(this.user_id, startDate, endDate);
        }
        //load the income total and payment type 
        private void loadIncomeSummary(int user_id, DateTime startDate, DateTime endDate)
        {
            DataTable reportData = reportModel.executeGetIncomeSummary(user_id, startDate, endDate);
            dataGridIncome.DataSource = reportData;
            dataGridIncome.Columns[0].HeaderText = "Payment Type";
            dataGridIncome.Columns[1].HeaderText = "Total Amount";
            dataGridIncome.Columns[0].Width = 200;
            dataGridIncome.Columns[1].Width = 200;

        }
        //load the expense type and expense total
        private void loadExpenseSummary(int user_id, DateTime startDate, DateTime endDate)
        {
            DataTable reportData = reportModel.executeGetExpenseSummary(user_id, startDate, endDate);
            dataGridExpense.DataSource = reportData;
            dataGridExpense.Columns[0].HeaderText = "Expense Type";
            dataGridExpense.Columns[1].HeaderText = "Total Amount";
            dataGridExpense.Columns[0].Width = 200;
            dataGridExpense.Columns[1].Width = 200;
        }
        /**ending the report implementation**/


        /**starting the dashboard implementation**/
        //dashboard income payment type overview
        private void loadIncomeTypeOverviewChart()
        {
            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            DataTable incomeData = dashModel.executeGetIncomeTypeOverview(user_id);
            if (incomeData.Rows.Count > 0)
            {
                pieChartIncome.Series = new SeriesCollection();
                foreach (DataRow dr in incomeData.Rows)
                {
                    PieSeries pieSeriesObj = new PieSeries
                    {
                        Title = dr["paymentType"].ToString(),
                        Values = new ChartValues<double> { double.Parse(dr["Total"].ToString()) },
                        DataLabels = true,
                        LabelPoint = labelPoint
                    };
                    pieChartIncome.Series.Add(pieSeriesObj);
                }

                pieChartIncome.LegendLocation = LegendLocation.Bottom;
            }
            //else { }

        }
        //dashboard expense type overview pie chart
        private void loadExpenseTypeOverviewChart()
        {
            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            DataTable expenseData = dashModel.executeGetExpenseTypeOverview(user_id);
            if (expenseData.Rows.Count > 0)
            {
                pieChartExpense.Series = new SeriesCollection();
                foreach (DataRow dr in expenseData.Rows)
                {
                    PieSeries pieSeriesObj = new PieSeries
                    {
                        Title = dr["expenseType"].ToString(),
                        Values = new ChartValues<double> { double.Parse(dr["Total"].ToString()) },
                        DataLabels = true,
                        LabelPoint = labelPoint
                    };
                    pieChartExpense.Series.Add(pieSeriesObj);
                }

                pieChartExpense.LegendLocation = LegendLocation.Bottom;
            }
            //else { }
        }
    }
}
