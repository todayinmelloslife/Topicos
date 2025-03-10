using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a temperatura em graus Celsius: ");
        string input = Console.ReadLine();
        
        if (double.TryParse(input, out double celsius))
        {
            double fahrenheit = (9.0 / 5.0) * celsius + 32;
            
            Console.WriteLine($"A temperatura em graus Fahrenheit é: {fahrenheit:F2}");
        }
        else
        {
            Console.WriteLine("Por favor, insira um valor numérico válido.");
        }
    }
}
