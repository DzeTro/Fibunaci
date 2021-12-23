using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibunaci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = 1;

            for (int i = 0; i < 10; i++)
            {
                Berechung(ref a, ref b, ref c);
            }
            Console.ReadKey();
        }

        private static void Berechung(ref int a, ref int b, ref int c)
        {
            Console.WriteLine(a + " " + b + " " + c);
            a = b + c;
            b = a + c;
            c = a + b;
        }
    }
}
