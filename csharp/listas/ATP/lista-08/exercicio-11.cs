using System;
class Program
{
    static string[,] CsvParaMatriz(string csv)
    {
        if (csv == null || csv.Length == 0)
        {
            return new string[0, 0];
        }

        int linhas = 1;
        for (int i = 0; i < csv.Length; i++)
        {
            if (csv[i] == '\n')
            {
                linhas++;
            }
        }

        int colunas = 1;
        for (int i = 0; i < csv.Length; i++)
        {
            if (csv[i] == '\n')
            {
                break;
            }
            if (csv[i] == ',')
            {
                colunas++;
            }
        }

        string[,] matriz = new string[linhas, colunas];
        int linhaAtual = 0;
        int colunaAtual = 0;
        string valorAtual = "";

        for (int i = 0; i < csv.Length; i++)
        {
            if (csv[i] == ',')
            {
                matriz[linhaAtual, colunaAtual] = valorAtual;
                colunaAtual++;
                valorAtual = "";
            }
            else if (csv[i] == '\n')
            {
                matriz[linhaAtual, colunaAtual] = valorAtual;
                linhaAtual++;
                colunaAtual = 0;
                valorAtual = "";
            }
            else
            {
                valorAtual += csv[i];
            }
        }
        
        matriz[linhaAtual, colunaAtual] = valorAtual;

        return matriz;
    }

    static void Main()
    {
        Console.WriteLine("Processando a string CSV fixa:");
        string dadosCsv = "nome,idade,sexo\nAna,25,F\nJoão,30,M\nMaria,22,F";
        string[,] resultado = CsvParaMatriz(dadosCsv);

        for (int l = 0; l < resultado.GetLength(0); l++)
        {
            for (int c = 0; c < resultado.GetLength(1); c++)
            {
                Console.Write("[\"" + resultado[l, c] + "\"] ");
            }
            Console.WriteLine();
        }
    }
}