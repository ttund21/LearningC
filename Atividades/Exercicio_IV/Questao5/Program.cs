using System;

namespace Questao5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um algoritmo que leia as três notas de um aluno e o peso de cada prova e imprima sua média ponderada;
            
            // Variaveis
            int peso1, peso2, peso3;
            float nota1, nota2, nota3;

            // Codigo
            Console.Write("Nota 1: ");
            nota1 = float.Parse(Console.ReadLine());
            System.Console.Write("Peso 1: ");
            peso1 = int.Parse(Console.ReadLine());
            
            Console.Write("Nota 2: ");
            nota2 = float.Parse(Console.ReadLine());
            System.Console.Write("Peso 2: ");
            peso2 = int.Parse(Console.ReadLine());
            
            Console.Write("Nota 3: ");
            nota3 = float.Parse(Console.ReadLine());
            System.Console.Write("Peso 3: ");
            peso3 = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"\nMédia Ponderada: {((nota1 * peso1) + (nota2 * peso2) + (nota3 * peso3)) / (peso1 + peso2 + peso3)}");
        }
    }
}
