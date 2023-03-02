using System;
using System.Text;

namespace VariasString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

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
        }
    }
}
