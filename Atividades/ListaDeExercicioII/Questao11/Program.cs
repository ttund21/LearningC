using System;

namespace Questao11
{
    class Program
    {
        static void Main(string[] args)
        {
            // 11) Entrar com um número e informe se sua raiz quadrada é inteira.
            
            // var
            int num,cont = 0;

            // codigo
            Console.Write("Escreva o numero: ");
            num = int.Parse(Console.ReadLine());

            while(cont < num){
                ++cont;
                if (cont * cont == num){
                    System.Console.WriteLine($"Raiz Inteira, {Math.Sqrt(num)}");
                    break;
                }
                else if (cont == num){
                    System.Console.WriteLine($"Raiz Quebrada, {Math.Sqrt(num)}");
                }
            }
        }
    }
}
