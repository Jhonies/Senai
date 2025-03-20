class Program

{
    static void Main()
    {
        Console.Write("Digite a temperatura em graus Celsius para converter para Fahrenheit: ");
        double temp = double.Parse(Console.ReadLine());
        
        double temperatura = temp * 1.8 + 32;
        
        Console.WriteLine("{0} Fahrenheits", temperatura);
    }
}