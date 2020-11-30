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
namespace w1673746
{
    public partial class RegisterForm : Form
    {
        static LoginModel lm = new LoginModel();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            firstNameTextBox.Select();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBt_Click(object sender, EventArgs e)
        {
            clearFeilds();
            firstNameTextBox.Select();
        }

        private void clearFeilds()
        {
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                textBox.Text = string.Empty;
            }
        }

        private void SignupBt_Click(object sender, EventArgs e)
        {
            MessageBoxButtons okBt = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            string message = "Sign up Error";

            //first name
            if (string.IsNullOrEmpty(firstNameTextBox.Text))
            {
                MessageBox.Show("Please enter the first name: ", message, okBt, icon);
                firstNameTextBox.Select();
                return;
            }
            //last name
            if (string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                MessageBox.Show("Please enter the last name: ", message, okBt, icon);
                lastNameTextBox.Select();
                return;
            }
            //email
            if (string.IsNullOrEmpty(mailTextBox.Text))
            {
                MessageBox.Show("Please enter the E-mail address: ", message, okBt, icon);
                mailTextBox.Select();
                return;
            }

            //phone number
            if (string.IsNullOrEmpty(phNoTextBox.Text))
            {
                MessageBox.Show("Please enter the Phone number: ", message, okBt, icon);
                phNoTextBox.Select();
                return;
            }
            else
            {
                bool num = IsPhoneNumber(phNoTextBox.Text);
                if (num.Equals(false))
                {
                    MessageBox.Show("Please enter valid Phone number: ", message, okBt, icon);
                    phNoTextBox.Select();
                }
            }
            //username
            if (string.IsNullOrEmpty(usernameTextBox.Text))
            {
                MessageBox.Show("Please enter the username: ", message, okBt, icon);
                usernameTextBox.Select();
                return;
            }
            //passwrod
            if (string.IsNullOrEmpty(passTextBox.Text))
            {
                MessageBox.Show("Please enter the password: ", message, okBt, icon);
                passTextBox.Select();
                return;
            }


            //check duplicatio of username
            DataTable userDuplication = lm.executeIsDup(usernameTextBox.Text);
            if (userDuplication.Rows.Count > 0)
            {
                MessageBox.Show("Username is already exist.Please try another username. ", message, okBt, icon);
                usernameTextBox.SelectAll();
                return;
            }


            //sign up
            DialogResult result;
            result = MessageBox.Show("Do you want to save your information? ", "Save Data & Sign up", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataTable userDataReg = lm.executeRegSQL(firstNameTextBox.Text, lastNameTextBox.Text, mailTextBox.Text, phNoTextBox.Text, usernameTextBox.Text, passTextBox.Text);
                MessageBox.Show("Successfully Sign up. ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFeilds();
                RegisterForm registerForm = new RegisterForm();
                this.Hide();

                loginForm loginForm = new loginForm();
                loginForm.Show();
            }

        }
        public static bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^(\+[0-9]{9})$").Success;
        }
    }
}
