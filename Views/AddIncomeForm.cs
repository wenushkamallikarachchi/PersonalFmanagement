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
    public partial class AddIncomeForm : Form
    {
        IncomeModel incomeModel = new IncomeModel();
        private int user_id;

        public void setId(int id)
        {
            displayPaymentFromList(id);
            this.user_id = id;
        }
        public AddIncomeForm()
        {
            InitializeComponent();
        }


        private void clearFeilds()
        {
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                textBox.Text = string.Empty;
            }
        }

        private void addIncome_Click(object sender, EventArgs e)
        {

            MessageBoxButtons okBt = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            string message = "Add Income Error";


            //payment From
            /* if (string.IsNullOrEmpty(paymentFrom.Text))
             {
                 MessageBox.Show("Please enter the Payment Form Field: ", message, okBt, icon);
                 paymentFrom.Select();
                 return;
             }*/
            if (string.IsNullOrEmpty(dateTimePicker.Text))
            {
                MessageBox.Show("Please enter the Transaction Date Field: ", message, okBt, icon);
                dateTimePicker.Select();
                return;
            }

            if (string.IsNullOrEmpty(amount.Text))
            {
                MessageBox.Show("Please enter the Amount Field: ", message, okBt, icon);
                amount.Select();
                return;
            }

            DialogResult result;
            result = MessageBox.Show("Do you want to add income information? ", "Save Data & Add Income", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // DataTable addIncome = incomeModel.executeAddIncome(paymentFrom.Text, lastNameText.Text, phNoText.Text, jobText.Text, addressText.Text, user_id);
                MessageBox.Show("Successfully Add Contact. ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFeilds();
                this.Hide();

            }
        }

        private void resetIncome_Click(object sender, EventArgs e)
        {
            clearFeilds();
            comboBoxPaymentFrom.Select();
        }

        private void AddIncomeForm_Load(object sender, EventArgs e)
        {
            comboBoxPaymentFrom.Select();

        }
        private void displayPaymentFromList(int id)
        {
            DataTable incomeData = incomeModel.executeDisplayPaymentFromList(id);
            comboBoxPaymentFrom.DataSource = incomeData;
            comboBoxPaymentFrom.DisplayMember = "Payment_From";
            comboBoxPaymentFrom.ValueMember = "Contact_ID";
        }
        private void cancelIncome_Click(object sender, EventArgs e)
        {
            clearFeilds();
            this.Hide();
        }
    }
}
