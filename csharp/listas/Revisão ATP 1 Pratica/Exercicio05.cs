using System;
public class Program
{
    public static int VerificarOcorrencia(string s, char c, int pos)
    {
        int quant = 0;
        for(int i = pos; i < s.Length; i++)
        {
            if(char.ToLower(s[i]) == char.ToLower(c))
            {
                quant++;
            }
        }
        return quant;
    } 

    public static void Main()
    {
        string palavra = "";

        while (string.IsNullOrWhiteSpace(palavra))
        {
            Console.Write("Escreva uma palavra: ");
            palavra = Console.ReadLine();
        }

        char letra;

        Console.Write("\nEscreva uma letra: ");
        while (!char.TryParse(Console.ReadLine(), out letra))
        {
            Console.Write("Entrada inválida. Escreva apenas uma letra: ");
        }

        int posicao;

        Console.Write("\nEscreva a posição de onde irá começar a leitura: ");
        while (!int.TryParse(Console.ReadLine(), out posicao) || posicao < 0 || posicao >= palavra.Length)
        {
            Console.Write($"Posição inválida. Digite um número entre 0 e {palavra.Length - 1}: ");
        }
        
        int ocorrencias = VerificarOcorrencia(palavra,letra,posicao);

        Console.WriteLine($"\nQuantidade de ocorrências encontradas: {ocorrencias}");
    }
}