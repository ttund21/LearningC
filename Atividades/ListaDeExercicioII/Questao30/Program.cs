using System;
using System.Collections;
using System.Collections.Generic;

namespace Questao30
{
    class Program
    {
        static void Main(string[] args)
        {
            // 30) Entrar com dois nomes e imprimi-los em ordem alfabética.

            // var
            List<string> lista = new List<string>();
            string nome;

            // codigo
            for (int i = 0; i < 2; ++i){
                System.Console.Write($"Escreva {i +1}º nome: ");
                nome = Console.ReadLine();
                lista.Add(nome);
            }

            lista.Sort();

            foreach (string value in lista){
                System.Console.WriteLine(value);
            }
        }
    }
}