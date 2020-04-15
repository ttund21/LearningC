using System;
using System.Linq;
using System.Collections.Generic;

namespace Questao7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Elaborar um algoritmo que leia um conjunto de números e imprima o MAIOR, o MENOR, 
            a SOMA e o PRODUTO deles. */

            // var
            List<int> numeros = new List<int>();
            int i = 1, numero;
            
            // codigo
            System.Console.WriteLine("0 para finalizar.");
            while(true){
                System.Console.Write($"{i}º número: ");
                numero = int.Parse(Console.ReadLine());
                
                if (numero == 0){
                    break;
                }
                else{
                    numeros.Add(numero); // adicionando numero a lista
                }
                
                ++i;
            }

            numeros.Sort(); // ordenando a lista

            // Calculando o produto
            i = 1;
            foreach (int value in numeros){
                i *= value;
            }
        
            System.Console.WriteLine($"\nMAIOR: {numeros[numeros.Count() - 1]}\nMENOR: {numeros[0]}\nSOMA: {numeros.Sum()}\nPRODUTO: {i}");
        }
    }
}
