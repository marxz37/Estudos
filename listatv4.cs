using System;

public class listatv4
{
    public static void Main2(string[] args)
    {
        int i = -3;
        while(i < 0)
        {
            Console.WriteLine("Escreva quantas pessoas são:");
            i = int.Parse(Console.ReadLine());

            if(i < 0)
            {
                Console.WriteLine("Escreva um número positivo!");
            }
        }

        int cont15 = 0;
        int cont30 = 0;
        int cont45 = 0;
        int cont60 = 0;
        int continf = 0;

        while(i >= 1)
        {
            Console.WriteLine("Escreva a idade:");
            int idade = int.Parse(Console.ReadLine());

            if(idade >= 1)
            {
                if(idade >= 1 && idade <= 15)
                {
                    cont15++;
                }
                else if(idade >= 16 && idade <= 30)
                {
                    cont30++;
                }
                else if(idade >= 31 && idade <= 45)
                {
                    cont45++;
                }
                else if(idade >= 46 && idade <= 60)
                {
                    cont60++;
                }
                else
                {
                    continf++;
                }
            }
            else
            {
                Console.WriteLine("Invalido, escreva uma idade maior que zero!");
                return;
            }
        i--;
        }
        Console.WriteLine($"1 a 15 anos: {cont15}");
        Console.WriteLine($"16 a 30 anos: {cont30}");
        Console.WriteLine($"31 a 45 anos: {cont45}");
        Console.WriteLine($"46 a 60 anos: {cont60}");
        Console.WriteLine($">= 61 anos: {continf}");
    }
}