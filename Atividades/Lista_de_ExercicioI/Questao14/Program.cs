using System;

namespace Questao14
{
    class Program
    {
        static void Main(string[] args)
        {
            // 14- Entrar com um número e imprimir o logaritmo desse número na base 10.
            Console.Write("Escreva um número: ");
            int num = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"Logaritimo Base 10: {Math.Log10(num)}");
        }
    }
}
