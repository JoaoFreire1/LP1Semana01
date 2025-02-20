using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Por favor escreva um numero inteiro");
            string input = Console.ReadLine();
            int i = int.Parse(input);
            Console.WriteLine("Por favor escreva um numero real");
            string input2 = Console.ReadLine();
            float f = float.Parse(input2);
            int i2 = Convert.ToInt32(f);
            int i3 = i + i2;
            Console.WriteLine($"A soma de {i} com {i2} é {i3}");
        }
    }
}
