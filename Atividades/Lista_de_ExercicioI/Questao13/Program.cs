using System;

namespace Questao13
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 13- Entrar com um ângulo em graus e imprimir : seno, co-seno, tangente, secante, co-
            secante e co-tangente deste ângulo. */
            
            Console.Write("Escreva um ângulo:");
            int angulo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Seno: {Math.Sin(angulo)}");
            Console.WriteLine($"Cosseno: {Math.Cos(angulo)}");
            Console.WriteLine($"Tangente: {Math.Tan(angulo)}");

            Console.WriteLine($"\nCo-secante: {1/Math.Sin(angulo)}");
            Console.WriteLine($"Secante: {1/Math.Cos(angulo)}");
            Console.WriteLine($"Co-tangente: {1/Math.Tan(angulo)}");
        }
    }
}
