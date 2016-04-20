using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 firstTerm = 0, secondTerm = 1, evenSum = 0, limit = 4000000;

            List<Int64> fiboList = new List<long>() { 0 };

            while (secondTerm < limit)
            {
                fiboList.Add(secondTerm);

                if (secondTerm % 2 == 0)
                    evenSum += secondTerm;

                secondTerm += firstTerm;
                firstTerm = secondTerm - firstTerm;
            }

            Console.Write("Fibonacci sequence below four million: ");
            fiboList.ForEach(x => {
                Console.Write(x + ", ");
            });
            Console.WriteLine("");
            Console.WriteLine("Sum of even-valued terms:" + evenSum);
            Console.Read();
        }
    }
}
