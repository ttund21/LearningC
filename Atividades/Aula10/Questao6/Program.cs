using System;
using System.Linq;
using System.Collections.Generic;

namespace Questao6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Elaborar um algoritmo que leia um número indeterminado de idades, dos indivíduos de uma
            determinada cidade, calcule e imprima a idade média deste grupo de indivíduos. 
            Adote a idade de valor “0” (zer0) como condição de finalização da leitura. */

            // var
            List<int> idades = new List<int>();
            int idade, i = 1;

            // codigo
            System.Console.WriteLine("0 para finalizar.");
            while(true){
                System.Console.Write($"{i}ª Idade: ");
                idade = int.Parse(Console.ReadLine());
                if (idade == 0){
                    break;
                }
                else{
                    idades.Add(idade);
                }
                ++i;
            }
            System.Console.WriteLine($"Média de idade: {idades.Sum() / idades.Count()}");
        }
    }
}
