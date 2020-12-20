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
        private int user_id;
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
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            loadUserData();
        }

        private void loadUserData()
        {
            DataTable userData = cm.executeAllUserData(user_id);

            dataGridView1.DataSource = userData;
            dataGridView1.Columns[0].HeaderText = "First Name";
            dataGridView1.Columns[1].HeaderText = "Designation";
            dataGridView1.Columns[2].HeaderText = "Phone Number";
            dataGridView1.Columns[3].HeaderText = "Address";
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 200;

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
            MainForm mf = new MainForm();

            AddContactForm addContactForm = new AddContactForm();
            addContactForm.setId(user_id);
            addContactForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
