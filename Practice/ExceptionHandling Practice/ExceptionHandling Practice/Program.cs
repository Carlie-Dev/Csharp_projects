namespace ExceptionHandling_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Writing your own exception notes
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter a number");
                    int num1 = int.Parse(Console.ReadLine());

                    //Out of length of number exception
                    if (num1 > 1000000 || num1 < -1000000) { 
                        throw new NumOutOfRangeException("Number must be between 1000000 and -1000000.");
                    }

                    Console.WriteLine("Please enter another number:");
                    int num2 = int.Parse(Console.ReadLine());

                    //Out of length of number exception
                    if (num2 > 1000000 || num2 < -1000000)
                    {
                        throw new NumOutOfRangeException("Number must be between 1000000 and -1000000.");
                    }

                    int result = num1 / num2;
                    Console.WriteLine(result);
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please enter the numbers in numerical format.");
                    Console.WriteLine(ex.Message);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("You can't divide by zero, dummy!");
                }
                catch(NumOutOfRangeException ex) 
                {
                    Console.WriteLine(ex.Message); 
                }
                catch (Exception ex) //general exception
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Thanks for using my program :D");
                    //good for disconnecting from connections
                }
            }

          
        }
    }
}
