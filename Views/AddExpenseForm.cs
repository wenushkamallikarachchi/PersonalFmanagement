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
    public partial class AddExpenseForm : Form
    {
        ExpenseModel expenseModel = new ExpenseModel();
        private int user_id;
        public void setId(int id)
        {
            displayPaymentToList(id);
            this.user_id = id;
        }

        public AddExpenseForm()
        {
            InitializeComponent();
        }

        private void AddExpenseForm_Load(object sender, EventArgs e)
        {

        }
        //reset method
        private void clearFeilds()
        {
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                textBox.Text = string.Empty;
            }
        }
        private void displayPaymentToList(int id)
        {
            DataTable expenseData = expenseModel.executeDisplayPaymentToList(id);
            comboBoxExpense.DataSource = expenseData;
            comboBoxExpense.DisplayMember = "Payment_From";
            comboBoxExpense.ValueMember = "contact_ID";
        }
        private void addExpense_Click(object sender, EventArgs e)
        {
            MessageBoxButtons okBt = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            string message = "Add Expense Error";


            //check the amount 
            if (string.IsNullOrEmpty(amountExpense.Text) || System.Text.RegularExpressions.Regex.IsMatch(amountExpense.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter the Amount Field: ", message, okBt, icon);
                amountExpense.Select();
                return;
            }
            DialogResult result;
            result = MessageBox.Show("Do you want to add expense information? ", "Save Data & Add Income", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int contactId = (int)comboBoxExpense.SelectedValue;
                //Console.WriteLine("Set here Contact ID: " + contactId);
                expenseModel.executeAddExpense(expenseDescription.Text, expenseType.Text, dateTimePickerExpense.Value, float.Parse(amountExpense.Text), user_id, contactId);
                MessageBox.Show("Successfully Add Expense. ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFeilds();
                this.Hide();
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            clearFeilds();
            comboBoxExpense.Select();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            clearFeilds();
            this.Hide();
        }
    }
}
