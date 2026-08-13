using System;
class Exercicio10
{
    static void LerVetor(int[] vet, string disciplina)
    {
        Console.WriteLine($"\nDigite as matrículas dos alunos de {disciplina}:");
        for (int i = 0; i < vet.Length; i++)
        {
            Console.Write($"Matrícula {i + 1}: ");
            int matricula = int.Parse(Console.ReadLine());

            while (matricula <= 0)
            {
                Console.Write($"Matrícula inválida! Digite um número maior que zero para a Matrícula {i + 1}: ");
                matricula = int.Parse(Console.ReadLine());
            }

            vet[i] = matricula;
        }
    }
    static int[] Intersecao(int[] v1, int[] v2)
    {
        int[] temp = new int[v1.Length];
        int count = 0;
        
        for (int i = 0; i < v1.Length; i++)
        {
            for (int j = 0; j < v2.Length; j++)
            {
                if (v1[i] == v2[j])
                {
                    temp[count] = v1[i];
                    count++;
                    break; 
                }
            }
        }

        int[] resultado = new int[count];
        for (int i = 0; i < count; i++)
        {
            resultado[i] = temp[i];
        }

        return resultado;
    }
    static void Main(string[] args)
    {
        int[] atp = new int[10];
        int[] diw = new int[10];

        LerVetor(atp, "Algoritmos e Técnicas de Programação (ATP)");
        LerVetor(diw, "DIW");

        int[] comum = Intersecao(atp, diw);

        if (comum.Length == 0)
        {
            Console.WriteLine("\nNenhum aluno está matriculado simultaneamente nas duas disciplinas.");
        }
        else
        {
            Console.WriteLine("\nAlunos matriculados simultaneamente nas duas disciplinas (Intersecção):");
            for (int i = 0; i < comum.Length; i++)
            {
                Console.WriteLine($"Matrícula: {comum[i]}");
            }
        }
    }
}