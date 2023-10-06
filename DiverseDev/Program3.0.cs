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

            double conta, taxa;

            Console.Write("Valor da conta: ");
            conta = double.Parse(Console.ReadLine());

            Console.Write("A Gorgeta será de quanto:");
            taxa = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double result;
            result = ValorTaxa(taxa, conta);

        }

        public static double ValorTaxa(double taxa, double conta)
        {
            double vtaxa = taxa / 100;
            double relcont = conta * vtaxa;

            Console.WriteLine("valor da conta:" + conta);
            Console.WriteLine("valor da taxa:" + taxa + '\n');

            Console.WriteLine("Gorgeta do garção:" + relcont);


            return 0;
        }
        
        

    }

    
    
    
    
}
