using System;
using System.Collections.Generic;
namespace Questao12
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 12- Entrar com quatro números e imprimir a média ponderada, 
            sabendo-se que os pesos são respectivamente: 1,2,3 e 4. */

            Console.Write("Escreva o 1º Número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Escreva o 2º Número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Escreva o 3º Número: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Escreva o 4º Número: ");
            int num4 = int.Parse(Console.ReadLine());
            
            var mediaPond = ((num1 * 1) + (num2 * 2) + (num3 * 3) + (num4 * 4)) / 10;
            System.Console.WriteLine($"\nMédia Ponderada: {mediaPond}");
        }
    }
}
