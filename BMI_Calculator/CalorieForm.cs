using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.ComponentModel.Design;
using System.Security.Policy;

namespace BMI_Calculator
{
    public partial class CalorieForm : Form
    {
        public string MaximumCalorie
        {
            get { return MaxCalorieTxtBox.Text; }
        }
        public CalorieForm()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private async void gunaButton1_Click(object sender, EventArgs e)
        {
            string maximumCalorie = this.MaximumCalorie;

            var mealList = await SpoonacularProcessor.LoadMeal(maximumCalorie);

            // Debugging: Check the content of mealList
            Console.WriteLine($"MealList: {mealList}");

            // Check if mealList is not null and has items
            if (mealList != null && mealList.Count > 0)
            {
                // Access the  meal in the list 
                var firstMeal = mealList[0];
                breakfastTxt.Text = firstMeal.title;
                var secondMeal = mealList[1];
                LunchTxt.Text = secondMeal.title;
                var thirdMeal = mealList[2];
                DinnerTxt.Text = thirdMeal.title;

                NumServingBreakfast.Text = firstMeal.servings.ToString();
                NumServingLunch.Text = secondMeal.servings.ToString();
                NumServingDinner.Text = thirdMeal.servings.ToString();
            }
            else
            {
                // Handle the case where no meals are returned
                Console.WriteLine("No meals found.");
            }
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            SignInForm Frm = new SignInForm();
            Hide();
            Frm.ShowDialog();
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

        private void ExerciseButton_Click(object sender, EventArgs e)
        {
            ExcersiceForm Frm = new ExcersiceForm();
            Hide();
            Frm.ShowDialog();
        }
    }
}
