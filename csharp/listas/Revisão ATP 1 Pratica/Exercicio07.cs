using System;
class Program
{
    static string[,] FormatarMatriz(string csv)
    {
        string[] linhas = csv.Split("\n");
        int linhasTamanho = linhas.Length;

        foreach (string l in linhas)
        {
            Console.WriteLine(l);
        }

        string[] colunas = linhas[0].Split(',');
        int tamanhoColuna = colunas.Length;

        string[,] matriz = new string[linhasTamanho,tamanhoColuna];

        int quant = 0;

        for(int l = 0; l < matriz.GetLength(0); l++)
        {
            string[] csvQuebrado = linhas[l].Split(",");

            for(int c = 0; c < matriz.GetLength(1); c++)
            {
                matriz[l,c] = csvQuebrado[c];
            }
        }
        return matriz;
    }
    static void Main(string[] arg)
    {
        string csv = "nome,idade,sexo\nAna,25,F\nJoão,30,M\nMaria,22,F";

        string[,] matrizFormatada = FormatarMatriz(csv);

        for(int l = 0; l < matrizFormatada.GetLength(0); l++)
        {
            for(int c = 0; c < matrizFormatada.GetLength(1); c++)
            {
                Console.Write($"{matrizFormatada[l,c]}\t");
            }
            Console.WriteLine();
        }
    }
}   