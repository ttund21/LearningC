using System;

namespace Questao16
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 16) Faça um programa que leia 2 números e imprima uma mensagem dizendo
            se são iguais ou diferentes. */

            // var 
            int num1, num2;

            // codigo
            Console.Write("1º Número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("2º Número: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 == num2){
                System.Console.WriteLine("São iguais.");
            }
            else {
                System.Console.WriteLine("São diferentes.");
            }
        }
    }
}
