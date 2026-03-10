using System.Text.Json;
using System.Text.Json.Serialization;

namespace API_Practice
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("How many dog facts do you want, please enter a number 1-5.");

            int limit = int.Parse(Console.ReadLine());

            Fact fact = await GetFactAsync(limit);
            Console.WriteLine(fact);

        }


        public static async Task<Fact> GetFactAsync(int limit)
        {

            //create object to return
            Fact fact = new Fact();

            //create URL 
            string baseURL = "https://dogapi.dog/api/v2/";
            string endpoint = "facts";
            string query = $"?limit={limit}";

            string url = baseURL + endpoint + query;

            //Attempt the call
            try
            {
                // Create client object
                HttpClient client = new HttpClient();

                //attempt to get a response
                HttpResponseMessage respose = await client.GetAsync(url);

                //pull out the content
                if (respose.IsSuccessStatusCode)
                {
                    string content = await respose.Content.ReadAsStringAsync();

                    //Deserialize into object
                    fact = JsonSerializer.Deserialize<Fact>(content);
                }
            }
            catch (Exception ex) {
                Console.WriteLine($"Error: {ex.Message}");    
            }
            finally
            {
                //empty
            }

            return fact;
        }

    }
}
