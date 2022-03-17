using System;

namespace VariasString
{
    class Program
    {
        static void Main(string[] args)
        {
            string normal = "Isto é uma string normal";
            string verbatim = "C:\\UsersNome_GenericoDocuments";
            string unicode = "Palavras \u004F\u004C\u0041";

            Console.WriteLine (normal);
            Console.WriteLine (verbatim);
            Console.WriteLine (unicode);

            int a = 1;
            int b = 2;
            int c = 3;

            string concatenacao = "Isto " + "são " + 2 + " strings";
            string interpolacao = $"{a} mais {b} é igual a {c}";

            Console.WriteLine (concatenacao);
            Console.WriteLine (interpolacao);
        }
    }
}
