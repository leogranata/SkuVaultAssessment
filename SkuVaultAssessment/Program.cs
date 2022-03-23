using System;

namespace SkuVaultAssessment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input a number and press ENTER to continue:");
            string numberInput = Console.ReadLine();
            if (!int.TryParse(numberInput, out int endNumber))
            {
                Console.WriteLine($"Input must be a number from 0 to {int.MaxValue}");
            }
            else
            {
                Console.WriteLine("Results:");
                try
                {
                    var fb = new FizzBuzz.FizzBuzz(endNumber);
                    Console.WriteLine(fb.RunFizzBuzz());
                }
                catch (Exception ex)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("An Error has ocurred");
                    Console.WriteLine(ex.ToString());
                }
            }
            Console.ReadLine();
        }
    }
 
}
