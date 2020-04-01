using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um algoritmo para ler um número inteiro e informar se o número é par ou ímpar;
            int num1;

            Console.Write("Escreva um número: ");
            num1 = int.Parse(Console.ReadLine());

            if(num1 % 2 == 0){
                System.Console.WriteLine("Par.");
            }
            else{
                System.Console.WriteLine("Impar.");
            }
        }
    }
}
