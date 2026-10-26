using System;

public class listatv2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Escreva um numero inteiro e positivo:");
        int num = int.Parse(Console.ReadLine());

        while (num <= 0)
        {
            Console.WriteLine("Valor inválido! O número deve ser inteiro e positivo.");
            Console.Write("Digite novamente: ");
            num = int.Parse(Console.ReadLine());
        }
        
        double fatorial = 1;
        double soma = 1;

        for (int z = 1; z <= num; z++)
        {
            fatorial *= z;
            soma += 1.0 / fatorial;
        }

        Console.WriteLine($"Resultado da Soma: {soma:F3}");
    }
}