using System;

namespace Questao23
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 23) Entrar com três números e imprimi-los em ordem crescente (suponha
            números diferentes). */

           // var
            float num1, num2, num3;

            // codigo
            Console.Write("1º Número: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("2º Número: ");
            num2 = float.Parse(Console.ReadLine());
            Console.Write("3º Número: ");
            num3 = float.Parse(Console.ReadLine());

            float[] lista = new float[] {num1, num2, num3};
            Array.Sort(lista);
            foreach(float i in lista){
                System.Console.Write($"{i} ");
            }
        }
    }
}
