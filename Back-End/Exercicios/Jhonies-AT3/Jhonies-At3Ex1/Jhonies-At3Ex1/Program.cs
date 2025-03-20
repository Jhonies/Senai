using System;

namespace Jhonies_At3Ex1;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite seu peso (kg): ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite sua altura (m): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        Pessoa pessoa = new Pessoa(nome, peso, altura);
        double imc = CalculoIMC.Calcular(peso, altura);
        string classificacao = ClassificacaoIMC.Classificar(imc);

        Console.WriteLine($"\n{pessoa.Nome}, seu IMC é {imc:F2} e você está classificado como: {classificacao}");
    }
}