using System;
public class atividadeaudiencia
{
    public static void Main2(string[] arg)
    {
        //Declaração da variavel
        int num1;

        //Explicação!
        Console.WriteLine("Escreva a quantidade de audiência no Estádio:");

        //Entrada do Usuário:
        num1 = int.Parse(Console.ReadLine());

        //Condições:
        if(num1 <= 1000)
        {
            Console.WriteLine("Publico Baixo - Menos que 1000!");
        }
        else if(num1 > 1000 && num1 <= 10000)
        {
            Console.WriteLine("Publico Médio - Entre 1000 e 10000!");
        }
        else
        {
            Console.WriteLine("Publico Bom - Mais que 10000!");
        }

        string x = Console.ReadLine();
    }
}
