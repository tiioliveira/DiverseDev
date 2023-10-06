// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace DiverseDev
{
    class Desafios
    {
    public static void Main(string[] args)
{

    int anoA;
    int nasC;

    Console.WriteLine("Informe o ano que voce nasceu: ");
    nasC = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe o seu ano atual: ");
    anoA = int.Parse(Console.ReadLine());

    int idade;

    idade = SuaIdade(anoA, nasC);

}

    public static int SuaIdade(int anoA, int nasC)
{

    int idadeCR = (anoA - nasC);
    Console.WriteLine("Sua idade é:" + idadeCR);
    return idadeCR;

}

 }

}