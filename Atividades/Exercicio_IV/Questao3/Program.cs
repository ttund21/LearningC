using System;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Converter um valor em R$ (real) para U$ (dóllar);

            // Variaveis
            float real;

            // Codigo
            Console.Write("Real: R$");
            real = float.Parse(Console.ReadLine());

            System.Console.WriteLine($"\nReal: R${real}\nDolar: ${real * 4.64}");
        }
    }
}
