using System;

namespace Questao7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7-Ler dois números inteiros e imprimir a soma. Antes do resultado, deverá aparecera mensagem : SOMA.
            Console.Write("1º Número: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("2º Número: ");
            int secondNumber = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"SOMA\n{firstNumber + secondNumber}");
        }
    }
}
