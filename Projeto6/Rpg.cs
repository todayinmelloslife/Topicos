using system;
namespace Projeto6
{
    class Rpg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao RPG!");
            Console.WriteLine("Escolha seu personagem: ");
            Console.WriteLine("1 - Guerreiro");
            Console.WriteLine("2 - Mago");
            Console.WriteLine("3 - Arqueiro");
            int personagem = int.Parse(Console.ReadLine());
            switch (personagem)
            {
                case 1:
                    Console.WriteLine("Você escolheu o Guerreiro!");
                    break;
                case 2:
                    Console.WriteLine("Você escolheu o Mago!");
                    break;
                case 3:
                    Console.WriteLine("Você escolheu o Arqueiro!");
                    break;
                default:
                    Console.WriteLine("Personagem inválido!");
                    break;
            }
        }
    }
} 
 