using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace Task2UI
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstStr = "xyaabbbccccdefww";
            string secondStr = "xxxxyyyyabklmopq";
            Console.WriteLine("First string: " + firstStr);
            Console.WriteLine("Second string: " + secondStr);
            string str = ConcatedString.MakeString(firstStr, secondStr);
            Console.WriteLine("Result: " + str);
            Console.ReadLine();
        }
    }
}
