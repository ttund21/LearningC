using System;

namespace Questao04
{
    class Program
    {
        static void Main(string[] args)
        {
            /* QUESTÃO 04 - Faça um algoritmo em C#, utilizando o comando PARA, que imprima a soma
             dos números pares e a soma dos números ímpares existentes entre 500 e 800. */

            // var
            int impar = 0, par = 0;

            // codigo

            // SUM pares
            for (int i = 500; i <= 800; i += 2){
                par += i;
            }

            // SUM impares
            for (int i = 501; i <= 800; i += 2){
                impar += i;
            }

            System.Console.WriteLine($"Soma dos pares: {par}\nSoma dos impares: {impar}");
        }
    }
}
