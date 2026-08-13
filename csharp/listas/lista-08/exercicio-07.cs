using System;

class Program
{
    static int ContarPalavras(string frase)
    {
        if (string.IsNullOrEmpty(frase))
        {
            return 0;
        }

        int contador = 0;
        bool emPalavra = false;

        for (int i = 0; i < frase.Length; i++)
        {
            if (frase[i] != ' ')
            {
                if (!emPalavra)
                {
                    contador++;
                    emPalavra = true;
                }
            }
            else
            {
                emPalavra = false;
            }
        }

        return contador;
    }

    static void Main()
    {
        Console.Write("Digite uma frase: ");
        string entrada = Console.ReadLine();
        
        int totalPalavras = ContarPalavras(entrada);
        Console.WriteLine("Numero de palavras: " + totalPalavras);
    }
}