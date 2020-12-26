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
    public partial class UpdateContactForm : Form
    {
        public int id;
        ContactModel cm = new ContactModel();

        public void setContactId(int id)
        {
            this.id = id;
            displayContactDetails(id);
        }

        public UpdateContactForm()
        {
            InitializeComponent();
        }

        private void resetBt_Click(object sender, EventArgs e)
        {

        }

        private void displayContactDetails(int id)
        {
            DataTable contactData = cm.executeDisplayContactById(id);

            foreach (DataRow row in contactData.Rows)
            {
                firstNameText.Text = row["first_Name"].ToString();
                lastNameText.Text = row["last_Name"].ToString();
                phNoText.Text = row["phone_no"].ToString();
                jobText.Text = row["job_role"].ToString();
                addressText.Text = row["address"].ToString();
            }
        }

        private void addContactBt_Click(object sender, EventArgs e)
        {

            DialogResult result;
            result = MessageBox.Show("Do you want to update the record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                cm.executeUpdateContact(firstNameText.Text, lastNameText.Text, phNoText.Text, jobText.Text, addressText.Text, this.id);

                MessageBox.Show("The record has been updated successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }

        private void UpdateContactForm_Load(object sender, EventArgs e)
        {

        }
    }
}
