using System;

class Program{
    static void Main(){

        int[] vet = new int [5];
        Random rnd = new Random();

        for(int i = 0; i < vet.Length; i++)
        {
            Console.WriteLine($"Digite o primeiro elemento do arranjo {i+1}:");
            int escolha = int.Parse(Console.ReadLine());
            vet[i] = escolha;
        }

        int menor = int.MaxValue;
        int pos = -1;

        for(int i = 0; i < vet.Length; i++)
        {
            if(menor > vet[i])
            {
                menor = vet[i];
                pos = Array.IndexOf(vet, menor);
            }
        }

        Console.WriteLine($"O menor elemento deste arranjo está na posição a [{pos}]");
        Console.WriteLine();

        int temp = vet[0];
        vet[0] = menor;
        vet[pos] = temp;

        for(int i = 0; i < vet.Length; i++)
        {
            Console.Write($"{vet[i]} ");
        }
    }
}