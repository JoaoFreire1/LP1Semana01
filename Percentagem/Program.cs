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
            Console.WriteLine(nreal1);
            Console.WriteLine(nreal2);
            Console.WriteLine(nreal3);
            Console.WriteLine(nreal4);
        }
    }
}
