using System;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Faça um algoritmo para ler duas variáveis inteiras A e
            B e garantir que A e B fiquem em ordem crescente,
            ou seja, a variável A deverá armazenar o menor valor
            fornecido e a variável B o maior;*/

            float num1, num2;

            Console.Write("Escreva o 1º número: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Escreva o 2º número: ");
            num2 = float.Parse(Console.ReadLine());

            if(num1 > num2) {
                System.Console.WriteLine("Error.");
            }
            else {
                System.Console.WriteLine("Crescente.");
            }
        }
    }
}
