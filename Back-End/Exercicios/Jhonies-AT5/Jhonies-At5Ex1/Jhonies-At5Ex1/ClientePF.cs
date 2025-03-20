namespace Jhonies_At5Ex1;

public class ClientePF : Cliente
{
    public string CPF { get; set; }
    public string RG { get; set; }
    private const double IMPOSTO_PF = 0.10;

    public override double CalcularImposto()
    {
        return ValorCompra * IMPOSTO_PF;
    }
}