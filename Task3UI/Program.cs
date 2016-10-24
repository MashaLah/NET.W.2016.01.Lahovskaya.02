using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3;

namespace Task3UI
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = InsertBytes.Insert(8, 15, 0, 0);
            Console.WriteLine(a);
            int b = InsertBytes.Insert(0, 15, 30, 30);
            Console.WriteLine(b);
            int c = InsertBytes.Insert(0, 15, 0, 30);
            Console.WriteLine(c);
            int d = InsertBytes.Insert(15, -15, 0, 4);
            Console.WriteLine(d);
            int e = InsertBytes.Insert(15, int.MaxValue, 3, 5);
            Console.WriteLine(e);
            Console.ReadLine();
        }
    }
}
