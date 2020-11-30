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
namespace w1673746
{
    public partial class loginForm : Form
    {
        static LoginModel lm = new LoginModel();
        public loginForm()
        {
            InitializeComponent();


        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameTextBox.Text) &&
                    !string.IsNullOrEmpty(passwordTextBox.Text))
            {
                DataTable userData = lm.executeLoginSQL(nameTextBox.Text, passwordTextBox.Text);
                if (userData.Rows.Count > 0)
                {
                    nameTextBox.Clear();
                    passwordTextBox.Clear();
                    MessageBox.Show("Succesfully sign in", "Sucess Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Please enter correct username or password", "Signin Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    nameTextBox.Focus();
                }

            }
            else
            {

                MessageBox.Show("Please enter username and password", "Signin Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                nameTextBox.Select();
            }
        }

        private void signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginForm loginForm = new loginForm();
            this.Hide();

            RegisterForm reg = new RegisterForm();
            reg.Show();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
