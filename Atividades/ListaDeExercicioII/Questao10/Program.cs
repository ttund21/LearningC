using System;

namespace Questao10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10) Entrar com um número e informar se o dígito da dezena é par ou ímpar.
            
            // var
            int num;

            // codigo
            Console.Write("Escreva o numero: ");
            num = int.Parse(Console.ReadLine());

            if ((num/10)%2 == 0){
                System.Console.WriteLine("Par");
            }
            else {
                System.Console.WriteLine("Impar");
            }
        }
    }
}
