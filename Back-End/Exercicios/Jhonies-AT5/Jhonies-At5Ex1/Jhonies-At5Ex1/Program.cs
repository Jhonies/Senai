using System;
using Jhonies_At5Ex1;

namespace JhoniesAt5Ex1
{
    class Program
    {
        static void Main()
        {
            Cliente cliente;
            
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Digite o seu endereço: ");
            string endereco = Console.ReadLine();
            
            Console.WriteLine("Digite o valor da compra: ");
            double valorCompra = Convert.ToDouble(Console.ReadLine());

            char escolha;
            do
            {
                Console.WriteLine("Você é pessoa jurídica (j) ou pessoa física (f)?: ");
                string input = Console.ReadLine()?.ToLower();

                if (!string.IsNullOrEmpty(input) && (input[0] == 'f' || input[0] == 'j'))
                {
                    escolha = input[0];
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida! Digite 'f' para pessoa física ou 'j' para pessoa jurídica.");
                }
            } while (true);

            if (escolha == 'f')
            {
                ClientePF clientePF = new ClientePF();
                clientePF.Nome = nome;
                clientePF.Endereco = endereco;
                clientePF.ValorCompra = valorCompra;

                Console.WriteLine("Digite seu CPF: ");
                clientePF.CPF = Console.ReadLine();

                Console.WriteLine("Digite o seu RG: ");
                clientePF.RG = Console.ReadLine();

                double imposto = clientePF.CalcularImposto();
                double valorTotal = clientePF.ValorCompra + imposto;

                Console.WriteLine($"\nDados do Cliente PF:\n" +
                                  $"Nome: {clientePF.Nome}\n" +
                                  $"Endereço: {clientePF.Endereco}\n" +
                                  $"Valor da compra: {clientePF.ValorCompra:C}\n" +
                                  $"CPF: {clientePF.CPF}\n" +
                                  $"RG: {clientePF.RG}\n" +
                                  $"Imposto: {imposto:C}\n" +
                                  $"Valor total a pagar: {valorTotal:C}");
            }
            else
            {
                ClientePJ clientePJ = new ClientePJ();
                clientePJ.Nome = nome;
                clientePJ.Endereco = endereco;
                clientePJ.ValorCompra = valorCompra;

                Console.WriteLine("Digite seu CNPJ: ");
                clientePJ.CNPJ = Console.ReadLine();

                Console.WriteLine("Digite sua Inscrição Estadual: ");
                clientePJ.InscricaoEstadual = Console.ReadLine();

                double imposto = clientePJ.CalcularImposto();
                double valorTotal = clientePJ.ValorCompra + imposto;

                Console.WriteLine($"\nDados do Cliente PJ:\n" +
                                  $"Nome: {clientePJ.Nome}\n" +
                                  $"Endereço: {clientePJ.Endereco}\n" +
                                  $"Valor da compra: {clientePJ.ValorCompra:C}\n" +
                                  $"CNPJ: {clientePJ.CNPJ}\n" +
                                  $"IE: {clientePJ.InscricaoEstadual}\n" +
                                  $"Imposto: {imposto:C}\n" +
                                  $"Valor total a pagar: {valorTotal:C}");
            }
        }
    }
}