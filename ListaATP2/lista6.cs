using System;
    public class lista6
    {
        static void Main2(string[] arg)
        {
            //Entrada do Usuário:
            Console.WriteLine("Escreva de 1 a 4:");
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva um número inteiro positivo");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva um número inteiro positivo");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva um número inteiro positivo");
            int y = int.Parse(Console.ReadLine());
            double result = 0;

            //Condições:
            if (w >= 1 && w <= 4)
            {
                if (w == 1)
                {
                    result = Math.Sqrt((double)x * (double)y * (double)z);
                    Console.WriteLine(result);
                }
                else if (w == 2)
                {
                    result = ((double)x + (2 * (double)y) + (3 * (double)z)) / 6;
                    Console.WriteLine(result);
                }
                else if (w == 3)
                {
                    result = (1 / ((1 / (double)x) + (1 / (double)y) + (1 / (double)z)));
                    Console.WriteLine(result);
                }
                else if (w == 4)
                {
                    result = ((double)x + (double)y + (double)z) / 3;
                    Console.WriteLine(result);
                }
            }
            //Evitar com que Usuário o digite valor errado.
            else
            {
                Console.WriteLine("Escreva de 1 a 4!");
            }
        }
    }