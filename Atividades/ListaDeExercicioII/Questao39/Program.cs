using System;

namespace Questao39
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 39) Ler um número e imprimir se ele é igual a 5, ou se é igual a 200, ou se é igual a
            400, ou se ele está no intervalo entre 500 e 1000, ou se ele está fora dos escopos 
            anteriores.*/

            // var
            int num;

            // codigo
            Console.Write("Número: ");
            num = int.Parse(Console.ReadLine());

            if (num == 5){
                System.Console.WriteLine("Igual à 5.");
            }
            else if (num == 200){
                System.Console.WriteLine("Igual à 200.");
            }
            else if (num == 400){
                System.Console.WriteLine("Igual à 400.");
            }
            else if (num >= 500 && num <= 1000){
                System.Console.WriteLine("Em um intervalo entre 500 e 1000");
            }
            else {
                System.Console.WriteLine("Fora do escopo.");
            }
        }
    }
}
