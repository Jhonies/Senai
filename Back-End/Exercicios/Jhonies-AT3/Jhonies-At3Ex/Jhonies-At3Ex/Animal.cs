using System;

namespace Jhonies_At3Ex;

public class Animal
{
    public string Nome { get; set; }

    public void Comer()
    {
        Console.WriteLine($"{Nome} está comendo");
    }
}

public class Cachorro : Animal

{
    public void Latir()
    {
        Console.WriteLine($"{Nome} diz: auau");
    }
}

public class Gato : Animal
{
    public void Miar()
    {
        Console.WriteLine($"{Nome} diz: miau");
    }
}