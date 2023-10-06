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
            double nota1, nota2, nota3;

            Console.WriteLine();
            Console.Write("Nota 1:");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Nota 2:");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Nota 3:");
            nota3 = double.Parse(Console.ReadLine());


        }

        public static int MediaPrimaria(double nota1,double nota2,double nota3)
        {

            double media = nota1 + nota2 + nota3 / 3;         

            if (media >= 7)
            {
                Console.WriteLine("O aluno foi aprovado com media:" + media);
            }
            else
            {
                Console.WriteLine("O aluno não foi aprovado com média " + media);
                Console.WriteLine("Informe a nota do exame final:");
                double notaEx = int.Parse(Console.ReadLine());
                              
                double mediaF = media + notaEx / 2;

                if (mediaF >= 5)
                {
                    Console.WriteLine("O aluno foi aprovado no exame final com média final" + mediaF );
                }
                else
                {
                    Console.WriteLine("O aluno foi reprovado no exame final com média final " + mediaF);
                }


            }
            return 0;
        }
        
    }
        
}
