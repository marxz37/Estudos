using System;

public class lista15
{
    public static void Main(string[] args)
    {
        //Declaração das Variaveis e Entrada do Usuário:
        Console.WriteLine ("Digite seu ano:");
        int ano = int.Parse(Console.ReadLine());

        //Calculo:
        string bissexto = (ano % 4 == 0) ? (ano % 100 == 0 ? (ano % 400 == 0 ? "É Bissexto" : "Não é Bissexto"): "É Bissexto"): (ano <= 0) ? "-1" :"Não é Bissexto";

        //Evitar com que Usuário o digite valor errado.
        Console.WriteLine((bissexto == "-1") ? "Error, digite um número positivo!": $"O Ano {ano} {bissexto}.");
    }
}