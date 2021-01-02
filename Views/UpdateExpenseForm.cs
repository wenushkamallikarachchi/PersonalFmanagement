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

namespace w1673746.Views
{
    public partial class UpdateExpenseForm : Form
    {
        ExpenseModel expenseModel = new ExpenseModel();
        public int id;
        String x = "";
        public int enteredId;

        public void setEnteredId(int id)
        {
            enteredId = id;
            displayPaymentToList(enteredId);
        }
        public void setExpense(int id)
        {
            this.id = id;
            displayExpenseDetails(id);
        }
        public UpdateExpenseForm()
        {
            InitializeComponent();
        }

        private void displayPaymentToList(int id)
        {
            DataTable incomeData = expenseModel.executeDisplayPaymentToList(id);
            comboBoxExpense.DataSource = incomeData;
            comboBoxExpense.DisplayMember = "Payment_From";
            comboBoxExpense.ValueMember = "Contact_ID";
            comboBoxExpense.SelectedIndex = comboBoxExpense.FindStringExact(x);
        }
        private void UpdateExpenseForm_Load(object sender, EventArgs e)
        {

        }

        private void displayExpenseDetails(int id)
        {
            DataTable expenseData = expenseModel.executeDisplayExpenseById(id);

            foreach (DataRow row in expenseData.Rows)
            {
                x = row["Payment_From"].ToString();
                expenseDescription.Text = row["expenseDescription"].ToString();
                amountExpense.Text = row["amount"].ToString();
                comboBoxType.Text = row["expenseType"].ToString();
                dateTimePickerExpense.Text = row["expenseDate"].ToString();
            }
        }

        private void updateExpense_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to update the record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int contactId = (int)comboBoxExpense.SelectedValue;
                expenseModel.executeUpdateExpense(expenseDescription.Text, comboBoxType.Text, dateTimePickerExpense.Value, float.Parse(amountExpense.Text), contactId, id);

                MessageBox.Show("The record has been updated successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }
    }
}
