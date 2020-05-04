using System;
using System.Collections.Generic;

namespace Questao05
{
    class Program
    {
        static void Main(string[] args)
        {
            /* QUESTÃO ÚNICA - Desenvolva um programa em C# que efetue reserva de passagens de uma
            companhia aérea. Logo no início do seu programa, leia as informações do voo (número,
            origem, destino, quantidade de assentos disponíveis e o valor das passagens aéreas).

            Após o cadastro do voo, o programa deverá permitir o cadastro da reserva de assento,
            informando o código da reserva, e realizar a cobrança considerando os descontos pela ordem
            reserva de assentos, seguindo as informações de descontos descritas na tabela abaixo:

                - As 10 primeiras reservas de assentos: 25% de desconto
                - 11ª à 20ª reserva de assento: 15% de desconto
                - 21ª à 30ª reserva de assento: 5% de desconto
                - A partir da 30ª reserva de assento: valor integral

            Após a finalização do cadastro de todas as reservas, o funcionário da companhia aérea
            digita -1 no código da reserva e o programa deverá:
            
            a) Imprimir a quantidade de assentos que ainda estão disponíveis no voo;
            b) Imprimir a quantidade de reservas que foram realizadas com 25% de desconto;
            c) Imprimir a quantidade de reservas que foram realizadas com 15% e 5% de desconto;
            d) Imprimir a quantidade de reservas que foram realizadas com o valor integral;
            e) Imprimir o valor total arrecadado no voo. */
            
            // var
            int codReserva, assentosOcupados = 0;
            double totalArrecadado = 0;
            dynamic resposta;
            Dictionary<string, dynamic> infoVoo = new Dictionary<string, dynamic>();
            List<string> indexVoo = new List<string>(){"Numero", "Origem", "Destino", "Assentos", "Valor"};
            Dictionary<string, int> descontos = new Dictionary<string, int>(){{"25%", 0}, {"15%", 0}, {"5%",0}, {"0%", 0}};

            // codigo
            
            // <Coletando informações do voo>
            System.Console.WriteLine("---- Informações do Voo ----");
            foreach (string i in indexVoo){
                if (i == "Assentos"){
                    while (true){
                        System.Console.Write($"{i}: ");
                        resposta = int.Parse(Console.ReadLine());
                        
                        if (resposta < 30){
                            System.Console.WriteLine("Números de assentos está abaixo de 30!");
                            continue;
                        } 
                        else{
                            infoVoo.Add(i, resposta);
                            break;
                        }
                    }
                }
                else {
                    System.Console.Write($"{i}: ");
                    infoVoo.Add(i, Console.ReadLine());
                }
            }

            // <Cadastro de reserva>
            System.Console.WriteLine("\n---- Cadastro de Reservas ----");
            for (int i = 1; i <= infoVoo["Assentos"]; i++){
                System.Console.Write("Código de Reserva: ");
                codReserva = int.Parse(Console.ReadLine());

                if (codReserva == -1){
                    System.Console.WriteLine("Finalizado!");
                    break;
                }
                else {
                    assentosOcupados += 1;
                }

                if (i <= 10){
                    totalArrecadado += double.Parse(infoVoo["Valor"]) - double.Parse(infoVoo["Valor"]) * 0.25;
                    descontos["25%"]++;
                }
                else if (i <= 20){
                    totalArrecadado += double.Parse(infoVoo["Valor"]) - double.Parse(infoVoo["Valor"]) * 0.15;
                    descontos["15%"]++;
                }
                else if (i <= 30){
                    totalArrecadado += double.Parse(infoVoo["Valor"]) - double.Parse(infoVoo["Valor"]) * 0.05;
                    descontos["5%"]++;
                }
                else {
                    totalArrecadado += double.Parse(infoVoo["Valor"]);
                    descontos["0%"]++;
                }
            }

            // <Exibindo Valores>
            System.Console.WriteLine("\n---- Exbindo Valores ----");
            System.Console.Write($"Quantidade restantes de assentos: {infoVoo["Assentos"] - assentosOcupados}\n");
            System.Console.Write($"Quantidade de reservas com 25% de desconto: {descontos["25%"]}\n");
            System.Console.WriteLine($"Quantidade de reservas com 15% e 5% de desconto: {descontos["15%"] + descontos["5%"]}");
            System.Console.WriteLine($"Quantidade de reservas que foram realizadas com o valor integral: {descontos["0%"]}");
            System.Console.WriteLine($"Total Arrecadado: R$ {totalArrecadado}");
        }
    }
}