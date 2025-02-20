using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string string1 = "Eu nao tenho Unicode";
            string bob = "Eu sou o bob";
            string string2 = "AHHHHH \u0032"
            Console.WriteLine($"{string1}, {bob}, {string2}");
        }
    }
}
