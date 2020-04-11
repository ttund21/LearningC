using System;

namespace Questao7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 7)Construir um algoritmo que indique se o número digitado está compreendido
            entre 20 e 90 ou não. */

            // var
            int num;

            // codigo
            Console.Write("Escreva o numero: ");
            num = int.Parse(Console.ReadLine());

            if (num >= 20 && num <= 90){
                System.Console.WriteLine("Está entre 20 e 90");
            }
            else{
                System.Console.WriteLine("Fora do range");
            }
        }
    }
}
