using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número:");
        int numero = int.Parse(Console.ReadLine());

        if (numero <= 10)
        {
            Console.WriteLine("Número menor ou igual a 10!");
        }
        else
        {
            Console.WriteLine("Número maior que 10!");
        }
    }
}