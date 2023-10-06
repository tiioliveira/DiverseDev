// See https://aka.ms/new-console-template for more information
using System;
using System.Data.SqlTypes;
using System.Globalization;
using System.Threading.Channels;

namespace DiverseDev
{
    class Desafios
    {

        static void Main(string[] args)
        {
            int f1, f2, f3, f4;
            string n1, n2, n3, n4;
            string nome;

            n1 = "Fisica";
            n2 = "Programação";
            n3 = "Matematica";
            n4 = "Filosofia";

            f1 = 1;
            f2 = 2;
            f3 = 3;
            f4 = 4;


            Console.WriteLine("Por favor digite seu nome");
            nome = Console.ReadLine();


            Console.WriteLine("Escolha o curso que você quer ingressar\n");

            Console.WriteLine(f1 + "- " + n1);
            Console.WriteLine(f2 + "- " + n2);
            Console.WriteLine(f3 + "- " + n3);
            Console.WriteLine(f4 + "- " + n4);

            int escolha = int.Parse(Console.ReadLine());


            switch (escolha)
            {
                case 1:
                    {
                        Console.WriteLine("Parabens "+nome+" você está matriculado em Fisica, Bons estudos porque você ira precisar!!!");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Parabens "+nome+" você está matriculado em Programação, Que Deus guie seu caminho meu pobre usuario!");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Parabens "+nome+" você está matriculado em Matetica, Vai saber né, exite maluco pra tudo!!!");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Parabens "+nome+" você está matriculado em Filosofia, KKKKKKKKKKKKKKKKKKKK AI AI!!! ");
                        break;
                    }
                default:

                    Console.WriteLine("NUMERO INCORRETO");
                    break;

            }

        }
    }
    
}