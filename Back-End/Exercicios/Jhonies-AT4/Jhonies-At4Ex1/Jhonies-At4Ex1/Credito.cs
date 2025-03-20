namespace Jhonies_At4Ex1;

class Credito : IMeios_de_pagamentos {
    public void Pagar(decimal valor) {
        Console.WriteLine("Digite o número do cartão:");
        string numeroCartao = Console.ReadLine();
        
        Console.WriteLine("Digite o nome do titular:");
        string titular = Console.ReadLine();
        
        Console.WriteLine("Digite a data de validade (MM/AA):");
        string validade = Console.ReadLine();
        
        Console.WriteLine("Digite o CVV:");
        string cvv = Console.ReadLine();
        
        Console.WriteLine($"Pagamento de R${valor:F2} realizado com Cartão de Crédito.");
    }
}
