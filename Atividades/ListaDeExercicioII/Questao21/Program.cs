using System;

namespace Questao21
{
    class Program
    {
        static void Main(string[] args)
        {
            // 21) Entrar com três números e imprimir o maior número(suponha números diferentes).

            // var
            float num1, num2, num3;

            // codigo
            Console.Write("1º Número: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("2º Número: ");
            num2 = float.Parse(Console.ReadLine());
            Console.Write("3º Número: ");
            num3 = float.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3){
                System.Console.WriteLine(num1);
            }
            else if (num2 > num1 && num2 > num3){
                System.Console.WriteLine(num2);
            }
            else {
                System.Console.WriteLine(num3);
            }
        }
    }
}
