namespace cadastro_cliente_POO;

public class ClientePF : Cliente
{
    public string CPF { get; set; }
    public string RG { get; set; }

    public override double CalcularImposto() => ValorCompra * 0.1;

    public override string ExibirResumo()
    {
        double imposto = CalcularImposto();
        return $"--- Cliente Pessoa Física ---\n" +
               $"Nome: {Nome}\n" +
               $"Endereço: {Endereco}\n" +
               $"CPF: {CPF}\n" +
               $"RG: {RG}\n" +
               $"Valor da compra: {ValorCompra:C}\n" +
               $"Imposto: {imposto:C}\n" +
               $"Total a pagar: {ValorCompra + imposto:C}\n";
    }
}