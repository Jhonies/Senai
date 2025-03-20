namespace Jhonies_At4Ex1;

class Boleto : IMeios_de_pagamentos {
    public void Pagar(decimal valor) {
        Console.WriteLine("Gerando boleto...");
        Console.WriteLine($"Boleto gerado para pagamento no valor de R${valor:F2}. Código: 12345678901234567890");
    }
}
