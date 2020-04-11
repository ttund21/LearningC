using System;

namespace Questao5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5)Entrar com um número e informar se ele é divisível por 3 e por 5.
            
            // var
            int num;
            
            // codigo
            Console.Write("Escreva um numero: ");
            num = int.Parse(Console.ReadLine());

            if (num%3 == 0 && num%5 == 0){
                System.Console.WriteLine("Divisivel");
            }
            else{
                System.Console.WriteLine("Não divisivel");
            }
        }
    }
}
