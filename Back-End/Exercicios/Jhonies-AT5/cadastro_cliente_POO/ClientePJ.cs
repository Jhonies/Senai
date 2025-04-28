namespace cadastro_cliente_POO;

public class ClientePJ : Cliente
{
    public string CNPJ { get; set; }
    public string InscricaoEstadual { get; set; }

    public override double CalcularImposto() => ValorCompra * 0.2;

    public override string ExibirResumo()
    {
        double imposto = CalcularImposto();
        return $"--- Cliente Pessoa Jurídica ---\n" +
               $"Nome: {Nome}\n" +
               $"Endereço: {Endereco}\n" +
               $"CNPJ: {CNPJ}\n" +
               $"Inscrição Estadual: {InscricaoEstadual}\n" +
               $"Valor da compra: {ValorCompra:C}\n" +
               $"Imposto: {imposto:C}\n" +
               $"Total a pagar: {ValorCompra + imposto:C}\n";
    }
}