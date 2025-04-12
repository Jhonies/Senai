using System.Text.RegularExpressions;

namespace cadastro_cliente_POO;

public static class Validador
{
    public static bool FormatoFlxRG(string rg)
    {
        return Regex.IsMatch(rg, @"^\d{1,2}\.?\d{3}\.?\d{3}-?\d{1}$");
    }
}