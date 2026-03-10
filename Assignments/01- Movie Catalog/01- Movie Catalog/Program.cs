using System.ComponentModel.Design;

namespace _01__Movie_Catalog
{
    internal class Program
    {
        //Carlie Peters (McDermott)
        //Movie Catalog
        static void Main(string[] args)
        {
            //List for storing movies
            List<Movie> catalog = new List<Movie>();
            //answer variable for menu selection
            string answer;

            Console.WriteLine("Welcome to Movie Magic!");
            while (true) {
                Console.WriteLine("-------\nSelect one of the following.\n1. Add Movie\n2.View Catalog\n3. Search Catalog\n4. Exit");
                answer = Console.ReadLine();
                if (answer == "1")
                {
                    //make new movie object
                    Movie movie = new Movie();
                    //ask user for values
                    Console.WriteLine("You selected 'Add Movie' - Enter the following values.");
                    Console.Write("Movie Title: ");
                    movie.Title = Console.ReadLine();
                    Console.Write("Release date: ");
                    movie.ReleaseDate = Console.ReadLine();
                    //display what they entered to user
                    Console.WriteLine("---\n"+ movie.ToString());
                    //add the movie to the catalog with .Add()
                    catalog.Add(movie);
                    
                }
                else if (answer == "2")
                {
                    //variables for this sections menus
                    int num = 1;
                    string mSelect;

                    Console.WriteLine("You selected 'View Catalog'");
                    //create numbered list for user to be able to select an item
                    foreach (Movie i in catalog) { 
                        Console.WriteLine($"({num}) {i.ToString()}");
                        num++;
                    }
                    Console.WriteLine("Type the corresponding number to add to the 'times watched' count.\nType 'n' to return to main menu.");

                    while (true)
                    {
                        try
                        {
                            mSelect = Console.ReadLine();
                            //If user selects n - Continue with the program
                            if (mSelect == "n") { break; }

                            //attempts to parse user selection into and integer. Subtracts 1 to get the index number
                            int index = int.Parse(mSelect) - 1;
                            //updates the movie watch count
                            catalog[index].WatchMovie();
                            //Displays updated count
                            Console.WriteLine(catalog[index].ToString());
                            break;
                        }
                        catch
                        {
                            //if answer is out of bounds of the array or not a valid option, prompts user to try again
                            Console.WriteLine("That is not a valid option. Please try again.");
                        }
                    }
                }else if (answer == "3")
                {
                    string search;
                    Console.WriteLine("You selected 'Search Catalog'");
                    Console.Write("Please enter the movie name: ");
                    search = Console.ReadLine();
                    
                    //look to see if the movie exists inside the catalog - defined variables
                    Movie found = new Movie();
                    bool itemExists = false;
                    //search through catalog for the movie
                    foreach (Movie i in catalog) {
                        if (i.Title == search)
                        {
                            itemExists = true;
                            found = i;
                            break;
                        }
                    }
                    if (itemExists == true) { 
                        Console.WriteLine(found.ToString());

                        Console.WriteLine($"Would you like to update your {found.Title} ({found.ReleaseDate})'s watch time?\n Type 'y' to up by 1 - Type 'n' to go back to the main menu.");
                        while (true)
                        {
                            search = Console.ReadLine();
                            if (search == "n")
                            {
                                break;
                            }
                            else if (search == "y")
                            {
                                found.WatchMovie();
                                found.ToString();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter 'y' or 'n': ");
                            }
                        }
                        

                    }
                    else
                    {
                        Console.WriteLine($"{search} does not exist in your catalog");
                    }

                }
                else if (answer == "4") {
                    //exiting enviroment
                    Console.WriteLine("Exiting...");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                    break;
                }
            }
            
        }
    }
}
