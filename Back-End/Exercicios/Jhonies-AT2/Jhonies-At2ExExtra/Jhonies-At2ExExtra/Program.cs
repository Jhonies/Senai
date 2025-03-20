using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Qual sua idade?");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 21)
        {
            Console.WriteLine("Você tem CNH do tipo B? S/n");
            char verificar = char.Parse(Console.ReadLine());

            if (verificar == 'S')
            {
                Console.WriteLine("Insira a data de emissão da sua CNH DD/MM/YYYY");
                DateTime datacnh = DateTime.Parse(Console.ReadLine());

                DateTime dataAprovada = DateTime.Now.AddYears(-2);

                if (datacnh < dataAprovada)
                {
                    Console.WriteLine(
                        "Iremos verificar se você cometeu alguma infração grave ou gravissima nos ultimos 12 meses");
                }
            }
        }

        else
        {
            Console.WriteLine("Você não está elegivel para tirar sua CNH D");
        }
        
    }
}