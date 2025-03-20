using System;

namespace Jhonies_At3Ex2;

abstract class Veiculo
{
    public string Nome { get; protected set; }
    public bool Ligado { get; protected set; }

    public Veiculo(string nome)
    {
        Nome = nome;
        Ligado = false;
    }

    public virtual void Ligar()
    {
        if (!Ligado)
        {
            Ligado = true;
            Console.WriteLine($"{Nome} ligado.");
        }
        else
        {
            Console.WriteLine($"{Nome} já está ligado.");
        }
    }

    public virtual void Desligar()
    {
        if (Ligado)
        {
            Ligado = false;
            Console.WriteLine($"{Nome} desligado.");
        }
        else
        {
            Console.WriteLine($"{Nome} já está desligado.");
        }
    }

    public void Acelerar()
    {
        if (Ligado)
            Console.WriteLine($"{Nome} acelerando!");
        else
            Console.WriteLine($"Ligue o {Nome} antes de acelerar.");
    }

    public void Frear()
    {
        Console.WriteLine($"{Nome} freando!");
    }

    public void Virar(string direcao)
    {
        Console.WriteLine($"{Nome} virando para a {direcao}.");
    }
}