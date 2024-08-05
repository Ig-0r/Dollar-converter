using ConversorDolarReal;
using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.CompilerServices;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Qual a cotação atual do dólar? ");
        double Cotação = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Quantos dólares deseja comprar? ");
        double Quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        
        
        Console.Write("Valor a ser pago em reais = " + ConversorDeMoeda.Converter(Cotação, Quantia).ToString("F2", CultureInfo.InvariantCulture));
    }


}