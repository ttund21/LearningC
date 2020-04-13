using System;
using System.Collections;
using System.Collections.Generic;

namespace Questao28
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 28) Ler três números, possíveis lados de um triângulo e imprimir a classificação
            segundo os lados. */

            // var
            float num;
            List<float> lista = new List<float>();

            // codigo
            for (int i = 0; i < 3; ++i){
                System.Console.Write($"{i + 1}º Número: ");
                num = float.Parse(Console.ReadLine());
                lista.Add(num);
            }

            if (lista[0] == lista[1] && lista[1] == lista[2]){
                System.Console.WriteLine("Triângulo Equilatero!");
            }
            else if (lista[0] != lista[1] && lista[1] != lista[2] && lista[0] != lista[2]){
                System.Console.WriteLine("Triângulo Escaleno");
            }
            else{
                System.Console.WriteLine("Triângulo Isóceles");
            }
        }
    }
}
