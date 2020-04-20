using System;

namespace Questao9
{
    class Program
    {
        static void Main(string[] args)
        {   
            /* Elaborar um algoritmo que calcule e imprima o valor de S.
            S = 1/1 + 3/2 + 5/3 + 7/4 + ... + 99/50 */

            // var
            float divisor = 1, dividendo = 1, resultado, total = 0;

            // codigo
            do{
                resultado = dividendo / divisor;
                total += resultado; 
                System.Console.WriteLine($"{dividendo} / {divisor} = {dividendo/divisor}");

                divisor += 1;
                dividendo += 2;                
            }while(divisor <= 50);
            System.Console.WriteLine($"Total: {total}");
        }
    }
}
