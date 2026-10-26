using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        double[] nota = new double[200];
        int opcao = 0;
        double somaMedia = 0, menor = double.MaxValue, maior = double.MinValue, acimaDaMedia = 0, media = 0;
        Random rnd = new Random();
        
        Console.WriteLine($"Escreva a nota dos alunos!");
        for(int i = 0; i < nota.Length; i++)
        {
            do
            {
                Console.WriteLine($"Nota do aluno {i+1}");
                nota[i] = double.Parse(Console.ReadLine());
            }
            while(nota[i] > 100 || nota[i] < 0);
            
            if(menor > nota[i])
            {
                menor = nota[i];
            }
            
            if(maior < nota[i])
            {
                maior = nota[i];
            }
            somaMedia += nota[i];
        }
        somaMedia /= nota.Length;
        
        for(int i = 0; i < nota.Length; i++)
        {
            if(somaMedia < nota[i])
            {
                media++;
            }
        }
        
        double nota_desejada = 0;
        
        do
        {
            Console.WriteLine($"[1] Mostrar a menor nota [2] Mostrar a maior nota [3] Pesquisar Nota [4] Mostrar média das notas e quantidade de notas acima da média [5] sair.");
            opcao = int.Parse(Console.ReadLine());
            switch(opcao)
            {
                case 1:
                Console.WriteLine($"{menor}");
                break;
                
                case 2:
                Console.WriteLine($"{maior}");
                break;
                
                case 3:
                Console.WriteLine("Que nota você deseja procurar?");
                nota_desejada = double.Parse(Console.ReadLine());
                Console.WriteLine($"A Nota {nota_desejada} consta nas posições:");
                bool achou = false;
                for(int i = 0; i < nota.Length; i++)
                {
                    if(nota_desejada == nota[i])
                    {
                        achou = true;
                        Console.Write($"{i} ");
                    }
                }
                if(achou == false)
                {
                    Console.WriteLine("Nota não encontrada!");
                }
                else
                {
                    Console.WriteLine($"\nNota encontrada! {nota_desejada}");
                }
                break;
                
                case 4:
                Console.WriteLine($"Média de notas: {somaMedia:F2}");
                Console.WriteLine($"Quantidade de notas acima da média: {media}");
                break;
                
                case 5:
                Console.WriteLine("Até Mais!");
                break;
                
                default:
                Console.WriteLine("Escolha uma das opções!");
                break;
            }
        }
        while(opcao != 5);
    }
}