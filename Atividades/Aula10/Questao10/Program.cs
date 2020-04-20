using System;

namespace Questao10
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Elaborar um algoritmo que calcule e imprima a seguinte soma:
            2¹/50 + 2²/49 + 2³/48 +...+ 2^50/1   */
            
            // var
            double divisor = 50, resultado, total = 0, elevacao = 1;

            // codigo
            do{
                resultado = Math.Pow(2, elevacao)/divisor;
                System.Console.WriteLine($"2^{elevacao}/{divisor} = {resultado}");
                total += resultado;
                ++elevacao;
                --divisor;
            }while(elevacao <= 50);
            System.Console.WriteLine($"Total = {total}");
        }
    }
}
