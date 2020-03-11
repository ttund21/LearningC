using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um algoritmo que leia dois números e imprima a soma, a subtração, a multiplicação e a divisão;

            // Variaveis
            float num1, num2;

            // Codigo
            Console.Write("1º Número: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("2º Número: ");
            num2 = float.Parse(Console.ReadLine());

            System.Console.WriteLine($"\nSoma: {num1 + num2}\nSubtração: {num1 - num2}\nMultiplicação: {num1 * num2}\nDivisão: {num1 / num2}");
        }
    }
}
