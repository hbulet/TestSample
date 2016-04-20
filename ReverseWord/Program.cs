using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a sentense: ");
            var inputWord = Console.ReadLine();
            var reverseWdList = inputWord.Split(new char[] { ' ' }).Reverse();
            var reverseWd = string.Empty;
            foreach (var wd in reverseWdList)
            {
                reverseWd += wd + " ";
            }

            Console.WriteLine("sentense in reverse: " + reverseWd);
            Console.ReadLine();
        }
    }
}
