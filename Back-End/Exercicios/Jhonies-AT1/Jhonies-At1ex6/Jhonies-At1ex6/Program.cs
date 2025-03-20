using System;

class Program

{
    static void Main()
    {
        Console.Write("Digite a temperatura em graus Celsius para conversão: ");
        double temp;
            if (!double.TryParse(Console.ReadLine(), out temp))
                
            {
                Console.WriteLine("Valor inválido! Por favor, insira um número válido.");
                return;
            }

        Console.Write("Escolha se deseja ver a temperatura em Fahrenheit ou Kelvin: ");
        string temperatura = Console.ReadLine();
        
        double conv = 0.0;
        double total = 0.0;
        char termografica = ' ';

        if (temperatura == "Fahrenheit" || temperatura == "Kelvin")
        {

            switch (temperatura)
            {
                case "Fahrenheit":
                    conv = (temp * 1.8) + 32;
                    termografica = 'F';
                    break;
                case "Kelvin":
                    conv = temp + 273.15;
                    termografica = 'K';
                    break;
                default:
                    Console.Write("Número inválido, digite um valor em graus");
                    return;
            }

            total = conv;
            Console.WriteLine($"O valor convertido é: {termografica} {total}");
        }
        else
        {
            Console.WriteLine("Digite uma escala termográfica!");
            return;
        }
    }
}