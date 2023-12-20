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
//using BMICalculatorr;

namespace BMI_Calculator
{
    public partial class ProgressTab : Form
    {
        public ProgressTab()
        {
            InitializeComponent();
        }


        /*private void label1_Click(object sender, EventArgs e)
        {
            string status;
            double Height = double.Parse(heightBox.Text);
            double Weight = double.Parse(weightBox.Text);
            double BMIResult = (Weight) / ((Height / 100) * (Height / 100));
            // BMICalculator BMI = new BMICalculator(Height, Weight);
            // double BMIResult = BMI.compute_BMI();
            if (BMIResult < 18.5)
            {
                status = "Underweight";
                result.Text = BMIResult + "\n" + status;
            }
            else if (BMIResult > 18.5 && BMIResult < 24.5)
            {
                status = "Ideal Weight";
                result.Text = BMIResult + "\n" + status;
            }
            else if (BMIResult > 24.5 && BMIResult < 32.5)
            {
                status = "Overweight";
                result.Text = BMIResult + "\n" + status;
            }
            else
            {
                status = "Obesity";
                result.Text = BMIResult + "\n" + status;
            }
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-29Q67NHD\\SQLEXPRESS;Initial Catalog=BMIApp;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[BMI]\r\n           ([Weight]\r\n           ,[Height]\r\n           ,[BMI]\r\n           ,[Status])\r\n     VALUES\r\n           ('" + weightBox.Text + "'\r\n           ,'" + heightBox.Text + "'\r\n           ,'" + BMIResult + "'\r\n           ,'" + status + "')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }*/
        private void homeButton_Click(object sender, EventArgs e)
        {
            Dashboard Frm = new Dashboard();
            Hide();
            Frm.ShowDialog();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            SignInForm Frm = new SignInForm();
            Hide();
            Frm.ShowDialog();
        }
        private void ExerciseButton_Click(object sender, EventArgs e)
        {
            ExcersiceForm Frm = new ExcersiceForm();
            Hide();
            Frm.ShowDialog();
        }

        private void CalorieButton_Click(object sender, EventArgs e)
        {
            CalorieForm Frm = new CalorieForm();
            Hide();
            Frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string status;
            double Height = double.Parse(heightBox.Text);
            double Weight = double.Parse(weightBox.Text);
            double BMIResult = (Weight) / ((Height / 100) * (Height / 100));
            // BMICalculator BMI = new BMICalculator(Height, Weight);
            // double BMIResult = BMI.compute_BMI();
            if (BMIResult < 18.5)
            {
                status = "Underweight";
                result.Text = BMIResult + "\n" + status;
            }
            else if (BMIResult > 18.5 && BMIResult < 24.5)
            {
                status = "Ideal Weight";
                result.Text = BMIResult + "\n" + status;
            }
            else if (BMIResult > 24.5 && BMIResult < 32.5)
            {
                status = "Overweight";
                result.Text = BMIResult + "\n" + status;
            }
            else
            {
                status = "Obesity";
                result.Text = BMIResult + "\n" + status;
            }
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-29Q67NHD\\SQLEXPRESS;Initial Catalog=BMIApp;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[BMI]\r\n           ([Weight]\r\n           ,[Height]\r\n           ,[BMI]\r\n           ,[Status])\r\n     VALUES\r\n           ('" + weightBox.Text + "'\r\n           ,'" + heightBox.Text + "'\r\n           ,'" + BMIResult + "'\r\n           ,'" + status + "')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
