using System;

namespace Questao22
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 22) Entrar com três números e armazenar o maior número na variável de nome
            maior (suponha números diferentes). */

            // var
            float num1, num2, num3, maior;

            // codigo
            Console.Write("1º Número: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("2º Número: ");
            num2 = float.Parse(Console.ReadLine());
            Console.Write("3º Número: ");
            num3 = float.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3){
                maior = num1;
            }
            else if (num2 > num1 && num2 > num3){
                maior = num2;
            }
            else {
                maior = num3;
            }

            System.Console.WriteLine(maior);
        }
    }
}
