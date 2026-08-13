using System;
public class atividadeimparoupar2
{
    public static void Main2(string [] arg)
    {
        Console.WriteLine("Escreva qualquer número para saber se é impar ou par:");

        int userNumber = int.Parse(Console.ReadLine());

        userNumber %= 2;

        switch (userNumber)
        {
        case 1:
        Console.WriteLine("Seu número é impar!");
        Console.WriteLine("Resto da operação: {0}", userNumber);
        break;

        case 0:
        Console.WriteLine("Seu número é par!");
        Console.WriteLine("Resto da operação: {0}", userNumber);
        break;

        default:
        Console.WriteLine("Escreva apenas números!");
        break;
        }
    }
}