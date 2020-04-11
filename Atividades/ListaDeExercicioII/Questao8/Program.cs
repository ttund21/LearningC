using System;

namespace Questao8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 8)Entrar com um número e imprimir a raiz quadrada do número caso ele seja
            positivo e o quadrado do número caso ele seja negativo. */
            
            // var
            int num;

            // codigo
            Console.Write("Escreva o numero: ");
            num = int.Parse(Console.ReadLine());

            if (num > 0){
                System.Console.WriteLine($"Raiz Quadrada: {Math.Sqrt(num)}");
            }
            else{
                System.Console.WriteLine($"Quadrado do numero: {Math.Pow(num, 2)}");
            }
        }
    }
}
