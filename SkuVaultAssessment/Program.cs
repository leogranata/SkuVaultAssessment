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
            
        }
    }

    public class FizzBuzz
    {
        private readonly IEnumerable<int> _numbers;
        public FizzBuzz(int end, int start = 0)
        {
            if (start < end)
            {
                throw new Exception("Start must be less end.");
            }
            _numbers = Enumerable.Range(start, end - start).ToList();
        }
        public string RunFizzBuzz()
        {
            // TODO: add implementation here
        }
    }
}
