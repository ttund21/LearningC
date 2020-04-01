using System;

namespace Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Faça um algoritmo para ler três valores reais e
            informar se estes podem ou não formar os lados de
            um triângulo e qual tipo de triângulo seria:
            Equilátero, Isóscele ou Escaleno;*/

            float num1, num2, num3;

            Console.Write("1º Número: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("2º Número: ");
            num2 = float.Parse(Console.ReadLine());
            Console.Write("3º Número: ");
            num3 = float.Parse(Console.ReadLine());

            if (num1 == num2 && num2 == num3){
                System.Console.WriteLine("Equilatero.");
            }
            else if((num1 == num2) | (num2 == num3) | (num3 == num1)) {
                System.Console.WriteLine("Isoceles.");
            }
            else{
                System.Console.WriteLine("Escaleno.");
            }
        }
    }
}
