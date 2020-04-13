using System;
using System.Collections;
using System.Collections.Generic;

namespace Questao27
{
    class Program
    {
        static void Main(string[] args)
        {
            // 27) Ler três números e imprimir se eles podem ou não ser lados de um triângulo.
            
            // var
            float num;
            List<float> lista = new List<float>();

            // codigo
            for (int i = 0; i < 3; ++i){
                System.Console.Write($"{i + 1}º Número: ");
                num = float.Parse(Console.ReadLine());
                lista.Add(num);
            }

            foreach (float value in lista){
                if (value == 0){
                    System.Console.WriteLine("Não pode ser um triângulo.");
                    Environment.Exit(0);
                }
            }
            
            System.Console.WriteLine("Pode ser um triângulo.");
        }
    }
}
