using System;

namespace Questao20
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 20)Entrar com dois números e imprimi-los em ordem decrescente (suponha
            números diferentes). */

           // var
            float num1, num2;

            // codigo
            Console.Write("1º Número: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("2º Número: ");
            num2 = float.Parse(Console.ReadLine());

            if (num1 > num2){
                System.Console.WriteLine($"{num1}, {num2}");
            }
            else if (num2 > num1){
                System.Console.WriteLine($"{num2}, {num1}");
            }
            else {
                System.Console.WriteLine("São iguais.");
            }           
        }
    }
}
