namespace cadastro_cliente_POO;

public abstract class Cliente
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public double ValorCompra { get; set; }

    public abstract double CalcularImposto();
    public abstract string ExibirResumo();
}