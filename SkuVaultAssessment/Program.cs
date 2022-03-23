using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkuVaultAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = 0;
            Console.WriteLine("Input a number and press ENTER to continue:");
            string numberInput = Console.ReadLine();
            if (!int.TryParse(numberInput, out endNumber))
            {
                Console.WriteLine($"Input must be a number from 0 to {int.MaxValue}");
            }
            else
            {
                Console.WriteLine("Results:");
                try
                {
                    FizzBuzz fb = new FizzBuzz(endNumber);
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
