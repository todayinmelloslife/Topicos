using System;
namespace Projeto2
{
    class Temperatura
    {
        static void Main()
        {
            Console.Write("Digite a temperatura em graus Celsius: ");
            string input = Console.ReadLine();

            double celsius = double.Parse(input);

            
                double fahrenheit = (9.0 / 5.0) * celsius + 32;
                
                Console.WriteLine($"A temperatura em graus Fahrenheit é: {fahrenheit:F2}"); 
            
        }
    }
}