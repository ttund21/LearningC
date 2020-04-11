using System;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1)Entrar com um número e imprimi-lo caso seja maior do que 20.
            
            //var
            int num;

            // codigo
            Console.Write("Escreva um número: ");
            num = int.Parse(Console.ReadLine());

            if (num > 20){
                System.Console.WriteLine(num);
            }
        }
    }
}
