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
            int cod1, cod2, cod3;
            String prod1, prod2, prod3;
            double vlProd1, vlProd2, vlProd3;

            prod1 = "Telefone";
            prod2 = "Computador";
            prod3 = "TV";

            cod1 = 1;
            cod2 = 2;
            cod3 = 3;

            vlProd1 = 2500;
            vlProd2 = 3750;
            vlProd3 = 5300;


            Console.WriteLine("Escolha um Produto!!!\n" );
            Console.WriteLine(cod1 + "-" + prod1);
            Console.WriteLine(cod2 + "-" + prod2);
            Console.WriteLine(cod3 + "-" + prod3);
            Console.WriteLine("Digite um numero referente ao produto:");

            int codEscolhido = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade do produto:");
            int quant = int.Parse(Console.ReadLine());

            double valorTotal = 0;
            string produtoEscolhido = "";
            double vlProdutoEscolhido = 0;

            switch(codEscolhido)

            {
                case 1:
                    {
                        vlProdutoEscolhido = vlProd1;
                        produtoEscolhido = prod1;
                        valorTotal = vlProd1 * quant;
                        break;
                        
                    }
                case 2:
                    {
                        vlProdutoEscolhido = vlProd2;
                        produtoEscolhido = prod2;
                        valorTotal = vlProd2 * quant;
                        break;
                    }
                case 3:
                    {
                        vlProdutoEscolhido = vlProd3;
                        produtoEscolhido = prod3;
                        valorTotal = vlProd3 * quant;
                        break;
                    }
                default:

                    Console.WriteLine("Você não Digitou nemnhum dos numeros");
                    break;
            }

            Console.WriteLine("Venda:" +
                              "\n Produto: " + produtoEscolhido +
                              "\n Codigo do Produto:" + codEscolhido +
                              "\n Quantidade Comprada:" + quant +
                              "\n Valor unitario:" + vlProdutoEscolhido +
                              "\n Valor total:" + valorTotal);


        }
        }


    }
