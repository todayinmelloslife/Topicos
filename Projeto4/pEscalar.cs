using System;

namespace Projeto4
{
    class Vetor
    {
        public int[] Valores { get; set; }

        public Vetor(int[] valores)
        {
            if (valores.Length != 5)
            {
                throw new ArgumentException("O vetor deve ter exatamente 5 elementos.");
            }
            Valores = valores;
        }
    }

    class ProdutoEscalar
    {
        public static int Calcular(Vetor v1, Vetor v2)
        {
            int produtoEscalar = 0;
            for (int i = 0; i < 5; i++)
            {
                produtoEscalar += v1.Valores[i] * v2.Valores[i];
            }
            return produtoEscalar;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] valores1 = { 0, 2, 4, 6, 8 };
            int[] valores2 = { 1, 3, 5, 7, 9 };

            Vetor vetor1 = new Vetor(valores1);
            Vetor vetor2 = new Vetor(valores2);

            int resultado = ProdutoEscalar.Calcular(vetor1, vetor2);

            Console.WriteLine("O produto escalar é: " + resultado);
        }
    }
}