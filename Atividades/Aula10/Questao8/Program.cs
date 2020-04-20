using System;

namespace Questao8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* A Série de FIBONACCI é definida como tendo os dois primeiros termos iguais a 1 
            e cada termo seguinte (a partir do terceiro) igual à soma dos dois termos imediatamente
            anteriores. Elaborar um algoritmo que imprima os 15 primeiros termos da Série de Fibonacci.
            1, 1, 2, 3, 5, 8, 13 ... */

            // var
            int a = 1, b = 1, c;

            // codigo
            System.Console.Write("1  1 "); // os dois primeiros valores da serie
            for (int i = 0; i < 15; ++i){
                c = a + b; // a soma dos 2 números anteriores 
                a = b; // definindo 'a' como o número anterior  
                b = c; // definido 'b' como o número a frente 
                System.Console.Write($" {c} ");            
            }
        }
    }
}
