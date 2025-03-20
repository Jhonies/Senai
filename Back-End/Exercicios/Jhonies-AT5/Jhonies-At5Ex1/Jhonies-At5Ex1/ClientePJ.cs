namespace Jhonies_At5Ex1;

public class ClientePJ : Cliente
{
    public string CNPJ { get; set; }
    public string InscricaoEstadual { get; set; }
    private const double IMPOSTO_PJ = 0.20;

    public override double CalcularImposto()
    {
        return ValorCompra * IMPOSTO_PJ;
    }
}