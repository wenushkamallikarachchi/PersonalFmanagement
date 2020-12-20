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
    public partial class loginForm : Form
    {
        static LoginModel lm = new LoginModel();
        int id;
        public loginForm()
        {
            InitializeComponent();


        }
        private void Login(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameTextBox.Text) &&
                    !string.IsNullOrEmpty(passwordTextBox.Text))
            {
                DataTable userData = lm.executeLoginSQL(nameTextBox.Text, passwordTextBox.Text);


                foreach (DataRow row in userData.Rows)
                {
                    string idn = row["AUTO_ID"].ToString();
                    id = int.Parse(idn);

                }

                Console.WriteLine("data in numer" + id);


                if (userData.Rows.Count > 0)
                {
                    nameTextBox.Clear();
                    passwordTextBox.Clear();
                    MessageBox.Show("Succesfully sign in", "Login Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    MainForm mainForm = new MainForm();
                    mainForm.setId(id);
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
