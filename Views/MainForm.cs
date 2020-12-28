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
        static ContactModel cm = new ContactModel();
        static IncomeModel incomeModel = new IncomeModel();
        private int user_id;
        static String contId;
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

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadUserData();
            loadIncomeData();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            loadUserData();
            loadIncomeData();
        }

        private void loadUserData()
        {
            DataTable userData = cm.executeAllUserData(user_id);

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

        private void deleteBt_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete this contact permanently?", "Delete this record", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {

                    cm.executeDeleteUserData(dataGridView1.CurrentRow.Cells[0].Value);
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

        private void addContactBt_Click(object sender, EventArgs e)
        {


            AddContactForm addContactForm = new AddContactForm();
            addContactForm.setId(user_id);
            addContactForm.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateBt_Click(object sender, EventArgs e)
        {
            UpdateContactForm updateContactForm = new UpdateContactForm();
            updateContactForm.setContactId(int.Parse(contId));
            updateContactForm.ShowDialog();
            loadUserData();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            contId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Console.WriteLine("cont id is" + contId);
        }
        //search method in contact
        private void textSearchName_TextChanged(object sender, EventArgs e)
        {
            DataTable contactData = cm.executeSearchContact(textSearchContact.Text);
            dataGridView1.DataSource = contactData;
        }
        // search method in income
        private void textSearchIncome_TextChanged(object sender, EventArgs e)
        {
            DataTable incomeData = incomeModel.executeSearchIncome(textBoxIncome.Text);
            dataGridView2.DataSource = incomeData;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addIncome_Click(object sender, EventArgs e)
        {
            AddIncomeForm incomeForm = new AddIncomeForm();
            incomeForm.setId(user_id);
            Console.WriteLine(user_id);
            incomeForm.ShowDialog();
        }

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
    }
}
