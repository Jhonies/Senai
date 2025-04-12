namespace cadastro_cliente_POO;
public class ClientePJ : Cliente
{
    public string CNPJ { get; set; }
    public string InscricaoEstadual { get; set; }

    public override double CalcularImposto() => ValorCompra * 0.2;

    public override void ExibirResumo()
    {
        base.ExibirResumo();
        Console.WriteLine($"CNPJ: {CNPJ}");
        Console.WriteLine($"IE: {InscricaoEstadual}");
        Console.WriteLine($"Imposto: {CalcularImposto():C}");
        Console.WriteLine($"Total a pagar: {ValorCompra + CalcularImposto():C}");
    }
}