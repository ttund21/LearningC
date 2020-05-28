using System;
using System.Linq;

namespace Questao02
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2- Dados dois vetores com n componentes cada um, calcular e imprimir
            a soma, subtração, multiplicação e divisão deles; */

            // var
            System.Console.Write("N vetor 1: ");
            int nVetor1 = int.Parse(Console.ReadLine());
            System.Console.Write("N vetor 2: ");
            int nVetor2 = int.Parse(Console.ReadLine());
            int[] vetor1 = new int[nVetor1];
            int[] vetor2 = new int[nVetor2];
            int resultadoVetor1 = 0, resultadoVetor2 = 0;

            // codigo

            // Colentando números
            System.Console.WriteLine("\nPrimeiro Vetor");
            for (int i = 0; i < vetor1.Length; i++){
                System.Console.Write($"{i + 1}º Número: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("\nSegundo Vetor");
            for (int i = 0; i < vetor2.Length; i++){
                System.Console.Write($"{i + 1}º Número: ");
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("\n----------- SAIDA -----------");
            // SOMA
            System.Console.WriteLine($"SOMA: {vetor1.Sum() + vetor2.Sum()}");

            // SUBTRAÇÃO
            for (int i = 0; i < vetor1.Length; i++){
                resultadoVetor1 += -vetor1[i];
            }
            for (int i = 0; i < vetor2.Length; i++){
                resultadoVetor2 += -vetor2[i];
            }
            System.Console.WriteLine($"SUBTRAÇÃO: {resultadoVetor1 - resultadoVetor2}");

            // MULTIPLICAÇÃO
            resultadoVetor1 = 1;
            for (int i = 0; i < vetor1.Length; i++){
                resultadoVetor1 *= vetor1[i];
            }
            resultadoVetor2 = 1;
            for (int i = 0; i < vetor2.Length; i++){
                resultadoVetor2 *= vetor2[i];
            }
            System.Console.WriteLine($"MULTIPLICAÇÃO: {resultadoVetor1 * resultadoVetor2}");

            // DIVISÃO
            resultadoVetor1 = vetor1[0];
            for (int i = 1; i < vetor1.Length; i++){
                resultadoVetor1 /= vetor1[i];
            }
            resultadoVetor2 = vetor2[0];
            for (int i = 1; i < vetor2.Length; i++){
                resultadoVetor2 /= vetor2[i];
            }
            System.Console.WriteLine($"DIVISÃO: {resultadoVetor1 / resultadoVetor2}");                         
        }
    }
}
