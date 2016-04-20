using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1001Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeRank = 10001;
            var primeList = new List<Int64>() { 2, 3, 5, 7, 11, 13 };

            Int64 checkPrime = 15; // After 13 only check odd numbers for prime numbers so we start at 15
            while (primeList.Count < primeRank)
            {
                var isPrime = true;
                var divisor = checkPrime - 2;
                while (divisor > 2)
                {
                    if (checkPrime % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }

                    if (divisor > 13)
                        divisor -= 2;
                    else // below 13 check all divisors
                        divisor--;
                }

                if (isPrime)
                {
                    primeList.Add(checkPrime);
                }

                checkPrime += 2; // increment to the next odd number
            }

            Console.WriteLine("10001st prime is " + primeList.Last());
            Console.Read();
        }
    }
}
