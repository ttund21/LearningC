using System;
using System.Collections;
using System.Collections.Generic;

namespace Questao42
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 42) Faça o algoritmo que possa imprimir o menu abaixo:
            1 - VATAPÁ 
            2 - PIZZA 
            3 - MACARRONADA 
            4 - FEIJOADA 
            OPCAO: 
            O usuário deverá selecionar uma das opções do menu e este deverá informar o preço do
            prato. (este exercício terá um desempenho melhor quando você aprender as estruturas de
            repetição). */

            // var
            List<double> menu = new List<double>{10.50, 42.90, 27.90, 15.99};
            int opcao;

            // codigo 
            Console.Write("1 - VATAPÁ\n2 - PIZZA\n3 - MACARRONADA\n4 - FEIJOADA\nOPCAO: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao >= 1 && opcao <= 4){
                System.Console.WriteLine($"R$ {menu[opcao -1]}");
            }
            else {
                System.Console.WriteLine("Opcão Inexistente.");
            }
        }
    }
}
