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

            int idade;
            string nome;

            Console.Write("Por favor, me informe seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Por favor, me informe sua idade: ");
            idade = int.Parse(Console.ReadLine());




            int cla = Classificacao(idade,nome);

        }

        public static int Classificacao(int idade, string nome)
        {
            if (idade <= 7)
            {

                Console.WriteLine(nome + ", você será classificado na categori Infatil I. ");

            }
            else if (idade <= 11)
            {

                Console.WriteLine(nome + ", você será classificado na categori Infantil II. ");

            }
            else if (idade <= 13)
            {

                Console.WriteLine(nome + ", você será classificado na categori Juvenil I. ");

            }
            else if (idade <= 17)
            {

                Console.WriteLine(nome + ", você será classificado na categori Juvenil II. ");

            }
            else
            {

                Console.WriteLine(nome + ", você será classificado na categori Adulto. ");

            }

            return 0;
        }






     }

}

