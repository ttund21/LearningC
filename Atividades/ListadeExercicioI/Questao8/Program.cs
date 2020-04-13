using System;

namespace Questao8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8-Idem ao no 7, imprimindo o produto.
            Console.Write("1º Número: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("2º Número: ");
            int secondNumber = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"{firstNumber * secondNumber}");
        }
    }
}
