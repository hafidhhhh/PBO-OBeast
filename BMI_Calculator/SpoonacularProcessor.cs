using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    public class SpoonacularProcessor
    {
        public static async Task<List<MealModel>> LoadMeal(string maximumCalorie)
        {
            ApiHelper.InitializeClient();
            string url = $"https://api.spoonacular.com/mealplanner/generate?apiKey=a1432702430a49c3a7dca7c93fd7e3cb&timeFrame=day&targetCalories={maximumCalorie}";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    // Read the content as a string
                    string responseContent = await response.Content.ReadAsStringAsync();

                    // Check if the response content is a JSON array or object
                    if (responseContent.StartsWith("["))
                    {
                        // If it's an array, deserialize as a List<MealModel>
                        List<MealModel> mealList = JsonConvert.DeserializeObject<List<MealModel>>(responseContent);

                        // Return the list of meals
                        return mealList;
                    }
                    else if (responseContent.StartsWith("{"))
                    {
                        // If it's an object, try to extract the 'meals' property
                        var responseObject = JsonConvert.DeserializeObject<JObject>(responseContent);
                        var mealsProperty = responseObject["meals"];

                        if (mealsProperty != null)
                        {
                            // Deserialize the 'meals' property as a List<MealModel>
                            List<MealModel> mealList = mealsProperty.ToObject<List<MealModel>>();

                            // Return the list of meals
                            return mealList;
                        }
                    }

                    // If neither array nor object structure is found, handle the case accordingly
                    Console.WriteLine("Unexpected API response format.");
                    return null;
                }
                else
                {
                    // Log the response reason phrase in case of an error
                    Console.WriteLine($"Error: {response.ReasonPhrase}");
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

    }
}
