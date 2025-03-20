namespace Jhonies_At3Ex2;

class Program
{
    static Veiculo EscolherVeiculo()
    {
        Console.WriteLine("Escolha um veículo:");
        Console.WriteLine("1 - Carro");
        Console.WriteLine("2 - Moto");
        Console.WriteLine("3 - Bicicleta");
        Console.WriteLine("4 - Bicicleta Elétrica");
        string escolha = Console.ReadLine();

        return escolha switch
        {
            "1" => new Carro(),
            "2" => new Moto(),
            "3" => new Bicicleta(),
            "4" => new BicicletaEletrica(),
            _ => throw new ArgumentException("Opção inválida!")
        };
    }

    static void Menu(Veiculo veiculo)
    {
        while (true)
        {
            Console.WriteLine("\nEscolha uma ação:");
            Console.WriteLine("1 - Ligar");
            Console.WriteLine("2 - Acelerar");
            Console.WriteLine("3 - Frear");
            Console.WriteLine("4 - Virar");
            Console.WriteLine("5 - Desligar");
            Console.WriteLine("6 - Sair");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1": veiculo.Ligar(); break;
                case "2": veiculo.Acelerar(); break;
                case "3": veiculo.Frear(); break;
                case "4":
                    Console.Write("Para que lado deseja virar? (Esquerda/Direita): ");
                    string direcao = Console.ReadLine();
                    veiculo.Virar(direcao);
                    break;
                case "5": veiculo.Desligar(); break;
                case "6":
                    Console.WriteLine("Saindo...");
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

    static void Main()
    {
        try
        {
            Veiculo veiculo = EscolherVeiculo();
            Menu(veiculo);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

