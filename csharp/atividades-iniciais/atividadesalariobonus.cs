using System;

public class atividadesalariobonus
{
    public static void Main3(string[] arg)
    {
        //Declaração das variaveis
        const int salarioMin = 1500;
        double porcentagem15 = 0;
        double porcentagem10 = 0;

        //Explicação + Entrada do Usuário:
        Console.WriteLine("Escreva o seu salário:");
        double userSalario = double.Parse(Console.ReadLine());

        //Condição:
        if(userSalario > salarioMin)
        {
            Console.WriteLine("Seu salário é maior que Salário Mínimo!");
            porcentagem10 = (userSalario * 10) / 100;
            Console.WriteLine($"Total de bonus:{porcentagem10}");
            Console.WriteLine($"Seu salário:{porcentagem10 + userSalario}");
        }
        else
        {
            Console.WriteLine("Seu salário é menor ou igual que Salário Mínimo!");
            porcentagem15 = (userSalario * 15) / 100;
            Console.WriteLine($"Total de bonus:{porcentagem15}");
            Console.WriteLine($"Seu salário:{porcentagem15 + userSalario}");
        }
    }
}