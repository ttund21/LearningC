using System;

namespace Questao15
{
    class Program
    {
        static void Main(string[] args)
        {
            // 15) Entrar com divisor e dividendo e informar se o produto é inteiro.

            // var
            float dividendo, divisor;

            // codigo
            Console.Write("Dividendo: ");
            dividendo = float.Parse(Console.ReadLine());
            Console.Write("Divisor: ");
            divisor = float.Parse(Console.ReadLine());

            if (dividendo % divisor == 0){
                System.Console.WriteLine($"Produto: {dividendo/divisor}, produto inteiro.");
            }
            else {
                System.Console.WriteLine($"Produto: {dividendo/divisor}, o produto é decimal.");
            }
        }
    }
}
