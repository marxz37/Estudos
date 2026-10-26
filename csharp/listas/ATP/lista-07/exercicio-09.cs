using System;
class Exercicio09
{
    static void ObterMaiorMenor(float[] vet, out float menor, out float maior)
    {
        menor = vet[0];
        maior = vet[0];
        for (int i = 1; i < vet.Length; i++)
        {
            if (vet[i] < menor) menor = vet[i];
            if (vet[i] > maior) maior = vet[i];
        }
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

        float[] vet = new float[n];

        Console.WriteLine("\n--- Digite os valores (Valores decimais e negativos são aceitos) ---");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            vet[i] = float.Parse(Console.ReadLine());
        }

        float maior, menor;
        ObterMaiorMenor(vet, out menor, out maior);

        Console.WriteLine($"\nMaior elemento encontrado: {maior}");
        Console.WriteLine($"Menor elemento encontrado: {menor}");
    }
}