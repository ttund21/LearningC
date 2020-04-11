using System;

namespace Questao14
{
    class Program
    {
        static void Main(string[] args)
        {
            // 14) Entrar com dois números e exibir se o primeiro é divisível pelo segundo.
            
            // var
            float num1, num2;
            
            // codigo
            Console.Write("Escreva o 1º número: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Escreva o 2º número: ");
            num2 = float.Parse(Console.ReadLine());

            if ((num1 % num2) == 0){ 
                System.Console.WriteLine("O primeiro é divisível pelo segundo.");
            }
            else {
                System.Console.WriteLine("O primeiro não é divisível pelo segundo.");
            }
        }
    }
}
