using System;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um algoritmo para ler dois números inteiros e informar se estes números são iguais ou diferentes;
            int num1, num2;
            
            Console.Write("Escreva o 1º Número:");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Escreva o 2º Número:");
            num2 = int.Parse(Console.ReadLine());

            if(num1 == num2) {
                System.Console.WriteLine("São iguais.");
            }
            else {
                System.Console.WriteLine("São diferentes.");
            }

        }
    }
}
