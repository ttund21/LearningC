using System;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tirar a média de 4 números;

            // Variaveis
            float num1, num2, num3, num4;

            // Codigo
            Console.Write("Escreva o 1º número: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Escreva o 2º número: ");
            num2 = float.Parse(Console.ReadLine());
            Console.Write("Escreva o 3º número: ");
            num3 = float.Parse(Console.ReadLine());
            Console.Write("Escreva o 4º número: ");
            num4 = float.Parse(Console.ReadLine());

            System.Console.WriteLine($"\nMédia: {(num1 + num2 + num3 + num4) / 4}");
            

        }
    }
}
