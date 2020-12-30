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


        public void setExpense(int id)
        {
            this.id = id;
            displayExpenseDetails(id);
        }
        public UpdateExpenseForm()
        {
            InitializeComponent();
        }


        private void UpdateExpenseForm_Load(object sender, EventArgs e)
        {

        }

        private void displayExpenseDetails(int id)
        {
            DataTable expenseData = expenseModel.executeDisplayExpenseById(id);

            foreach (DataRow row in expenseData.Rows)
            {
                comboBoxExpense.Text = row["contact_ID"].ToString();
                expenseDescription.Text = row["expenseDescription"].ToString();
                amountExpense.Text = row["amount"].ToString();
                expenseType.Text = row["expenseType"].ToString();
                dateTimePickerExpense.Text = row["expenseDate"].ToString();
            }
        }

        private void updateExpense_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to update the record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // incomeModel.executeUpdateExpense(firstNameText.Text, expenseDescription.Text, expenseType.Text, dateTimePickerExpense.Value, float.Parse(amountExpense.Text), this.id);

                MessageBox.Show("The record has been updated successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }
    }
}
