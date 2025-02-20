using System;
 using System.Text;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 

            int a = 1;
            long aa = 11;
            short aaa = 111;
            Console.WriteLine($"{a}, {aa}, {aaa}");

            char b = '\u0030';
            char bb = '\u0031';
            char bbb = '\u0032';
            Console.WriteLine($"{b}, {bb}, {bbb}");

            float c = 3,14f;
            double cc = 3,15;
            decimal ccc = 3,16m;
            Console.WriteLine($"{c}; {cc}; {ccc}");
        }
    }
}
