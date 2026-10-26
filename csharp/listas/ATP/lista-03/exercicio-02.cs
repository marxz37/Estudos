using System;

public class listatv2
{
    public static void Main2(string[] args)
    {
        Console.WriteLine ("Escreva um número impar:");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine ("Escreva outro número impar maior que o anterior:");
        int y = int.Parse(Console.ReadLine());

        if(y > x && x % 2 == 1 && y % 2 == 1)
        {
            while(x <= y)
            {
                double a = (double)x % 2;
                if(a == 1)
                {
                    Console.WriteLine(x);
                }
                else
                {
                    
                }
                x++;
            }
        }
        else
        {
            Console.WriteLine("Erro! Valores Invalidos.");
        }
    }
}