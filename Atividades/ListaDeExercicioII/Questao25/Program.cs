using System;
using System.Collections;
using System.Collections.Generic;

namespace Questao25
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 25) Entrar com três números e armazená-los em três variáveis com os
            seguintes nomes: maior, intermediário e menor (suponha números diferentes). */

            // var
            int num, maior, menor, intermediario;
            List<int> lista = new List<int>();

            // codigo
            for (int i = 0; i < 3; ++i){
                System.Console.Write($"{i +1}º Número: ");
                num = int.Parse(Console.ReadLine());
                lista.Add(num);
            }
            
            lista.Sort();

            menor = lista[0];
            intermediario = lista[1];
            maior = lista[2];

            System.Console.WriteLine($"\nMaior: {maior}\nIntermediário: {intermediario}\nMenor: {menor}"); 
        }
    }
}
