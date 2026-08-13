using System;

public class listatv5
{
    public static void Main2(string[] args)
    {
        Console.WriteLine("--------------------Mapa Cartesiano--------------------");
        Console.WriteLine("Escreva a coordenada 1:");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Escreva a coordenada 2:");
        int y = int.Parse(Console.ReadLine());

        while(x != 0 && y != 0)
        {
            if(x >= 0 && y >= 0)
            {
                Console.Clear();
                Console.WriteLine($"Primeiro Quadrante! ");
            }
            else if(x < 0 && y >= 0)
            {
                Console.Clear();
                Console.WriteLine($"Segundo Quadrante! ");
            }
            else if(x < 0 && y < 0)
            {
                Console.Clear();
                Console.WriteLine($"Terceiro Quadrante! ");
            }
            else if(x >= 0 && y < 0)
            {
                Console.Clear();
                Console.WriteLine($"Quarto Quadrante! ");
            }

            Console.WriteLine("Escreva a coordenada 1:");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva a coordenada 2:");
            y = int.Parse(Console.ReadLine());
        }
    }
}