using System;

namespace Questao04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Criar um "for" para ler a idade de uma de 10 pessoas:
                    - se é maior de idade
                    - se é menor de idade
                    - se é maior de 65 anos
                Criar um "While" para leia a idade das pessoas até que informar P para parar :
                    - se é maior de idade
                    - se é menor de idade
                    - se é maior de 65 anos */

            // var
            dynamic idade;
            int resp;

            //codigo
            System.Console.Write("1 - For\n2 - While\n>> ");
            resp = int.Parse(Console.ReadLine());

            switch(resp){
                case 1:
                    for (int i = 0;i < 10; i++){
                        System.Console.Write("Idade: ");
                        idade = int.Parse(Console.ReadLine());

                        if (idade >= 18){
                            System.Console.WriteLine("Maior de idade!");
                        }
                        else if (idade >= 65){
                            System.Console.WriteLine("Maior de 65 anos!");
                        }
                        else {
                            System.Console.WriteLine("Menor de idade!");
                        }
                    }
                    break;
            
                case 2:
                    while(true){
                        System.Console.Write("Idade: ");
                        idade = Console.ReadLine();
                    
                        if (idade == "P"){
                            break;
                        }

                        if (int.Parse(idade) >= 18){
                            System.Console.WriteLine("Maior de idade!");
                        }
                        else if (int.Parse(idade) >= 65){
                            System.Console.WriteLine("Maior de 65 anos!");
                        }
                        else {
                            System.Console.WriteLine("Menor de idade!");
                        }                    
                    }
                    break;

                default:
                    System.Console.WriteLine("Valor Inválido!");
                    break;
            }
        }
    }
}
