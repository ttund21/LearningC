using System;
using System.Collections.Generic;
using System.Linq;

namespace Questao01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1- Faça um algoritmo para ler o nomes de alunos de uma turma e escrevê-los na ordem 
            inversa que foram lidos. O valor N será no máximo 5 */

            // var
            int n = 5;
            string[] nomes = new string[n];

            // codigo
            for (int i = 0; i < n; i++){
                System.Console.Write($"{i + 1}ª Nota: ");
                nomes[i] = Console.ReadLine();
            }

            for (int i = nomes.Length; i > 0; i--){
                System.Console.WriteLine(nomes[i - 1]);
            }
        }
    }
}
