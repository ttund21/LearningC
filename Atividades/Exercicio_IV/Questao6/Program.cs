using System;

namespace Questao6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um algoritmo que calcule e mostre a área de um triângulo;

            // Varieaveis
            float bas, altura;

            // Codigo
            Console.Write("Base: ");
            bas = float.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            altura = float.Parse(Console.ReadLine());

            System.Console.WriteLine($"\nÁrea: {(bas * altura) / 2}");
        }
    }
}
