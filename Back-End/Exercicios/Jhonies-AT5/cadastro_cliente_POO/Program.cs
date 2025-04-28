using System;
using System.IO;

namespace cadastro_cliente_POO
{
    class Program
    {
        static void Main()
        {
            string pasta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Arquivos");
            Directory.CreateDirectory(pasta);
            string caminhoArquivo = Path.Combine(pasta, "clientes.txt");

            string continuar;
            do
            {
                Console.WriteLine("=== Cadastro de Cliente ===");

                string nome;
                do
                {
                    Console.Write("Digite o seu nome: ");
                    nome = Console.ReadLine()?.Trim();

                    if (string.IsNullOrWhiteSpace(nome))
                        Console.WriteLine("Nome não pode ser vazio!");
                } while (string.IsNullOrWhiteSpace(nome));

                string endereco;
                do
                {
                    Console.Write("Digite o seu endereço: ");
                    endereco = Console.ReadLine()?.Trim();

                    if (string.IsNullOrWhiteSpace(endereco))
                        Console.WriteLine("Endereço não pode ser vazio!");
                } while (string.IsNullOrWhiteSpace(endereco));

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
                string resumo = cliente.ExibirResumo(); // <-- chama o método corretamente
                Console.WriteLine(resumo);

                // Salva no arquivo
                File.AppendAllText(caminhoArquivo, resumo + Environment.NewLine);

                // Pergunta se quer cadastrar mais alguém
                Console.Write("\nDeseja cadastrar outra pessoa? (s/n): ");
                continuar = Console.ReadLine()?.ToLower();

            } while (continuar == "s");

            Console.WriteLine("\n Cadastro finalizado. Dados salvos em 'clientes.txt'.");
        }
    }
}
