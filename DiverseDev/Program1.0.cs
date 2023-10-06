// See https://aka
// .ms/new-console-template for more information

using System;
using System.Data.SqlTypes;
using System.Globalization;
using System.Threading.Channels;

namespace DiverseDev
{
    class Desafios
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Escolha sua Operação: \n");

            Console.WriteLine("1- Adição ");
            Console.WriteLine("2- Subtração ");
            Console.WriteLine("3- Divisão ");
            Console.WriteLine("4- Multiplicação ");


            double operacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeino numero: ");
            double num1 = double.Parse(Console.ReadLine());


            Console.WriteLine("Digite o segundo numero: ");
            double num2 = double.Parse(Console.ReadLine());

            double resultado;
           


            switch (operacao)
            {
                case 1:
                    {

                        resultado = adicao(num1, num2);
                        Console.WriteLine("A operação de " + num1 + " + " + num2 + " é: " + resultado);
                        break;

                    }
                case 2:
                    {

                        resultado = subtracao(num1, num2);
                        Console.WriteLine("A operação de " + num1 + " - " + num2 + " é: " + resultado);
                        break;

                    }
                case 3:
                    {

                        resultado = divisao(num1, num2);  
                        Console.WriteLine("A operação de " + num1 + " / " + num2 + " é: " + resultado);
                        break;

                    }
                case 4:
                    {

                        resultado = multiplicacao(num1, num2);
                        Console.WriteLine("A operação de " + num1 + " * " + num2 + " é: " + resultado);
                        break;

                    }
                default:
                    Console.WriteLine("numero invalido digite outro numero!!!");
                    break;
            }

           

        }

        public static double adicao(double num1, double num2)
        {
            double resultado = num1 + num2;

            return resultado;
        }

        public static double subtracao(double num1, double num2)
        {
            double resultado = num1 - num2;

            return resultado;
        }
        public static double divisao(double num1, double num2)
        {
            double resultado = num1 / num2;

            return resultado;
        }
        public static double multiplicacao(double num1, double num2)
        {
            double resultado = num1 * num2;

            return resultado;
        }


        

    }
}
