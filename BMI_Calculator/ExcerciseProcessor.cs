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
