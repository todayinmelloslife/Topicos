using System;

namespace Projeto6
{
    public class CalculadoraVolume
    {
        public static double CalcularVolumeCubo(double lado)
        {
            if (lado <= 0)
            {
                throw new ArgumentException("O lado do cubo deve ser maior que zero.");
            }
            return Math.Pow(lado, 3);
        }

        public static double CalcularVolumeEsfera(double raio)
        {
            if (raio <= 0)
            {
                throw new ArgumentException("O raio da esfera deve ser maior que zero.");
            }
            return (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);
        }

        public static double CalcularVolumeCilindro(double raio, double altura)
        {
            if (raio <= 0 || altura <= 0)
            {
                throw new ArgumentException("O raio e a altura do cilindro devem ser maiores que zero.");
            }
            return Math.PI * Math.Pow(raio, 2) * altura;
        }
    }

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