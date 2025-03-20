using System;

namespace Jhonies_At3Ex;

public class AnimalPoli
{
    public virtual void FazerSom() //Para criar a classe
    {
        Console.WriteLine("O animal faz um som...");
    }
}

public class CachorroPoli : AnimalPoli
{
    public override void FazerSom() //Para requerer a classe
    {
        Console.WriteLine("O cachorro late : auau");
    }
}

public class GatoPoli : AnimalPoli
{
    public override void FazerSom() //Para requerer a classe
    {
        Console.WriteLine("O gato mia: miau miau");
    }
}