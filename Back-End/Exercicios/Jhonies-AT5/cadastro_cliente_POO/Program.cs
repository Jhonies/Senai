using System;
using System.ComponentModel.DataAnnotations;

namespace cadastro_cliente_POO
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Cadastro de Cliente ===");

            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine()?.Trim();

            Console.Write("Digite o seu endereço: ");
            string endereco = Console.ReadLine()?.Trim();

            double valorCompra;
            while (true)
            {
                Console.Write("Digite o valor da compra: ");
                string inputValor = Console.ReadLine();
                if (double.TryParse(inputValor, out valorCompra) && valorCompra >= 0)
                    break;
                Console.WriteLine("Valor inválido! Digite um número válido e positivo.");
            }

            char escolha;
            while (true)
            {
                Console.Write("Você é pessoa jurídica (j) ou pessoa física (f)?: ");
                string input = Console.ReadLine()?.ToLower();

                if (!string.IsNullOrEmpty(input) && (input[0] == 'f' || input[0] == 'j'))
                {
                    escolha = input[0];
                    break;
                }

                Console.WriteLine("Entrada inválida! Digite 'f' para pessoa física ou 'j' para pessoa jurídica.");
            }

            Cliente cliente;

            if (escolha == 'f')
            {
                ClientePF clientePF = new ClientePF
                {
                    Nome = nome,
                    Endereco = endereco,
                    ValorCompra = valorCompra
                };

                do
                {
                    Console.Write("Digite seu CPF: ");
                    clientePF.CPF = Console.ReadLine()?.Trim();

                    if (!ValidadorCPF.ValidarCPF(clientePF.CPF))
                        Console.WriteLine("CPF inválido! Digite novamente.");
                } while (!ValidadorCPF.ValidarCPF(clientePF.CPF));



                do
                {
                    Console.Write("Digite o seu RG: ");
                clientePF.RG = Console.ReadLine()?.Trim();

                    if (!Validador.FormatoFlxRG(clientePF.RG))
                        Console.WriteLine("RG inválido! Insira o seu RG corretamente");
                } while (!Validador.FormatoFlxRG(clientePF.RG));

      

                cliente = clientePF;
            }
            else
            {
                ClientePJ clientePJ = new ClientePJ
                {
                    Nome = nome,
                    Endereco = endereco,
                    ValorCompra = valorCompra
                };

                Console.Write("Digite seu CNPJ: ");
                clientePJ.CNPJ = Console.ReadLine()?.Trim();

                Console.Write("Digite sua Inscrição Estadual: ");
                clientePJ.InscricaoEstadual = Console.ReadLine()?.Trim();

                cliente = clientePJ;
            }

            Console.WriteLine("\n=== Resumo do Cliente ===");
            cliente.ExibirResumo();

            Console.WriteLine("\nObrigado por utilizar nosso sistema!");
        }
    }
}