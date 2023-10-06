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

            double euro = 6.15;
            double dolar = 5.5;
            double valor;

            Console.WriteLine("Este programa serve para Converte Reais em outras notas.");
            Console.WriteLine("Escolha qual será a conversão" + '\n');


            Console.WriteLine("Qual valor ira ser Convertido:");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("OPÇÕES" + '\n');
            Console.WriteLine("1- Valor em dolar");
            Console.WriteLine("2- Valor em euro");
            int opcao = int.Parse(Console.ReadLine());

            double result;


        
            switch(opcao)
                {

                case 1:
                    {
                        result = ConvercaoDolar(dolar, valor);
                        break;
                    }
                case 2:
                    {
                        result = ConvercaoEuro(euro, valor);
                        break;
                    } 

            }

        }
    
    public static double ConvercaoDolar( double dolar,double valor)

        {
            double conDolar;

            conDolar = valor / dolar;
            Console.WriteLine("Conversão em dolar é de:" + conDolar);

            return 0;
        }
    
    public static double ConvercaoEuro(double euro, double valor)

        {
            double conEuro;

            conEuro = valor / euro;
            Console.WriteLine("Conversão em euro é de:" + conEuro);
            return 0;

        }
    
    }  
    
}
