using System;

namespace Questao04
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 4) Faça um algoritmo que leia 20 números inteiros e em seguida informar quais números 
            foram pares e impares do vetor digitado. */
            
            // var
            int[] vetor = new int[20];

            // codigo
            for (int i = 0; i < vetor.Length; i++){
                System.Console.Write($"{i + 1}º Número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("\n--------- SAIDA ---------");
            foreach (int numero in vetor){
                if (numero % 2 == 0){
                    System.Console.Write($"{numero} é par!\n");
                }
                else {
                    System.Console.Write($"{numero} é impar!\n");
                }
            }
        }
    }
}
