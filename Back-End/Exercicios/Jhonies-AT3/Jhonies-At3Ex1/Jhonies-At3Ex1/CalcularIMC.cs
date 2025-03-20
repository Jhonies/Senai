using System;

namespace Jhonies_At3Ex1;

public class CalculoIMC
{
    public static double Calcular(double peso, double altura)
    {
        return peso / (altura * altura);
    }
}
