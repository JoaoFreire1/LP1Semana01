using System;
using System.Text;

namespace VariasString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            double xx = 0.12345;
            int ii = 18;

            string a = "Primeira String";
            Console.WriteLine(a);
            string b = "Segunda String";
            Console.WriteLine(b);
            string v1 = @"/String Verbatim\";
            Console.WriteLine(v1);
            string u1 = "String com Unicode \u0F23";
            Console.WriteLine(u1);
            string u2 = "String com Unicode \u2682";
            Console.WriteLine(u2);
            
            int x = 1;
            int y = 2;
            string a5 = "a" + 2;
            string b5 = "abc" + x;
            string c5 = "valor de x e’ {x}";
            string d5 = "{x} mais {y} e’ igual a {x + y}";
            string e5 = String.Format("Y e’ {1}, X e’ {0}", x, y);

            Console.WriteLine(@"Verbatim com x = {0}", x);

            Console.WriteLine(a5);
            Console.WriteLine(b5);
            Console.WriteLine(c5);
            Console.WriteLine(d5);
            Console.WriteLine(e5);

            Console.WriteLine("{0:0.00}", xx);
            Console.WriteLine("{0:P1}", xx);
            Console.WriteLine("{0:X}", ii);
            Console.WriteLine("{0:C}", ii);
        }
    }
}
