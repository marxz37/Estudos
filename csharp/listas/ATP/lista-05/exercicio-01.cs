using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] vetA = new int[20];
        for(int i = 0; i < vetA.Length; i++)
        {
            Console.WriteLine($"Escreva um número inteiro {i+1}:");
            vetA[i] = int.Parse(Console.ReadLine());
        }
        
        char escolha = 's';
        do
        {
            Console.WriteLine("Qual número você deseja procurar:");
            int num_Desejado = int.Parse(Console.ReadLine());

            bool encontrou = false;

            for(int i = 0; i < vetA.Length; i++)
            {
                if(vetA[i] == num_Desejado)
                {
                    Console.WriteLine($"Numero Encontrado! {vetA[i]}");
                    encontrou = true;
                    break;
                }
            }
            if(encontrou == false)
            {
                Console.WriteLine($"Numero Não Encontrado!");
            }
            
            Console.WriteLine($"Deseja continuar? (S/N).");
            escolha = char.Parse(Console.ReadLine().ToLower());
        }
        while(escolha == 's');
    }
}