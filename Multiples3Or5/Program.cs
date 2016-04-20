using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3Or5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Sum of multiples 3 or 5: " + SumMultiples(3, 5, 10));
            Console.WriteLine("Sum of multiples 3 or 5: " + SumMultiples(3, 5, 1000));
            Console.Read();
        }

        public static Int64 SumMultiples(int val1, int val2, int roof)
        {
            Int64 multipleSum = 0;
            int start = val1 > val2 ? val2 : val1;

            var multiplaAdd = false;
            for (int i = start; i < roof; i++)
            {
                multiplaAdd = false;

                if ((i % val1) == 0)
                {
                    multipleSum += i;
                    multiplaAdd = true;
                }

                if (!multiplaAdd) // No need to add multiple if 1st case adds it
                {
                    if ((i % val2) == 0)
                        multipleSum += i;
                }
            }

            return multipleSum;
        }
    }
}
