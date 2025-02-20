using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double xx = 1.23456;
            int ii = 19;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            string string1 = "Eu nao tenho Unicode";
            string bob = "Eu sou o bob";
            string string2 = "AHHHHH \u0032";
            Console.WriteLine($"{string1}, {bob}, {string2}");

            string string3 = "Im in Pain" + 5;
            string string4 = $"SHBD {bob}";
            string string5 = $"{bob} is bob-ing" + 3;
            Console.WriteLine($"{string3}, {string4}, {string5}");

            string s1 = $"{xx:f2}";
            string s2 = $"{xx:p1}";
            Console.WriteLine($"{s1}, {s2}");

            string s3 = $"{ii:X}";
            string s4 = $"{ii:C}";
            Console.WriteLine($"{s3}, {s4}");
        }
    }
}
