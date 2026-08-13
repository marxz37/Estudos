using System;   
class Exercicio05
{
    static int ContarVogais(char[] vetor)
    {
        int count = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            char c = char.ToLower(vetor[i]);
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                count++;
        }
        return count;
    }

    static void Main(string[] args)
    {
        Console.Write("Digite o tamanho do vetor: ");
        int n = int.Parse(Console.ReadLine());

        while (n <= 0)
        {
            Console.Write("Tamanho inválido! O vetor precisa ter pelo menos 1 posição. Digite novamente: ");
            n = int.Parse(Console.ReadLine());
        }

        char[] vetor = new char[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o {i + 1}º caractere: ");
            
            string entrada = Console.ReadLine();
            
            while (string.IsNullOrEmpty(entrada))
            {
                Console.Write($"Entrada vazia! Digite o {i + 1}º caractere novamente: ");
                entrada = Console.ReadLine();
            }
            
            vetor[i] = entrada[0];
        }

        Console.WriteLine($"\nNúmero de vogais encontradas: {ContarVogais(vetor)}");
    }
}