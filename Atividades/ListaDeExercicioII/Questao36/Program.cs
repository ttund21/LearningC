using System;
using System.Collections;
using System.Collections.Generic;

namespace Questao35
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 36)Ler dois números e armazená-los nas variáveis A e B. Fazer a troca dos conteúdos
            das variáveis de tal maneira que a variável A fique com o valor da variável B e viceversa.*/
            
            // var
            List<int> lista = new List<int>();
            int a, b;

            // codigo
            for (int i = 0; i < 2; ++i){
                System.Console.Write($"{i + 1}º Número: ");
                lista.Add(int.Parse(Console.ReadLine()));
            }

            a = lista[0];
            b = lista[1];
            System.Console.WriteLine($"\nA = {a}\nB = {b}");
            Console.ReadKey();

            a = lista[1];
            b = lista[0];
            System.Console.WriteLine($"\nA = {a}\nB = {b}");

        }
    }
}
