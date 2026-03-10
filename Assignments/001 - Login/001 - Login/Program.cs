namespace _001___Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hardcoded credentials
            string username = "Brine";
            string password = "theREALhero";

            while (true)
            {
                // Prompt the user to enter their username
                Console.WriteLine("Enter your username:");
                string inputUsername = Console.ReadLine();

                // Prompt the user to enter their password
                Console.WriteLine("Enter your password:");
                string inputPassword = Console.ReadLine();

                if (inputUsername == username && inputPassword == password)
                {
                    Console.WriteLine("Login successful! Welcome, " + username + "!");
                    break; // Exit the loop on successful login
                }
                else
                {
                    Console.WriteLine("Login failed! Incorrect username or password. Please try again.");
                }
            }

        }
    }
}
