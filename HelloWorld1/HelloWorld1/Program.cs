using System;

namespace HelloWorld1
{
    class Program
    {
        static void Main(string[] args)
        {
            // try-catch-finally

            int numerator, denominator;

            try
            {
                Console.Write("Please enter numerator");
                numerator = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter denominator");
                denominator = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("The result is {0}", numerator / denominator);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: You did not enter an integer.");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("--- End of Error Handling Example ---");
            }


        }
    }
}
