using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace BMI_Calculator
{
    public partial class SignInForm : Form
    {
        public string username
        {
            get { return usernameTxtBox.Text; }
        }
        public SignInForm()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-29Q67NHD\\SQLEXPRESS;Initial Catalog=BMIApp;Integrated Security=True");

        private void signUpButton_Click(object sender, EventArgs e)
        {
            RegistrationForm RegistrationForm = new RegistrationForm();
            Hide();
            RegistrationForm.ShowDialog();
        }

        public void loginButton_Click(object sender, EventArgs e)
        {
            String username, password;

            username = usernameTxtBox.Text;
            password = passwordTxtBox.Text;
            try
            {
                String querry = "SELECT * FROM Regis WHERE username = '" + usernameTxtBox.Text + "'AND  password = '" + passwordTxtBox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, connect);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.DashboardLoad(username);
                    dashboard.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameTxtBox.Clear();
                    passwordTxtBox.Clear();

                    usernameTxtBox.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                connect.Close();
            }

            if(checkRememberMe.Checked == true)
            {
                Properties.Settings.Default.username = usernameTxtBox.Text;
                Properties.Settings.Default.password = passwordTxtBox.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.Save();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            usernameTxtBox.Clear();
            passwordTxtBox.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.username != string.Empty)
            {
                usernameTxtBox.Text = Properties.Settings.Default.username;
                passwordTxtBox.Text = Properties.Settings.Default.password;
            }
        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }
    }
}
