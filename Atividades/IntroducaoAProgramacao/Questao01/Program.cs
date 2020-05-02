using System;

namespace Questao01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* QUESTÃO 01 - Faça um algoritmo em C#, utilizando o comando PARA, que imprima em ordem 
            decrescente os 20 primeiros números. */

            for (int i = 20; i >= 0; i--){
                System.Console.Write($"{i} ");
            }
        }
    }
}
