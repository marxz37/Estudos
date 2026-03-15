using System;
public class atividadeescolha
{
    public static void Main2(string [] arg)
    {
        Console.WriteLine("Você concorda com os termos?");
        Console.WriteLine("Escreva S ou N:");
        string escolhaUsuario = Console.ReadLine();
        string escolhaUsuario_minuscula = escolhaUsuario.ToLower();

        switch(escolhaUsuario_minuscula)
        {
            case "s":
            Console.WriteLine("Você escolheu Sim! Você concordou com os termos.");
            break;

            case "n":
            Console.WriteLine("Você escolheu Não! Você discordou dos termos.");
            break;

            default:
            Console.WriteLine("Escreva apenas S ou N!");
            break;
        }
    }
}