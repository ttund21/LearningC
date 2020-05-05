using System;

namespace Questao02
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2- Faça um algoritmo que possa entrar com o saldo de sua caderneta de poupança 
            e imprima o novo saldo que teve reajuste de 3%. */
            
            // var
            double saldo;

            //codigo
            Console.Write("Saldo: ");
            saldo = double.Parse(Console.ReadLine());

            System.Console.WriteLine($"\n---- Saída ----\nNovo saldo: {saldo + saldo * 0.03}");
        }
    }
}
