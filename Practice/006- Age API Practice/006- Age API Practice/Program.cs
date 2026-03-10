using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace _006__Age_API_Practice
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //stores entered names
            List<string> nameList = new List<string>();

            //Stores age objects
            List <Age> ageList = new List<Age>();

            //asks the user to enter 3 names and adds them to the list
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a name:");
                string name = Console.ReadLine().ToLower();
                nameList.Add(name);
            }

            Console.WriteLine("Entered Names:");
            foreach (string name in nameList)
            {
                Age age = await GetAgeAsync(name);
                ageList.Add(age);
                Console.WriteLine(age);
            }
            //sorts the age list in descending order
            ageList = ageList.OrderByDescending(a => a.age).ToList();

            //Displays the oldest name
            Console.WriteLine("Oldest Name:");
            Console.WriteLine(ageList[0].ToString());
            




        }

        //Get Age objects with API call

        public static async Task<Age> GetAgeAsync(string name)
        {
           Age age = new Age();

            //creating URL
            string baseURL = "https://api.agify.io";
            string queryString = $"?name={name}";

            string url = baseURL + queryString;

            try
            {
                // Create client object
                HttpClient client = new HttpClient();

                // Make the reuest
                HttpResponseMessage response = await client.GetAsync(url);

                // Pull out the content
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();

                    // Deserialize into object
                    age = JsonSerializer.Deserialize<Age>(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Empty
            }
            return age;

        }
    }
}
