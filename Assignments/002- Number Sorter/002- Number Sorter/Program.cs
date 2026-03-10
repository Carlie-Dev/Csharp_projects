namespace _002__Number_Sorter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int input;

            Console.WriteLine("Welcome!");

            for (int i = 0; i < 5; i++)
            {

                while (true)
                {
                    try
                    {
                        Console.WriteLine("Please enter number " + (i + 1) + ": ");
                        input = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("That's not a number, try again.");
                    }

                }
                numbers[i] = input;
            }
            Console.WriteLine("Thank you! Sorting your numbers!");

            //using asencending sort method because I feel lazy
            Array.Sort(numbers);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

        }
    }
}
