﻿using System;

class Program

{
    static void Main()
    {
        Console.WriteLine("Insira o nome do aluno e as três notas dele : ");
        string nome = Console.ReadLine();

        double n1 = int.Parse(Console.ReadLine());

        double n2 = double.Parse(Console.ReadLine());

        double n3 = double.Parse(Console.ReadLine());

        double media = Math.Round(n1 + n2 + n3) / 3;

        Console.WriteLine("{0} : + {1} + {2} + {3} = {4}", nome, n1, n2, n3, media);

        if (media >= 5)
        {
            Console.Write("Aprovado");
        }
        else
        {
             Console.Write("Reprovado");
        }
    }
}