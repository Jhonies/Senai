using System;
    
namespace Jhonies_At4Ex1;

class Program {
    static void Main() {
        Console.WriteLine("Escolha um meio de pagamento:");
        Console.WriteLine("1 - Cartão de Crédito");
        Console.WriteLine("2 - Cartão de Débito");
        Console.WriteLine("3 - Pix");
        Console.WriteLine("4 - Boleto");
        
        char escolha = Console.ReadKey().KeyChar;
        Console.WriteLine("\nDigite o valor do pagamento:");
        decimal valor;
        
        while (!decimal.TryParse(Console.ReadLine(), out valor) || valor <= 0) {
            Console.WriteLine("Valor inválido. Digite um valor válido:");
        }
        
        IMeios_de_pagamentos meioPagamento = escolha switch
        {
            '1' => new Credito(),
            '2' => new Debito(),
            '3' => new Pix(),
            '4' => new Boleto(),
            _ => null
        };
        
        if (meioPagamento != null) {
            meioPagamento.Pagar(valor);
        } else {
            Console.WriteLine("Meio de pagamento não reconhecido.");
        }
    }
}