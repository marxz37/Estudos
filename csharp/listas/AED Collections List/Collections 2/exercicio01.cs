using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();

        string caminho = @"C:\Users\1658469\Downloads\Collections2.txt";

        string[] sherlock = File.ReadAllLines(caminho);

        char[] separadores = new char[] { ' ', ';', ',', '.', '\n', '!', '?' };

        for (int i = 0; i < sherlock.Length; i++)
        {
            string[] resultado = sherlock[i].Split(
                separadores,
                StringSplitOptions.RemoveEmptyEntries
            );

            foreach (string palavra in resultado)
            {
                if (dic.ContainsKey(palavra))
                {
                    dic[palavra]++;
                }
                else
                {
                    dic.Add(palavra, 1);
                }
            }
        }

        Console.Write("Escreva a palavra que deseja procurar: ");
        string? palavraProcurada = Console.ReadLine();

        if (palavraProcurada != null && dic.ContainsKey(palavraProcurada))
        {
            Console.WriteLine("Palavra encontrada!");
            Console.WriteLine("Quantidade: " + dic[palavraProcurada]);
        }
        else
        {
            Console.WriteLine("Palavra não encontrada!");
        }

        Console.WriteLine($"Quantidade de palavras distintas: {dic.Count}");
    }
}
