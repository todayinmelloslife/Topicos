using System;
namespace Projeto1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite um número:");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                if (numero <= 10)
                {
                    Console.WriteLine("Número menor ou igual a 10!");
                }
                else
                {
                    Console.WriteLine("Número maior que 10!");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
            }
        }
    }
}
    