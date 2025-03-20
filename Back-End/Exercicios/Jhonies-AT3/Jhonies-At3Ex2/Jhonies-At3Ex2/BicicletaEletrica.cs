namespace Jhonies_At3Ex2;

class BicicletaEletrica : Bicicleta
{
    public BicicletaEletrica() : base()
    {
        Nome = "Bicicleta Elétrica";
    }

    public override void Ligar()
    {
        if (!Ligado)
        {
            Ligado = true;
            Console.WriteLine("Bicicleta elétrica ligada.");
        }
        else
        {
            Console.WriteLine("Bicicleta elétrica já está ligada.");
        }
    }

    public override void Desligar()
    {
        if (Ligado)
        {
            Ligado = false;
            Console.WriteLine("Bicicleta elétrica desligada.");
        }
        else
        {
            Console.WriteLine("Bicicleta elétrica já está desligada.");
        }
    }
}