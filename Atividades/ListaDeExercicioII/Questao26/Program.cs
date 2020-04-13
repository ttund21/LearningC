using System;
using System.Collections;
using System.Collections.Generic;

namespace Questao26
{
    class Program
    {
        static void Main(string[] args)
        {
            // 26) Efetuar a leitura de cinco números inteiros e identificar o maior e o menor valor.

            // var
            int num;
            List<int> lista = new List<int>();

            // codigo
            for (int i = 0; i < 5; ++i){
                System.Console.Write($"{i + 1}º Número: ");
                num = int.Parse(Console.ReadLine());
                lista.Add(num);
            }

            lista.Sort();

            System.Console.WriteLine($"\nMenor: {lista[0]}\nMaior: {lista[lista.Count - 1]}");
        }
    }
}
