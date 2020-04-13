using System;

namespace Questao18
{
    class Program
    {
        static void Main(string[] args)
        {
            // 18) Entrar com dois números e imprimir o menor número (suponha números diferentes).

           // var
            float num1, num2;

            // codigo
            Console.Write("1º Número: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("2º Número: ");
            num2 = float.Parse(Console.ReadLine());

            if (num1 < num2){
                System.Console.WriteLine(num1);
            }
            else if (num2 < num1){
                System.Console.WriteLine(num2);
            }
            else {
                System.Console.WriteLine("São iguais.");
            }
        }
    }
}
