using System;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3)Entrar com um número e imprimir uma das mensagens: par ou ímpar.
            
            // var
            int num;
            
            // codigo
            Console.Write("Escreva um numero: ");
            num = int.Parse(Console.ReadLine());

            if (num%2 == 0){
                System.Console.WriteLine("Par.");
            }
            else{
                System.Console.WriteLine("Impar.");
            }
        }
    }
}
