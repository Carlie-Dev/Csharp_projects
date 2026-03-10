namespace _003__Interest_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            double rate;
            double principle;
            int years;
            double interest;

            Console.WriteLine("Hello! Welcome to your handy interst calculator :D\nPlease enter the prompted values.");

            //getting data

            Console.WriteLine("Principle:");
            while (true)
            {
                try
                {
                    principle = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Sorry that was not a valid principle.");
                }
            }
            Console.WriteLine("Interest Rate:");
            while (true)
            {
                try
                {
                    rate = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Sorry that was not a valid interest rate.");
                }
            }
            Console.WriteLine("Years:");
            while (true)
            {
                try
                {
                    years = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a valid number of years.");
                }

            }

            //calculation
            interest = principle * rate * years;

            Console.WriteLine($"You earned ${interest} in interest!");

        }
      
    }
}
