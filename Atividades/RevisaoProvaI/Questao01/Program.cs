using System;
using System.Collections.Generic;

namespace Questao01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1- Entrar com nome e idade. Imprimir a seguinte saída: NOME: IDADE:

            //var 
            Dictionary<string, dynamic> pessoa = new Dictionary<string, dynamic>();

            // codigo

            Console.Write("Nome: ");
            pessoa.Add("Nome", Console.ReadLine());
            Console.Write("Idade: ");
            pessoa.Add("Idade", int.Parse(Console.ReadLine()));

            System.Console.WriteLine($"\n---- Saída ----\nNOME: {pessoa["Nome"]}\nIdade: {pessoa["Idade"]}");

        }
    }
}
