using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        double[] notas = new double[60];
        int i = 0;
        double soma = 0;
        double notaTemp;

        Console.WriteLine("Digite as notas (negativo para sair ou limite de 60):");

        Console.Write($"Nota {i + 1}: ");
        notaTemp = double.Parse(Console.ReadLine());

        while (i < notas.Length && notaTemp >= 0)
        {
            notas[i] = notaTemp;
            soma += notas[i];
            i++;

            if (i < notas.Length)
            {
                Console.Write($"Nota {i + 1}: ");
                notaTemp = double.Parse(Console.ReadLine());
            }
        }

        int notasLidas = i;

        if (notasLidas > 0)
        {
            double media = soma / notasLidas;

            Console.WriteLine("\n--- Relatório de Notas ---");
            for (int j = 0; j < notasLidas; j++)
            {
                Console.WriteLine($"Aluno {j + 1}: {notas[j]}");
            }

            Console.WriteLine($"\nMédia da Turma: {media:F2}");
            Console.WriteLine("Notas acima da média:");
            
            for (int j = 0; j < notasLidas; j++)
            {
                if (notas[j] > media)
                {
                    Console.WriteLine($"- {notas[j]}");
                }
            }
        }
        else
        {
            Console.WriteLine("Nenhuma nota registrada.");
        }
    }
}