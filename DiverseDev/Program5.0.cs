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

           double kgpei;
           double multa = 4.00;
           string nome;

            Console.WriteLine("Por favor, Me diga o nome do senhor:");
            nome = Console.ReadLine();
            Console.WriteLine("Senhor " + nome +  " informe quantos Kg o senho pegou de paixe:");
            kgpei = int.Parse(Console.ReadLine());

            double pagamento;
            pagamento = PagaNaoPaga(kgpei, multa,nome);



        }

    public static double PagaNaoPaga(double kgpei, double multa,string nome)
        {
            if(kgpei >= 50)
                {

                double paga = kgpei + multa;
                Console.WriteLine("Senhor "+ nome +" A quantidade chegou ao limete, você terá que pagar uma taxa de 4,00 $," + '\n' +
                    "então o valor será de:" + paga);

            }
            else
            {
                Console.WriteLine("Senhor "+ nome +", você não ira precisar pagar a taxa de 4,00 $, " + '\n' +
                    "então o valor será:" + kgpei);
            }

            return 0;
        }
    }
}

