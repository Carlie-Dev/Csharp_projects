using Newtonsoft.Json;

namespace _05_Pokemon
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
           string input = "pikachu";    
           

            Pokemon tempPokemon = await GetPokeAsync(input);    
            Console.WriteLine(tempPokemon.ToString());
            
        }
        public static async Task<Pokemon> GetPokeAsync(string input)
        {
            
            Pokemon pokemon = new Pokemon();
            //https://pokeapi.co/api/v2/pokemon/{id or name}/
            //creating URL
            string baseURL = "https://pokeapi.co/api/v2/pokemon/";
            string queryString = $"{input}";

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

                    // Deserialize into object --- Newtonsoft library is different than System.Text.Json
                    pokemon = JsonConvert.DeserializeObject<Pokemon>(content);
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
            return pokemon;

        }
    }
}

