using System.ComponentModel.Design;

namespace _004__To_Do_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //selection variables
            int i;
            string answer;
            
            //List that takes in to do items
            List<ToDo> toDoList = new List<ToDo>();

            Console.WriteLine("Hello! Welcome to your To-Do List Manager!");
            while (true) {
                i = 1;
                Console.WriteLine("-----\nPlease Select an option below?\n 1 - Add To-Do\n 2 - View List\n 3 - Exit");
                answer = Console.ReadLine();

                if(answer == "1")
                {
                    string dueDate;
                    string desc;
                    Console.WriteLine("You selected add to-do item.");
                    Console.WriteLine("Due Date: ");
                    dueDate = Console.ReadLine();
                    Console.WriteLine("Task Description:");
                    desc = Console.ReadLine();

                    ToDo listItem = new ToDo(desc,dueDate);
                    toDoList.Add(listItem);

                }else if ( answer == "2" )
                {
                    Console.Write("You selected View List.\n");
                    foreach (ToDo toDo in toDoList)
                    { 
                        Console.WriteLine($"{i} " + toDo.ToString() +"\n");
                        i = i+1;
                    }

                    //item string for answer
                    string item;
                    //Prompt for user to mark items as complete
                    Console.WriteLine("Type the corresponding number to mark an item as complete\nType 'n' to return to main menu.");

                    while (true)
                    { 
                        try
                        {
                            item = Console.ReadLine();
                            //If user selects n
                            if (item == "n") { break; }

                            int index = int.Parse(item) - 1;
                            toDoList[index].MarkComple();
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("That is not a valid option. Please try again.");
                        }
                    }

                }
                else if (answer == "3" )
                {
                    Console.WriteLine("Exiting Program...");
                    //delay so exit doesn't feel jaring
                    Thread.Sleep(4000);
                    Environment.Exit(0);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Answer. Please try again.");
                }
            }

        }
    }
}
