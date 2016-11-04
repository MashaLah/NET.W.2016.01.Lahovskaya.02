using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task1UI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array= { 546394, 783282, 0, -87987, 10, 1241689, 159, -159, 32, -5, -27};
            foreach (int a in array) Console.Write("{0} ", a);
            Console.WriteLine();
            int? result = FindIndex.Find(array);
            if (result!=null)
            {
                Console.WriteLine("Index = {0}", result);
            }
            else
            {
                Console.WriteLine("Index doesn't exist or array length < 3.");
            }
            Console.ReadLine();
        }
    }
}
