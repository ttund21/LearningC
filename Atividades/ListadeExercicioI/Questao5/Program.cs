using System;

namespace Questao5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5-Ler um número inteiro e imprimir seu sucessor e seu antecessor.
            Console.Write("Escreva uma número inteiro: ");
            int num = int.Parse(Console.ReadLine());
            System.Console.Write($"\nNúmero: {num}\nSucessor: {num + 1}\nAntecessor: {num - 1}");
        }
    }
}
