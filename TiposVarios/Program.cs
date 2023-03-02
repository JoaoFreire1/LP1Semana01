using System;
using System.Text;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int a = 1;
            int b = 2;
            Console.WriteLine(a);
            Console.WriteLine(b);

            string S1 = "\u2682";
            string S2 = "\u0F23";
            Console.WriteLine(S1);
            Console.WriteLine(S2);

            double c = 3.75;
            double d = 4.20;
            Console.WriteLine(c);
            Console.WriteLine(d);

            bool t = true;
            bool f = false;
            Console.WriteLine(t);
            Console.WriteLine(f);

        }
    }
}
