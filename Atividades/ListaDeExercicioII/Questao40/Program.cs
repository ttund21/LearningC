using System;
using System.Collections;
using System.Collections.Generic;

namespace Questao40
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 40) Ler 3 valores (variáveis a, b e c) e efetuar o cálculo da equação de segundo grau,
            apresentando as raízes, se para os valores informados for possível efetuar o referido
            cálculo. */

            // var
            List<int> numberList = new List<int>();
            List<string> letterList = new List<string>{"a", "b", "c"};
            double delta, x1, x2;

            // codigo
            for (int i = 0; i < 3; ++i){
                System.Console.Write($"{letterList[i]}: ");
                numberList.Add(int.Parse(Console.ReadLine()));
            }

            delta = (Math.Pow(numberList[1], 2)) - (4 * numberList[0] * numberList[2]);

            x1 = (-(numberList[1]) + Math.Sqrt(delta)) / (2 * numberList[0]);
            x2 = (-(numberList[1]) - Math.Sqrt(delta)) / (2 * numberList[0]);
            
            System.Console.WriteLine($"\nX¹: {x1}\nX²: {x2}");
            

        }
    }
}
