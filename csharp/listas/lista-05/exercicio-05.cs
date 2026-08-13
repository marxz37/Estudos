using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] votos = new int[6];
        string[] nomes = { "Perna Longa", "Pluto", "Mickey", "Bob Esponja", "Cebolinha", "Nulo" };
        Random rnd = new Random();
        Console.WriteLine("=== VOTAÇÃO ===");
        Console.WriteLine("Digite: [0] Perna Longa | [1] Pluto | [2] Mickey | [3] Bob Esponja | [4] Cebolinha | [Outro] Nulo");
        int aleatorio;
        for(int z = 1; z <= 100; z++)
        {
            //aleatorio = int.Parse(Console.ReadLine());
            aleatorio = rnd.Next(-1,6);
            Console.Write($"Voto nº {z}: ");
            if(aleatorio >= 0 && aleatorio <= 4)
            {
                votos[aleatorio]++;
            }
            else
            {
                votos[5]++; 
            }
        }

        int maior = votos[0], menor = votos[0];
        int codigoMaisVotado = 0;
        string nomeMenosVotado = nomes[0];

        for(int i = 1; i <= 4; i++) 
        {
            if(votos[i] > maior) 
            {
                maior = votos[i]; 
                codigoMaisVotado = i;
            }
            if(votos[i] < menor) 
            {
                menor = votos[i]; 
                nomeMenosVotado = nomes[i];
            }
        }

        Console.WriteLine("\n--- RESULTADO FINAL ---");
        Console.WriteLine($"Mais Votado: {maior} votos (Código: {codigoMaisVotado})");
        Console.WriteLine($"Menos Votado: {menor} votos (Nome: {nomeMenosVotado})");
        Console.WriteLine($"Total de Votos Nulos: {votos[5]}");
    }
}