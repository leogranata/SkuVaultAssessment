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
                    FizzBuzz fb = new FizzBuzz(endNumber, -1);
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

    public class FizzBuzz
    {
        private readonly IEnumerable<int> _numbers;

        public FizzBuzz(int end, int start = 0)
        {
            if (end < start)
            {
                throw new Exception(ExceptionMessages.StartMustBeLessThanEnd);
            }
            if (start < 0)
            {
                throw new Exception(ExceptionMessages.StartMustBeGreaterThanZero);
            }

            _numbers = Enumerable.Range(start + 1, end - start).ToList();
        }

        public string RunFizzBuzz()
        {
            StringBuilder outputString = new StringBuilder();

            foreach (int i in _numbers)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    outputString.AppendLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    outputString.AppendLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    outputString.AppendLine("Buzz");
                }
                else
                {
                    outputString.AppendLine(i.ToString());
                }
            }
            return outputString.ToString();
        }
    }

    public static class ExceptionMessages
    {
        public const string StartMustBeLessThanEnd = "Start must be less than end.";
        public const string StartMustBeGreaterThanZero = "Start must be greater than zero.";
    }
}
