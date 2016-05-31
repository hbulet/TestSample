using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a sequence of numbers separated by commas: ");
            var inputNums = Console.ReadLine();
            var numList = inputNums.Split(new char[] { ',' }).Select(x => int.Parse(x)).ToList();
            var checkedNums = new List<int>();
            var duplicateNums = new List<int>();
            foreach (var num in numList)
            {
                var dupFound = false;
                for(var i = 0; i < checkedNums.Count(); i++)
                {
                    if(num == checkedNums[i])
                    {
                        if(!duplicateNums.Contains(num))
                        {
                            duplicateNums.Add(num);
                        }
                        dupFound = true;
                        break;
                    }
                }

                if(!dupFound)
                {
                    checkedNums.Add(num);
                }
            }

            Console.WriteLine("Duplicated numbers are: ");
            duplicateNums.OrderBy(x => x).ToList().ForEach(num => Console.Write(num.ToString() + ", "));
            Console.ReadLine();
        }
    }
}
