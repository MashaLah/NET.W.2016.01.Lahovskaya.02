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
            int a = 8;
            if(InsertBytes.Insert(ref a, 15, 0, 0))
            Console.WriteLine(a);
            int b = 0;
            if(InsertBytes.Insert(ref b, 15, 30, 30))
            Console.WriteLine(b);
            int c = 0;
            if(InsertBytes.Insert(ref c, 15, 0, 30))
            Console.WriteLine(c);
            int d = 15;
            if(InsertBytes.Insert(ref d, -15, 0, 4))
            Console.WriteLine(d);
            int e = 15;
            if(InsertBytes.Insert(ref e, int.MaxValue, 3, 5))
            Console.WriteLine(e);
            int f = 8;
            if(InsertBytes.Insert(ref f, 15, 10, 0))
            Console.WriteLine(e);
            Console.ReadLine();
        }
    }
}
