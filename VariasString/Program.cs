using System;

namespace VariasString
{
    class Program
    {
        static void Main(string[] args)
        {
            string normal = "Isto é uma string normal";
            string verbatim = "C:\\UsersNome_GenericoDocuments";
            string unicode = "Palavras\u004F\u004C\u0041";

            Console.WriteLine (normal);
            Console.WriteLine (verbatim);
            Console.WriteLine (unicode);
            
        }
    }
}
