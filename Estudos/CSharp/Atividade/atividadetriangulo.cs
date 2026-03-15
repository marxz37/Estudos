using System;
public class atividadetriangulo
{
    public static void Main2(string[] arg)
    {
        //Explicação!
        Console.WriteLine("Vamos calcular para saber que tipo de triângulo é!");

        //Declaração das variaveis:
        double num1, num2, num3;

        //Entrada do usuário:
        Console.WriteLine("Escreva o número 1:");
        num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Escreva o número 2:");
        num2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Escreva o número 3:");
        num3 = double.Parse(Console.ReadLine());

        //Condições:
        if(num1 + num2 > num3 && num2 + num3 > num1 && num3 + num1 > num2)
        {
            if(num1 == num2 && num1 == num3)
            {
                Console.WriteLine("Triângulo equilátero: 3 lados iguais!");
            }
            else if(num1 == num2 || num2 == num3 || num1 == num3)
            {
                Console.WriteLine("Triângulo isósceles: quaisquer 2 lados iguais!");
            }
            else
            {
                Console.WriteLine("Triângulo escaleno: 3 lados diferentes!");
            }
        }
        else
        {
            Console.WriteLine("Não formam um triângulo!");
        }

        string x = Console.ReadLine();
    }
}