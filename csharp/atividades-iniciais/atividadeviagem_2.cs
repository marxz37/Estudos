using System;
public class atividadeviagem_2
{
    public static void Main2(string[] arg)
    {
        double valorTotal = 0;
        //
        Console.WriteLine("Escolha um destes destinos: Norte, Nordeste, Sudeste, Sul:");
        string escolhaUser = Console.ReadLine().ToLower();

        switch(escolhaUser)
        {
            case "norte":
            Console.WriteLine("Você escolheu Norte!");
            valorTotal += 500;
            break;

            case "nordeste":
            Console.WriteLine("Você escolheu Nordeste!");
            valorTotal += 350;
            break;

            case "sudeste":
            Console.WriteLine("Você escolheu Sudeste!");
            valorTotal += 350;
            break;

            case "sul":
            Console.WriteLine("Você escolheu Sul!");
            valorTotal += 300;
            break;

            default:
            Console.WriteLine("Escolha um destes destinos: Norte, Nordeste, Sudeste, Sul!");
            return;
        }

        Console.WriteLine("Inclui a volta? S ou N.");
        string escolhaSN = Console.ReadLine().ToLower();

        switch(escolhaSN, escolhaUser)
        {
            case ("s", "norte"):
            valorTotal += 400;
            break;

            case ("s","nordeste"):
            valorTotal += 300;
            break;

            case ("s","sudeste"):
            valorTotal += 250;
            break;

            case ("s","sul"):
            valorTotal += 250;
            break;

            case ("n", _):
            break;

            default:
            Console.WriteLine("Escolha um destes S ou N!");
            return;
        }
        Console.WriteLine("Valor Total a Pagar: {0:C}", valorTotal);
    }
}
