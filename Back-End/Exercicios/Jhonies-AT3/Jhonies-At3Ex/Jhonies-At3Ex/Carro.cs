using System;

namespace Jhonies_At3Ex;

public class Carro
{
    private bool ligado = false;

    public void Ligar() //ligar carro
    {
        ligado = true;
        Console.WriteLine("Carro ligado");
    }

    public void Desligar() //desligar carro
    {
        ligado = false;
        Console.WriteLine("Carro desligado");
    }
}