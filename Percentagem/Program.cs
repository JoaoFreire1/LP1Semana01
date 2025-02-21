using System;

namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere 4 números reais entre 0 e 1 :");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();
            string input4 = Console.ReadLine();
            float nreal1 = float.Parse(input1);
            float nreal2 = float.Parse(input2);
            float nreal3 = float.Parse(input3);
            float nreal4 = float.Parse(input4);
            string perc1 = $"{nreal1:p2}";
            string perc2 = $"{nreal2:p2}";
            string perc3 = $"{nreal3:p2}";
            string perc4 = $"{nreal4:p2}";
            Console.WriteLine(perc1);
            Console.WriteLine(perc2);
            Console.WriteLine(perc3);
            Console.WriteLine(perc4);
        }
    }
}
