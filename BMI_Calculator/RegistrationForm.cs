using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BMI_Calculator
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegisterRegis_Click(object sender, EventArgs e)
        {

            SqlConnection connect = new SqlConnection("Data Source=LAPTOP-29Q67NHD\\SQLEXPRESS;Initial Catalog=BMIApp;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Regis]\r\n           ([Name]\r\n           ,[Username]\r\n           ,[Password])\r\n     VALUES\r\n           ('" + txtNameRegis.Text + "',\r\n           '" + txtUsernameRegis.Text + "',\r\n           '" + txtPasswordRegis.Text + "')", connect);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();

            UserDataInput frm = new UserDataInput();
            frm.Show();
            Hide();

            MessageBox.Show("Register Succesfully");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void SignUpTxt_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradient2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelRegis_Click(object sender, EventArgs e)
        {
            SignInForm frm = new SignInForm();
            frm.Show();
            Hide();
        }
    }
}
