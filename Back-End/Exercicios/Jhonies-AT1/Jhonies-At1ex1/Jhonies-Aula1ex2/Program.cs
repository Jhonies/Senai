﻿using System;

class Program

{
    static void Main()
    {
        Console.WriteLine("Insira o primeiro de três números: ");
        double n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Insira o segundo de três números: ");
        double n2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Insira o terceiro de três números: ");
        double n3 = double.Parse(Console.ReadLine());

        double media = (n1 + n2 + n3) / 3;

        Console.WriteLine("{0} + {1} + {2} = {3}", n1, n2, n3, media);
    }
}