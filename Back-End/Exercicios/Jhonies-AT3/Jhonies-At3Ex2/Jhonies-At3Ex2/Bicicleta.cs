namespace Jhonies_At3Ex2;

class Bicicleta : Veiculo
{
    public Bicicleta() : base("Bicicleta") { }

    public override void Ligar()
    {
        Console.WriteLine("Bicicletas não precisam ser ligadas!");
    }

    public override void Desligar()
    {
        Console.WriteLine("Bicicletas não precisam ser desligadas!");
    }
}