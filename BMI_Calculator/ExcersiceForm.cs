using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class ExcersiceForm : Form
    {
        public ExcersiceForm()
        {
            InitializeComponent();
        }
        public string MuscleTrained
        {
            get { return muscleTrainedTxtBox.Text; }
        }
        private async void gunaButton1_Click(object sender, EventArgs e)
        {
            string muscleTrained = this.MuscleTrained;

            var excerciseList = await ExcerciseProcessor.LoadExcercise(muscleTrained);

            // Debugging: Check the content of excerciseList
            Console.WriteLine($"ExcerciseList: {excerciseList}");

            // Check if excerciseList is not null and has items
            if (excerciseList != null && excerciseList.Count > 0)
            {
                // Access the in the list
                var firstExcercise = excerciseList[0];
                Excercise1Txt.Text = firstExcercise.name;
                var secondExcercise = excerciseList[1];
                Excercise2Txt.Text = secondExcercise.name;
                var thirdExcercise = excerciseList[2];
                Excercise3Txt.Text = thirdExcercise.name;

                Difficulty1.Text = "Difficulty : " + firstExcercise.difficulty;
                Difficulty2.Text = "Difficulty : " + secondExcercise.difficulty;
                Difficulty3.Text = "Difficulty : " + thirdExcercise.difficulty;
            }
            else
            {
                // Handle the case where no excercise are returned
                Console.WriteLine("No excercise found.");
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Dashboard Frm = new Dashboard();
            Hide();
            Frm.ShowDialog();
        }

        private void ProgressButton_Click(object sender, EventArgs e)
        {
            ProgressTab Frm = new ProgressTab();
            Hide();
            Frm.ShowDialog();
        }

        private void CalorieButton_Click(object sender, EventArgs e)
        {
            CalorieForm Frm = new CalorieForm();
            Hide();
            Frm.ShowDialog();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            SignInForm Frm = new SignInForm();
            Hide();
            Frm.ShowDialog();
        }
    }
}
