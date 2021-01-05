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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

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
        static PredictionModel predictModel = new PredictionModel();

        //varibale initailizing here
        private int user_id;
        static String contId;
        static String incomeId;
        static String expenseId;
        DateTime startDate;
        DateTime endDate;
        DateTime predictStartDate = DateTime.Today;
        DateTime predictEndDate = DateTime.Today.AddDays(-28);

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
        private void tabPage5_Click(object sender, EventArgs e)
        {
            loadReportData();
        }
        private void MainForm_Load(object sender, EventArgs e)


        {

            loadUserData();
            loadIncomeData();
            loadExpenseData();
            loadReportData();
            loadIncomeTypeOverviewChart();
            loadExpenseTypeOverviewChart();
            loadIncomeExpenseChart();
            loadTotalIncome();
            loadTotalExpense();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            loadUserData();
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
            loadUserData();
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
            DataTable contactData = contactModel.executeSearchContact(textSearchContact.Text, user_id);
            dataGridView1.DataSource = contactData;
        }
        /**Ending the contact implementation **/

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
            DataTable incomeData = incomeModel.executeSearchIncome(textBoxIncome.Text, user_id);
            dataGridView2.DataSource = incomeData;
        }
        private void tabPage3_Click(object sender, EventArgs e)
        {
            loadIncomeData();
            loadIncomeTypeOverviewChart();
            loadExpenseTypeOverviewChart();
            loadTotalIncome();
        }

        private void addIncome_Click(object sender, EventArgs e)
        {
            AddIncomeForm incomeForm = new AddIncomeForm();
            incomeForm.setId(user_id);
            // Console.WriteLine(user_id);
            incomeForm.ShowDialog();
            loadIncomeData();
            loadTotalIncome();
            loadIncomeTypeOverviewChart();
        }
        //delete function for income
        private void deleteIncome_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete this income permanently?", "Delete this record", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {

                    incomeModel.executeDeleteIncome(dataGridView2.CurrentRow.Cells[0].Value);
                    loadIncomeTypeOverviewChart();
                    loadIncomeData();
                    loadTotalIncome();
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
            loadTotalIncome();
        }
        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            incomeId = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            Console.WriteLine("income id is" + incomeId);
        }
        //load all the income for dashboard and income tab
        private void loadTotalIncome()
        {
            int sum = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView2.Rows[i].Cells[5].Value);
            }
            totalIncome.Text = sum.ToString();

            incomeLabel.Text = sum.ToString();
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
            dataGridView3.Columns[5].Width = 180;


        }
        //add function for expenses
        private void addExpense(object sender, EventArgs e)
        {
            AddExpenseForm expenseForm = new AddExpenseForm();
            expenseForm.setId(user_id);
            Console.WriteLine("set here for expense" + user_id);
            expenseForm.ShowDialog();
            loadExpenseData();
            loadTotalExpense();
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
                    loadExpenseTypeOverviewChart();
                    loadTotalExpense();
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
            DataTable expenseData = expenseModel.executeSearchExpense(textBoxExpense.Text, user_id);
            dataGridView3.DataSource = expenseData;
        }
        //loadd the expense data by page click
        private void tabPage4_Click(object sender, EventArgs e)
        {
            loadExpenseData();
            loadIncomeTypeOverviewChart();
            loadExpenseTypeOverviewChart();
            loadTotalExpense();
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
            loadTotalExpense();
        }
        //load the expense id from the row click
        private void dataGridView3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            expenseId = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
            Console.WriteLine("expense id is" + expenseId);
        }
        private void loadTotalExpense()
        {
            int sum = 0;
            for (int i = 0; i < dataGridView3.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView3.Rows[i].Cells[5].Value);
            }
            //dashboard label
            totalExpense.Text = sum.ToString();
            //Tab label
            totExpense.Text = sum.ToString();
        }

        /**end the expenses implementation**/

        /**Starting report**/
        //pdf implementation
        void ExportDataTableToPdf(DataTable dtblTable, String strPdfPath, string strHeader)
        {
            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader.ToUpper()));
            document.Add(prgHeading);

            //Add line break
            document.Add(new Chunk("\n"));

            //Write the table
            PdfPTable table = new PdfPTable(dtblTable.Columns.Count);

            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

            for (int i = 0; i < dtblTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();

                cell.AddElement(new Chunk(dtblTable.Columns[i].ColumnName.ToUpper()));
                table.AddCell(cell);
            }
            //table Data
            for (int i = 0; i < dtblTable.Rows.Count; i++)
            {
                for (int j = 0; j < dtblTable.Columns.Count; j++)
                {
                    table.AddCell(dtblTable.Rows[i][j].ToString());
                }
            }

            document.Add(table);
            document.Close();
            writer.Close();
            fs.Close();
        }
        //data for pdf reports
        DataTable MakeDataTable(string name)
        {
            //Create income table object
            if (name.Equals("income"))
            {
                DataTable reportData = reportModel.executeGetIncomePDF(user_id);
                return reportData;
            }
            else
            {
                DataTable reportData = reportModel.executeGetExpensePDF(user_id);
                return reportData;
            }
        }
        //generate pdf income
        private void pdfIncome_Click(object sender, EventArgs e)
        {
            DataTable dtbl = MakeDataTable("income");
            ExportDataTableToPdf(dtbl, @"D:\TotalIncome.pdf", "Total Income at " + " " + predictStartDate);
            System.Diagnostics.Process.Start(@"D:\TotalIncome.pdf");
            //this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
        //  generate pdf expense
        private void pdfExpense_Click(object sender, EventArgs e)
        {
            DataTable dtbl = MakeDataTable("expense");
            ExportDataTableToPdf(dtbl, @"D:\TotalExpense.pdf", "Total Expense at " + " " + predictStartDate);
            System.Diagnostics.Process.Start(@"D:\TotalExpense.pdf");
            //this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
        //load all the report by given ID
        private void loadReportData()
        {
            DataTable reportData = reportModel.executeDisplayAllReportData(user_id);
            dataGridView4.DataSource = reportData;

            dataGridView4.Columns[0].HeaderText = "Report ID";
            dataGridView4.Columns[1].HeaderText = "Name";
            dataGridView4.Columns[2].HeaderText = "Type";
            dataGridView4.Columns[3].HeaderText = "Start Date";
            dataGridView4.Columns[4].HeaderText = "End Date";
            dataGridView4.Columns[5].HeaderText = "Created";

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
            if ((DateTime)dataGridView4.Rows[e.RowIndex].Cells[3].Value != null && (DateTime)dataGridView4.Rows[e.RowIndex].Cells[4].Value != null)
            {
                startDate = (DateTime)dataGridView4.Rows[e.RowIndex].Cells[3].Value;
                endDate = (DateTime)dataGridView4.Rows[e.RowIndex].Cells[4].Value;

                loadIncomeSummary(this.user_id, startDate, endDate);
                loadExpenseSummary(this.user_id, startDate, endDate);
            }
            else
            {
                MessageBox.Show("You have to create a new report.", "New Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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


        private void deleteReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete this report permanently?", "Delete this record", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (dataGridView4.CurrentRow.Cells[0].Value != null)
                    {
                        reportModel.executeDeleteReport(dataGridView4.CurrentRow.Cells[0].Value);
                        loadReportData();

                        MessageBox.Show("The selected record has been deletecd.", "Deleted Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {

                        MessageBox.Show("Please select a record", "Select Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

            }
            catch (Exception)
            {

                // and error occured
            }
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
            else
            {
                incomeOverviewText.Text = "You have to add atleast one income.";
            }

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
        private void loadIncomeExpenseChart()
        {
            DataTable incomeData = dashModel.getTotalIncomes(user_id);
            DataTable expenseData = dashModel.getTotalExpenses(user_id);
            if (expenseData.Rows.Count > 0 || incomeData.Rows.Count > 0)
            {
                cartesianChart.Series = new SeriesCollection();
                ColumnSeries colSeriesIncomeObj = new ColumnSeries
                {
                    Title = "Income",
                    Values = new ChartValues<double> { }
                };

                foreach (DataRow dr in incomeData.Rows)
                {
                    colSeriesIncomeObj.Values.Add(double.Parse(dr["Total"].ToString()));
                }

                ColumnSeries colSeriesExpenseObj = new ColumnSeries
                {
                    Title = "Expense",
                    Values = new ChartValues<double> { }
                };

                foreach (DataRow dr in expenseData.Rows)
                {
                    colSeriesExpenseObj.Values.Add(double.Parse(dr["Total"].ToString()));
                }

                //adding series will update and animate the chart automatically
                cartesianChart.Series.Add(colSeriesIncomeObj);
                cartesianChart.Series.Add(colSeriesExpenseObj);

                cartesianChart.AxisX.Add(
                 new Axis
                 {
                     Title = "Years",
                     Labels = new[] { "2020", "2021" }
                 });

                cartesianChart.AxisY.Add(new Axis
                {
                    Title = "Total",
                    LabelFormatter = value => value.ToString("N")
                });
            }

            else
            {
                incomeVsExpense.Text = "You have to add atleast one income or expense";
            }



        }
        //Starting the Prediction
        private int averageExpenditure()
        {
            int expense = 0;
            DataTable expenseData = predictModel.executeGetTotalExpensesDateRange(user_id, predictEndDate, predictStartDate);

            foreach (DataRow row in expenseData.Rows)
            {
                expense = int.Parse(row["Total"].ToString());
            }
            int average = expense / 28;
            return average;
        }

        private void predict_Click(object sender, EventArgs e)
        {
            int average = averageExpenditure();


            endDate = dateTimePickerEnd.Value;
            String data = (endDate - predictStartDate).TotalDays.ToString();
            Console.WriteLine("Data is" + data);
            float date = float.Parse(data);
            float predictExpense = average * date;
            textBoxPredict.Text = predictExpense.ToString();



        }


    }
}
