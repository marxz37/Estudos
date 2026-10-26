using System;

class Program
{
    static int[] ContarVogaisEConsoantes(string texto)
    {
        int[] resultado = new int[2];
        string textoMinusc = texto.ToLower();

        for (int i = 0; i < textoMinusc.Length; i++)
        {
            char c = textoMinusc[i];
            if (c >= 'a' && c <= 'z')
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    resultado[0]++;
                }
                else
                {
                    resultado[1]++;
                }
            }
        }

        return resultado;
    }

    static void Main()
    {
        Console.Write("Digite um texto: ");
        string entrada = Console.ReadLine();
        int[] contagens = ContarVogaisEConsoantes(entrada);

        Console.WriteLine("Vogais: " + contagens[0]);
        Console.WriteLine("Consoantes: " + contagens[1]);
    }
}