using System;

class Program
{
    static void Main()
    {
        int soma = 0;
        int numero;

        Console.WriteLine("Digite números positivos para somar. Digite um número negativo para encerrar.");

        while (true)
        {
            Console.Write("Digite um número: ");
            if (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Entrada inválida. Digite um número inteiro.");
                continue;
            }

            if (numero < 0)
            {
                Console.WriteLine("Número negativo digitado. Encerrando...");
                break;
            }

            soma += numero;
        }

        Console.WriteLine($"A soma dos números positivos digitados é: {soma}");
    }
}