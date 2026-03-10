using Newtonsoft.Json;
using System.ComponentModel.Design;
namespace _06___Pokemon_Midterm
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Lists
            List<Pokemon> pokemon = new List<Pokemon>();
            List<Berry> berries = new List<Berry>();
            List<Item> items = new List<Item>();
            List<Move> moves = new List<Move>();


            string input;
            string objChoice;


            //Pokemon tempPokemon = await GetPokeAsync(input);
            //pokemon.Add(tempPokemon);
            //Console.WriteLine(tempPokemon.ToString());

            //input = "cheri";
            //Berry tempBerry = await GetBerryAsync(input);
            //berries.Add(tempBerry);
            //Console.WriteLine(tempBerry.ToString());

            //input = "1";
            //Item tempItem = await GetItemAsync(input);
            //Console.WriteLine(tempItem.ToString());

            //input = "1";
            //Move tempMove = await GetMoveAsync(input);
            //Console.WriteLine(tempMove.ToString());

            while (true)
            {
                Console.WriteLine("---\nWelcome to your personal pokedex! Let's catch them all!\nSelect an option bellow to get started.\n 1. Search API for Pokemon data.\n 2. View Previous searches.\n 3. Exit Program");

                input = Console.ReadLine();

                if (input == "1")
                {
                    Console.Clear();
                    //API Menu
                    while (true)
                    {
                        Console.WriteLine("Type pokemon, berry, move, or item\ntype back to exit.");
                        input = Console.ReadLine().ToLower();
                        if (input == "pokemon")
                        {
                            Console.Clear();
                            //Ask for pokemon identifier
                            Console.WriteLine("Enter Pokemon Name or ID:");
                            input = Console.ReadLine().ToLower();
                            //make temporary pokemon
                            Pokemon tempPokemon = await GetPokeAsync(input);
                            //store pokemon in pokemon list
                            if(tempPokemon.name != null)
                            {
                               pokemon.Add(tempPokemon);
                            }
                            
                            //display result
                            Console.WriteLine(tempPokemon.ToString());

                        }
                        else if (input == "berry")
                        {
                            Console.Clear();
                            //Berry logic
                            Console.WriteLine("Enter berry Name or ID:");
                            input = Console.ReadLine().ToLower();

                            Berry tempBerry = await GetBerryAsync(input);
                            if (tempBerry.name != null)
                            {
                                berries.Add(tempBerry);
                            }
                            Console.WriteLine(tempBerry.ToString());
                        }
                        else if (input == "item")
                        {
                            Console.Clear();
                            //item logic
                            Console.WriteLine("Enter item Name or ID:");
                            input = Console.ReadLine().ToLower();

                            Item tempItem = await GetItemAsync(input);
                            if (tempItem.name != null)
                            {
                                items.Add(tempItem);
                            }
                            Console.WriteLine(tempItem.ToString());

                        }
                        else if (input == "move")
                        {
                            Console.Clear();
                            //moves logic
                            Console.WriteLine("Enter move Name or ID:");
                            input = Console.ReadLine().ToLower();

                            Move tempMove = await GetMoveAsync(input);
                            if (tempMove.name != null)
                            {
                                moves.Add(tempMove);
                            }
                            Console.WriteLine(tempMove.ToString());
                        }
                        else if (input == "back")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid option.");
                        }

                    }
                }else if (input == "2")
                {
                    //View lists
                    Console.Clear();
                   
                    while (true)
                    {
                        Console.WriteLine("Which list would you like to view? Pokemon, berries, moves, or items?\nType back to go back.");
                        input = Console.ReadLine().ToLower();

                        if (input == "pokemon")
                        {
                            Console.Clear();
                            if (pokemon.Count != 0)
                            {
                                int i = 1;
                                foreach (var poke in pokemon)
                                {
                                    Console.WriteLine($"{i}.) {poke.id} - {poke.name}");
                                    i++;
                                }

                                //Viewing pokemon
                                Console.WriteLine("Type number on list to view more details.\n Type back to go back.");
                                string pokeView = Console.ReadLine();
                                if(pokeView == "back")
                                {
                                    break;
                                }
                                //Try to pull up answer
                                try
                                {
                                    int pokeNum = int.Parse(pokeView);
                                    Console.WriteLine(pokemon[pokeNum - 1].ToString());
                                }catch (Exception ex) 
                                {
                                    Console.WriteLine("Invalid number please try again."); 

                                }

                            }
                            else
                            {
                                Console.WriteLine("There are no recent searches for pokemon.");
                            }
                        } else if (input == "berries")
                        {
                            Console.Clear();
                            if (berries.Count != 0)
                            {
                                int i = 1;
                                foreach (var berry in berries)
                                {
                                    Console.WriteLine($"{i}.) {berry.id} - {berry.name}");
                                    i++;
                                }
                                //Viewing Berries
                                Console.WriteLine("Type number on list to view more details.\n Type back to go back.");
                                string berryView = Console.ReadLine();
                                if (berryView == "back")
                                {
                                    break;
                                }

                                //Try to pull up answer
                                try
                                {
                                    int berryNum = int.Parse(berryView);
                                    Console.WriteLine(berries[berryNum - 1].ToString());
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Invalid number please try again.");

                                }


                            }
                            else
                            {
                                Console.WriteLine("There are no recent searches for berries.");
                            }
                        }
                        else if (input == "moves")
                        {
                            Console.Clear();
                            //Viewing moves
                            if (moves.Count != 0)
                            {
                                int i = 1;
                                foreach (var move in moves)
                                {
                                    Console.WriteLine($"{i}.) {move.id} - {move.name}");
                                    i++;
                                }
                                //Viewing Moves
                                Console.WriteLine("Type number on list to view more details.\n Type back to go back.");
                                string moveView = Console.ReadLine();
                                if (moveView == "back")
                                {
                                    break;
                                }

                                //Try to pull up answer
                                try
                                {
                                    int moveNum = int.Parse(moveView);
                                    Console.WriteLine(moves[moveNum - 1].ToString());
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Invalid number please try again.");

                                }


                            }
                            else
                            {
                                Console.WriteLine("There are no recent searches for moves.");
                            }


                        }
                        else if (input == "items")
                        {
                            Console.Clear();

                            if (items.Count != 0)
                            {
                                int i = 1;
                                foreach (var item in items)
                                {
                                    Console.WriteLine($"{i}.) {item.id} - {item.name}");
                                    i++;
                                }
                                //Viewing Items
                                Console.WriteLine("Type number on list to view more details.\n Type back to go back.");
                                string itemView = Console.ReadLine();
                                if (itemView == "back")
                                {
                                    break;
                                }

                                //Try to pull up answer
                                try
                                {
                                    int itemNum = int.Parse(itemView);
                                    Console.WriteLine(items[itemNum - 1].ToString());
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Invalid number please try again.");

                                }


                            }
                            else
                            {
                                Console.WriteLine("There are no recent searches for items.");
                            }

                        }
                        else if(input == "back")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a valid option");
                        }
                    }
                    
                }else if(input == "3")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a valid option.");
                }
     
            }
        }//End of main




        //Callers

        //Pokemon Caller
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

        //Berry Caller
        public static async Task<Berry> GetBerryAsync(string input)
        {

            Berry berry = new Berry();
            //https://pokeapi.co/api/v2/berry/{id or name}//
            //creating URL
            string baseURL = "https://pokeapi.co/api/v2/berry/";
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
                    berry = JsonConvert.DeserializeObject<Berry>(content);
                }

                if(berry?.item?.url != null)
                {
                    HttpResponseMessage itemResponse = await client.GetAsync(berry.item.url);
                    if (itemResponse.IsSuccessStatusCode)
                    {
                        string itemContent = await itemResponse.Content.ReadAsStringAsync();

                        // Deserialize into object --- Newtonsoft library is different than System.Text.Json
                        berry.item = JsonConvert.DeserializeObject<Berry.BerryItem>(itemContent);
                    }

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
            return berry;

        }


        //Item caller Caller

        public static async Task<Item> GetItemAsync(string input)
        {

            Item item = new Item();
            //https://pokeapi.co/api/v2/item/{id or name}//
            //creating URL
            string baseURL = "https://pokeapi.co/api/v2/item/";
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
                    item = JsonConvert.DeserializeObject<Item>(content);
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
            return item;

        }

        //Move caller
        public static async Task<Move> GetMoveAsync(string input)
        {

            Move move = new Move();
            //https://pokeapi.co/api/v2/item/{id or name}//
            //creating URL
            string baseURL = "https://pokeapi.co/api/v2/move/";
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
                    move = JsonConvert.DeserializeObject<Move>(content);
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
            return move;
        }


    }
}
