using System;

namespace Questao6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 6)Entrar com um número e informar se ele é divisível por 10, ou é divisível por5,
             ou é divisível por 2 ou se não é divisível por nenhum destes */
            
            // var
            int num;
            
            // codigo
            Console.Write("Escreva um número: ");
            num = int.Parse(Console.ReadLine());

            if (num % 10 == 0){
                System.Console.WriteLine("Divisivel por 10");
            }
            if (num % 5 == 0){
                System.Console.WriteLine("Divisivel por 5");
            }
            if (num % 2 == 0){
                System.Console.WriteLine("Divisivel por 2");
            }
            if (num % 10 != 0 && num % 5 != 0 && num % 2 != 0){
                System.Console.WriteLine("Não é divisivel por nenhum");
            }
        }
    }
}
