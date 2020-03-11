using System;

namespace Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Converter a temperatura de ºF(Fahrenheit) para ºC (célsius).Onde °C = (°F – 32) / 1,8;

            // Variaveis
            float fahr;

            // Codigo
            Console.Write("Fahrenheit: ");
            fahr = float.Parse(Console.ReadLine());

            System.Console.WriteLine($"Célsius: {(fahr - 32) / 1.8} °C");
        }
    }
}
