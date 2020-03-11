using System;

namespace Questao9
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9-Ler um número real e imprimir a terça parte deste número.
            Console.Write("Escreva um nº: ");
            float number = float.Parse(Console.ReadLine());
            System.Console.WriteLine($"{number/3}");
        }
    }
}
