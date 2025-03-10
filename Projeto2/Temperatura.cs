using System;
namespace Projeto2
{
    class Temperatura
    {
        static void Main()
        {
            Console.Write("Digite a temperatura em graus Celsius: ");
            string input = Console.ReadLine();
            
            if (double.TryParse(input, out double celsius)) //TRYPERSE é aquela funcao que converte o valor da string em um valor double, né?
            {
                double fahrenheit = (9.0 / 5.0) * celsius + 32;
                
                Console.WriteLine($"A temperatura em graus Fahrenheit é: {fahrenheit:F2}"); // O F2 é para limitar o número de casas decimais 
            }
            else
            {
                Console.WriteLine("Por favor, insira um valor numérico válido.");
            }
        }
    }
}
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

