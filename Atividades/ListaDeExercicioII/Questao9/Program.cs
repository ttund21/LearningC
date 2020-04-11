using System;

namespace Questao9
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 9) Entrar com um número e imprimir uma das mensagens: maior do que 20 , é
            igual a 20 ou é menor do que 20.*/
            
            
            // var
            int num;

            // codigo
            Console.Write("Escreva o numero: ");
            num = int.Parse(Console.ReadLine());

            if (num > 20){
                System.Console.WriteLine("Maior que 20");
            }
            else if (num == 20){
                System.Console.WriteLine("Igual a 20");
            }
            else{
                System.Console.WriteLine("Menor que 20");
            }
        }
    }
}
