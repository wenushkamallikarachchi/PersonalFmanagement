using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using w1673746.Models;
namespace w1673746.Views
{
    public partial class AddContactForm : Form
    {
        ContactModel cm = new ContactModel();
        public AddContactForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void resetBt_Click(object sender, EventArgs e)
        {
            clearFeilds();
            firstNameText.Select();
        }

        private void clearFeilds()
        {
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                textBox.Text = string.Empty;
            }
        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            firstNameText.Select();
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            clearFeilds();
            AddContactForm adf = new AddContactForm();
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();
        }
        //phone number validation
        public static bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^[0-9]{10}$").Success;
        }

        private void addContactBt_Click(object sender, EventArgs e)
        {
            MessageBoxButtons okBt = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            string message = "Add Contact Error";


            //first name
            if (string.IsNullOrEmpty(firstNameText.Text))
            {
                MessageBox.Show("Please enter the first name: ", message, okBt, icon);
                firstNameText.Select();
                return;
            }
            //phone number validation text
            if (!string.IsNullOrEmpty(phNoText.Text))
            {
                bool num = IsPhoneNumber(phNoText.Text);
                if (num.Equals(false))
                {
                    MessageBox.Show("Please enter valid Phone number: ", message, okBt, MessageBoxIcon.Error);
                    phNoText.Select();
                    return;
                }
            }
            DialogResult result;
            result = MessageBox.Show("Do you want to add contact information? ", "Save Data & Add Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataTable addContact = cm.executeAddContact(firstNameText.Text, lastNameText.Text, phNoText.Text, jobText.Text, addressText.Text);
                MessageBox.Show("Successfully Add Contact. ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFeilds();
                AddContactForm acf = new AddContactForm();
                this.Hide();
                MainForm mf = new MainForm();
                mf.Show();
            }
        }
    }
}
