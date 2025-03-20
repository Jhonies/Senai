namespace Jhonies_At5Ex1;

public interface ICliente
{
    string Nome { get; set; }
    string Endereco { get; set; }
    double CalcularImposto();
}