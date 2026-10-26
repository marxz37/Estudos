using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o caminho do arquivo de entrada: ");
        string caminhoEntrada = Console.ReadLine();

        int totalLinhas = ContarLinhas(caminhoEntrada);
        Console.WriteLine("Total de alunos: " + totalLinhas);

        string[] linhas = File.ReadAllLines(caminhoEntrada);

        string[] nomes = ArmazenarNomes(linhas, totalLinhas);

        double[] medias = CalcularMedias(linhas, totalLinhas);

        Console.Write("Digite o caminho para salvar o arquivo de saída: ");
        string caminhoSaida = Console.ReadLine();

        SalvarAprovados(caminhoSaida, nomes, medias);

        Console.WriteLine("Arquivo salvo com sucesso!");
    }

    static int ContarLinhas(string caminho)
    {
        int contador = 0;
        using (StreamReader sr = new StreamReader(caminho))
        {
            while (sr.ReadLine() != null)
            {
                contador++;
            }
        }
        return contador;
    }

    static string[] ArmazenarNomes(string[] linhas, int total)
    {
        string[] nomes = new string[total];
        for (int i = 0; i < total; i++)
        {
            string[] partes = linhas[i].Split(' ');
            nomes[i] = partes[1];
        }
        return nomes;
    }

    static double[] CalcularMedias(string[] linhas, int total)
    {
        double[] medias = new double[total];
        for (int i = 0; i < total; i++)
        {
            string[] partes = linhas[i].Split(' ');

            double n1 = double.Parse(partes[2].Replace(".", ","));
            double n2 = double.Parse(partes[3].Replace(".", ","));
            double n3 = double.Parse(partes[4].Replace(".", ","));

            medias[i] = (n1 + n2 + n3) / 3.0;
        }
        return medias;
    }

    static void SalvarAprovados(string caminhoSaida, string[] nomes, double[] medias)
    {
        using (StreamWriter sw = new StreamWriter(caminhoSaida))
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                if (medias[i] >= 6.0)
                {
                    double mediaArredondada = Math.Round(medias[i], 2);
                    sw.WriteLine(nomes[i] + " " + mediaArredondada);
                }
            }
        }
    }
}