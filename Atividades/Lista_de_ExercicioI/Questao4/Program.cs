using System;

namespace Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4-Ler dois números inteiros e imprimi-los.
            Console.Write("Escreva o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Escreva o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"\nPrimeiro número: {num1}\nSegundo Número: {num2}");
        }
    }
}
