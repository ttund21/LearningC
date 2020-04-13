using System;

namespace Questao10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10-Entrar com dois números reais e imprimir a média aritmética com a mensagem : MÉDIA: antes do resultado.
            Console.Write("1º Número: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("2º Número: ");
            int secondNumber = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"MEDIA\n{(firstNumber + secondNumber)/2}");
        }
    }
}
