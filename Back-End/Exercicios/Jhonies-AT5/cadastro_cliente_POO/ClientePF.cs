namespace cadastro_cliente_POO;
public class ClientePF : Cliente
{
    public string CPF { get; set; }
    public string RG { get; set; }

    public override double CalcularImposto() => ValorCompra * 0.1;

    public override void ExibirResumo()
    {
        base.ExibirResumo();
        Console.WriteLine($"CPF: {CPF}");
        Console.WriteLine($"RG: {RG}");
        Console.WriteLine($"Imposto: {CalcularImposto():C}");
        Console.WriteLine($"Total a pagar: {ValorCompra + CalcularImposto():C}");
    }
}
