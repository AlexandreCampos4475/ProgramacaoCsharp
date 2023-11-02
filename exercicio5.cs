using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite seu nome completo:");
        string nomeCompleto = Console.ReadLine();

        Console.WriteLine("Digite sua idade:");
        string idade = Console.ReadLine();

        Console.WriteLine($"Nome completo em maiúsculas: {nomeCompleto.ToUpper()}");
        Console.WriteLine($"Nome completo em minúsculas: {nomeCompleto.ToLower()}");
        Console.WriteLine($"Número de caracteres no nome completo: {nomeCompleto.Trim().Length}");

        int idadeInteiro = Convert.ToInt32(idade);
        int anoNascimento = 2023 - idadeInteiro;

        Console.WriteLine($"Ano de nascimento: {anoNascimento}");
        Console.WriteLine($"Idade em que fará 100 anos: {100 - idadeInteiro}");
    }
}