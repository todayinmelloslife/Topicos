using System;
namespace NamespaceProjeto2
{
    class Temperatura
    {
        static void Main()
        {
            double celsius = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (9 * celsius + 160) / 5;

            Console.WriteLine($"A temperatura em graus Fahrenheit é: {fahrenheit}");
        }
    }
}