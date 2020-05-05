using System;
using System.Collections.Generic;
using System.Linq;

namespace Questao03
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 3- Entrar com dois números reais e imprimir a média aritmética com a mensagem : 
            MÉDIA: antes do resultado. Use o comando IF para testar se a média foi maior ou menor que 7; */
            
            // var
            List<double> numeros = new List<double>();
            double media;

            // codigo            
            for (int i = 0; i < 2; i++){
                System.Console.Write($"{i + 1}º Número: ");
                numeros.Add(double.Parse(Console.ReadLine()));
            }

            media = numeros.Sum()/numeros.Count();   
            System.Console.WriteLine($"\n---- Saida ----\nMEDIA: {media}");
            if (media > 7){
                System.Console.WriteLine("Média maior que 7.");
            }
            else if (media < 7){
                System.Console.WriteLine("Média menor que 7.");
            }
            else {
                System.Console.WriteLine("Média igua a 7.");                
            }
        }
    }
}
