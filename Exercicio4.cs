using System;

namespace atividades
{
    class exercicio04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite sua nacionalidade: ");
            string nacionalidade = Console.ReadLine();

            if (idade >= 16 && nacionalidade == "brasileiro")
            {
                Console.WriteLine("Você é elegível para votar!");
            }
            else
            {
                Console.WriteLine("Você não é elegível para votar!");
            }
        }
    }
}