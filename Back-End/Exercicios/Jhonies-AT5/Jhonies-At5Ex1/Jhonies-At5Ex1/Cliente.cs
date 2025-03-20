namespace Jhonies_At5Ex1;

public abstract class Cliente : ICliente
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public double ValorCompra { get; set; }

    public abstract double CalcularImposto(); // Método abstrato para ser implementado nas subclasses
}