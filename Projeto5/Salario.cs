using System;

namespace Projeto5
{
    class Vendedor
    {
        public string Nome { get; set; }
        public double SalarioFixo { get; set; }
        public double TotalVendas { get; set; }

        public Vendedor(string nome, double salarioFixo, double totalVendas)
        {
            Nome = nome;
            SalarioFixo = salarioFixo;
            TotalVendas = totalVendas;
        }

        public double CalcularSalarioFinal()
        {
            return SalarioFixo + (TotalVendas * 0.15);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do vendedor: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o salário fixo do vendedor: ");
            double salarioFixo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o total de vendas realizadas no mês: ");
            double totalVendas = Convert.ToDouble(Console.ReadLine());

            Vendedor vendedor = new Vendedor(nome, salarioFixo, totalVendas);
            double salarioFinal = vendedor.CalcularSalarioFinal();

            Console.WriteLine($"Nome do Vendedor: {vendedor.Nome}");
            Console.WriteLine($"Salário Fixo: {vendedor.SalarioFixo:C}");
            Console.WriteLine($"Salário Final: {salarioFinal:C}");
        }
    }
}