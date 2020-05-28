using System;
using System.Linq;

namespace Questao03
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 3) Faça um algoritmo para escolher 20 números inteiros e em seguida escrever os
            números com valor acima da média de todos os números lidos; Dica: utilize a estrutura 
            de repetição FOR (Para). */

            // var
            int[] vetor = new int[4];

            // codigo
            for (int i = 0; i < vetor.Length; i++){
                System.Console.Write($"{i + 1}º Número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("--------- SAIDA ---------");
            System.Console.Write($"Média: {vetor.Sum() / vetor.Length}");
        }
    }
}
