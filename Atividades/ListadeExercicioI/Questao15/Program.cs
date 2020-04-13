using System;

namespace Questao15
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 15- Entrar com o número e a base em que se deseja calcular o logaritmo desse número e 
            imprimi-lo. */
            
            Console.Write("Escreva um número: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Logaritimo base 10 ou 2: ");
            int log = int.Parse(Console.ReadLine());

            if (log == 10)
            {
                System.Console.WriteLine($"Resultado: {Math.Log10(num)}");
            }
            else if (log == 2)
            {
                System.Console.WriteLine($"Resultado: {Math.Log2(num)}");
            }
            else
            {
                System.Console.WriteLine("Base inválida!");
            }   
        }
    }
}
