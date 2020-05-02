using System;

namespace Questao03
{
    class Program
    {
        static void Main(string[] args)
        {
            /* QUESTÃO 03 - Faça um algoritmo em C#, utilizando o comando PARA, que imprima todos
             os números pares existentes entre 1.000 e 1.200. */
            
            for (int i = 1000; i <= 1200; i += 2){
                System.Console.Write($"{i} ");
            }
        }
    }
}
