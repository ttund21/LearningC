using System;

namespace Questao11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*11- Entrar com dois números inteiros e imprimir a seguinte saída:
                Dividendo:
                Divisor:
                Quociente:
                Resto: */
            Console.Write("Dividendo: ");
            float Dividendo =  float.Parse(Console.ReadLine());
            Console.Write("Divisor: ");
            float Divisor =  float.Parse(Console.ReadLine());
            System.Console.WriteLine($"\nDividendo: {Dividendo}\nDivisor: {Divisor}\nQuociente: {Dividendo/Divisor}\nResto: {Dividendo%Divisor}");
        }
    }
}
