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
    public class ExcerciseProcessor
    {
        /*public static async Task<List<ExcerciseModel>> LoadExcercise(string muscleType)
        {
            ApiHelper.InitializeClient();
            string url = $"https://api.api-ninjas.com/v1/exercises?X-Api-Key=55HU/e2ckf1bPLLgQ5xM2Q==81T2Xa1i7KRZIGQZ&muscle={muscleType}";

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
                        List<ExcerciseModel> excerciseList = JsonConvert.DeserializeObject<List<ExcerciseModel>>(responseContent);

                        // Return the list of meals
                        return excerciseList;
                    }
                    else if (responseContent.StartsWith("{"))
                    {
                        // If it's an object, try to extract the 'meals' property
                        var responseObject = JsonConvert.DeserializeObject<JObject>(responseContent);
                        var excerciseProperty = responseObject["excercise"];

                        if (excerciseProperty != null)
                        {
                            // Deserialize the 'meals' property as a List<MealModel>
                            List<ExcerciseModel> excerciseList = excerciseProperty.ToObject<List<ExcerciseModel>>();

                            // Return the list of meals
                            return excerciseList;
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
        }*/

        public static async Task<List<ExcerciseModel>> LoadExcercise(string muscleType)
        {
            ApiHelper.InitializeClient();
            string url = $"https://api.api-ninjas.com/v1/exercises?X-Api-Key=55HU/e2ckf1bPLLgQ5xM2Q==81T2Xa1i7KRZIGQZ&muscle={muscleType}";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    List<ExcerciseModel> excerciseList = JsonConvert.DeserializeObject<List<ExcerciseModel>>(responseContent);
                    return excerciseList;
                }
                else
                {
                    Console.WriteLine($"Error: {response.ReasonPhrase}");
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

    }
}
