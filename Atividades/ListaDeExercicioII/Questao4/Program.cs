using System;

namespace Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4)Entrar com um número e informar se ele é ou não divisível por 5.

            //var
            int num;

            // codigo
            Console.WriteLine("Escreva um numero: ");
            num = int.Parse(Console.ReadLine());

            if (num%5 == 0){
                System.Console.WriteLine("Divisivel");
            }
            else{
                System.Console.WriteLine("Não divisivel");
            }
        }
    }
}
