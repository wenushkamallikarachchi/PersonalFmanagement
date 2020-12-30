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
    public partial class UpdateIncomeForm : Form
    {
        IncomeModel incomeModel = new IncomeModel();
        public int id;


        public void setIncomeId(int id)
        {
            this.id = id;
            displayIncomeDetails(id);
        }
        public UpdateIncomeForm()
        {
            InitializeComponent();
        }
        private void displayIncomeDetails(int id)
        {
            DataTable incomeData = incomeModel.executeDisplayIncomeById(id);

            foreach (DataRow row in incomeData.Rows)
            {
                comboBoxPaymentFrom.Text = row["contact_ID"].ToString();
                paymentDes.Text = row["paymentDescription"].ToString();
                amount.Text = row["amount"].ToString();
                paymentType.Text = row["paymentType"].ToString();
                dateTimePicker.Text = row["IncomeDate"].ToString();
            }
        }


        private void UpdateIncomeForm_Load(object sender, EventArgs e)
        {

        }

        private void updateIncome_Click(object sender, EventArgs e)
        {

            DialogResult result;
            result = MessageBox.Show("Do you want to update the record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // incomeModel.executeUpdateIncome(firstNameText.Text, paymentDes.Text, amount.Text, paymentType.Text, dateTimePicker.Value, float.Parse(amount.Text), this.id);

                MessageBox.Show("The record has been updated successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }
    }
}
