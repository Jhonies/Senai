namespace Jhonies_At4Ex1;

class Pix : IMeios_de_pagamentos {
    public void Pagar(decimal valor) {
        Console.WriteLine("Digite a chave Pix:");
        string chavePix = Console.ReadLine();
        Console.WriteLine($"Pagamento de R${valor:F2} realizado via Pix para {chavePix}.");
    }
}