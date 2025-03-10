using System;

namespace Projeto3
{
    class Aluno
    {
        public double[] Notas { get; set; }
        public double[] Pesos { get; set; }

        public Aluno()
        {
            Notas = new double[5];
            Pesos = new double[5];
        }

        public void LerNotasEPesos()
        {
            Console.WriteLine("Digite as notas:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Nota {0}: ", i + 1);
                Notas[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Digite os 5 pesos:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Peso {i + 1}: ");
                Pesos[i] = Convert.ToDouble(Console.ReadLine());
            }
        }

        public double CalcularMediaPonderada()
        {
            double somaNotas = 0;
            double somaPesos = 0;

            for (int i = 0; i < 5; i++)
            {
                somaNotas += Notas[i] * Pesos[i];
                somaPesos += Pesos[i];
            }

            return somaNotas / somaPesos;
        }

        public void ImprimirNotas()
        {
            Console.WriteLine("Notas do aluno:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Nota {i + 1}: {Notas[i]}");
            }
        }
    }

    class Escola
    {
        static void Main()
        {
            Aluno aluno = new Aluno();
            aluno.LerNotasEPesos();
            aluno.ImprimirNotas();
            double mediaPonderada = aluno.CalcularMediaPonderada();
            Console.WriteLine($"A média ponderada é: {mediaPonderada}");
        }
    }
}