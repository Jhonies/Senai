using System;

namespace Jhonies_At3Ex1;

public class Pessoa
{
    public string Nome { get; set; }
    public double Peso { get; set; }
    public double Altura { get; set; }

    public Pessoa(string nome, double peso, double altura)
    {
        Nome = nome;
        Peso = peso;
        Altura = altura;
    }
}