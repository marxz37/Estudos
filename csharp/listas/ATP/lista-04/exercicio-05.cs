using System;

public class listatv5
{
    public static void Main(string[] args)
    {
        double candidato1 = 0, candidato2 = 0, candidato3 = 0, maior = double.MinValue, total = 0, branco = 0, nulo = 0, codigo = 0;
        char s_n = 's';

        do
        {
            Console.WriteLine("[1] Candidato, [2] Candidato, [3] Candidato, [4] Voto Branco, [Qualquer Voto Inválido] Nulo.");
            Console.WriteLine("Escolha um dos candidatos!");
            int escolha = int.Parse(Console.ReadLine());
            while (escolha < 0)
            {
                Console.WriteLine("O código do voto não pode ser negativo!");
                Console.WriteLine("Escolha um dos candidatos novamente:");
                escolha = int.Parse(Console.ReadLine());
            }
            
            switch(escolha)
            {
                case 1:
                candidato1++;
                break;
                
                case 2:
                candidato2++;
                break;
                
                case 3:
                candidato3++;
                break;
                
                case 4:
                branco++;
                break;
                
                default:
                nulo++;
                break;
            }
            Console.WriteLine("Deseja adicionar mais um Voto? (S/N)");
            s_n = char.Parse(Console.ReadLine().ToLower());
        }
        while(s_n == 's');

        total = candidato1 + candidato2 + candidato3 + branco + nulo;

        maior = candidato1;
        codigo = 1;

        if(candidato2 > maior)
        {
            maior = candidato2;
            codigo = 2;
        }

        if(candidato3 > maior)
        {
            maior = candidato3;
            codigo = 3;
        }

        Console.WriteLine($"Total de Votos para Todos os Candidatos: {total}");
        Console.WriteLine($"Candidato 1: {candidato1}");
        Console.WriteLine($"Candidato 2: {candidato2}");
        Console.WriteLine($"Candidato 3: {candidato3}");
        Console.WriteLine($"Branco: {branco}");
        Console.WriteLine($"Nulo: {nulo}");
        Console.WriteLine();
        Console.WriteLine($"Código do Candidato mais Votado: {codigo} Quantidade: {maior}.");
        Console.WriteLine($"Total de Votos Nulos: {nulo}");
        Console.WriteLine($"Total de Votos em Branco: {branco}");
    }
}