using System;
using System.Globalization;

class Program
{
    static void Main()
    
    {
        Console.WriteLine("Digite o nome de uma moeda para converter (Dólar, Euro, Peso Argentino e Iene Japonês)");
        string moedaconv = Console.ReadLine();

        if (moedaconv == "Dólar" || moedaconv == "Euro" || moedaconv == "Peso Argentino" || moedaconv == "Iene Japonês")
        {
            Console.WriteLine("Insira uma quantia de valor na moeda Real (R$)");
            decimal moeda = decimal.Parse(Console.ReadLine());
            
            decimal taxaDeCambio = 0m;
            decimal total = 0m;
            string simboloMoeda = "";
            
            switch (moedaconv)
            {
                case "Dólar":
                    taxaDeCambio = 1m / 5.76m;
                    simboloMoeda = "USD";
                    break;
                case "Euro":
                    taxaDeCambio = 1m / 5.9916571m;
                    simboloMoeda = "EUR";
                    break;
                case "Peso Argentino":
                    taxaDeCambio = 1m / 0.0055126381m;
                    simboloMoeda = "ARG";
                    
                    break;
                case "Iene Japonês":
                    taxaDeCambio = 1m / 0.037398166m;
                    simboloMoeda = "JPY";
                    break;
                
                default:
                    Console.Write("Número inválido, digite um valor em dinheiro");
                    return;
            }
            
            total = moeda * taxaDeCambio;
            
            Console.WriteLine($"O valor convertido é: {simboloMoeda} {total.ToString("N2", CultureInfo.InvariantCulture)}");
        }
        else
        {
            Console.WriteLine("Digite uma moeda para converter");
            return;
        }

    }
}