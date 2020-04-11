using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2)Construir um programa que leia dois valores numéricos e efetue a adição, 
            caso o resultado seja maior que 10 apresentá-lo. */
            
            // var 
            float num1, num2, resultado;
            
            Console.Write("Escreva o 1º numero: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Escreva o 2º numero: ");
            num2 = float.Parse(Console.ReadLine());
            resultado = num1 + num2;

            if (resultado > 10){
                System.Console.WriteLine(resultado);
            }
        }
    }
}
