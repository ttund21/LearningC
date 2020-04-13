using System;

namespace Questao24
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 24) Entrar com três números e imprimi-los em ordem decrescente (suponha
            números diferentes). */

           // var
            int num1, num2, num3;

            // codigo
            Console.Write("1º Número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("2º Número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("3º Número: ");
            num3 = int.Parse(Console.ReadLine());

            int[] lista = new int[] {num1, num2, num3};
            Array.Sort(lista);
            Array.Reverse(lista);
            foreach(int i in lista){
                System.Console.Write($"{i} ");
            }
        }
    }
}
