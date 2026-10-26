using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        LinkedList<string> filmes = new LinkedList<string>();
        int opcao;

        do
        {
            Console.WriteLine("1 - Inserir um filme no final da lista");
            Console.WriteLine("2 - Inserir um filme depois de uma posição específica da lista");
            Console.WriteLine("3 - Inserir um filme antes de uma posição específica da lista");
            Console.WriteLine("4 - Remover o filme que estiver no final da lista");
            Console.WriteLine("5 - Pesquisar se um filme consta na lista");
            Console.WriteLine("6 - Listar todos os filmes da lista");
            Console.WriteLine("7 - Encerrar o programa");

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o nome do filme: ");
                    string filmeFinal = Console.ReadLine()!;

                    filmes.AddLast(filmeFinal);

                    Console.WriteLine("Filme inserido no final da lista!");
                    break;

                case 2:
                    Console.Write("Digite a posição: ");
                    int posicaoDepois = int.Parse(Console.ReadLine()!);

                    Console.Write("Digite o nome do filme: ");
                    string filmeDepois = Console.ReadLine()!;

                    if (posicaoDepois >= 0 && posicaoDepois < filmes.Count)
                    {
                        LinkedListNode<string>? atual = filmes.First;

                        for (int i = 0; i < posicaoDepois; i++)
                        {
                            atual = atual!.Next;
                        }

                        filmes.AddAfter(atual!, filmeDepois);

                        Console.WriteLine("Filme inserido!");
                    }
                    else
                    {
                        Console.WriteLine("Posição inválida!");
                    }

                    break;

                case 3:
                    Console.Write("Digite a posição: ");
                    int posicaoAntes = int.Parse(Console.ReadLine()!);

                    Console.Write("Digite o nome do filme: ");
                    string filmeAntes = Console.ReadLine()!;

                    if (posicaoAntes >= 0 && posicaoAntes < filmes.Count)
                    {
                        LinkedListNode<string>? atual = filmes.First;

                        for (int i = 0; i < posicaoAntes; i++)
                        {
                            atual = atual!.Next;
                        }

                        filmes.AddBefore(atual!, filmeAntes);

                        Console.WriteLine("Filme inserido!");
                    }
                    else
                    {
                        Console.WriteLine("Posição inválida!");
                    }

                    break;

                case 4:
                    if (filmes.Count > 0)
                    {
                        Console.WriteLine(
                            $"Filme removido: {filmes.Last!.Value}"
                        );

                        filmes.RemoveLast();
                    }
                    else
                    {
                        Console.WriteLine("A lista está vazia!");
                    }

                    break;

                case 5:
                    Console.Write("Digite o nome do filme que deseja pesquisar: ");
                    string filmePesquisa = Console.ReadLine()!;

                    if (filmes.Contains(filmePesquisa))
                    {
                        Console.WriteLine("O filme está na lista!");
                    }
                    else
                    {
                        Console.WriteLine("O filme não está na lista!");
                    }

                    break;

                case 6:
                    if (filmes.Count == 0)
                    {
                        Console.WriteLine("A lista está vazia!");
                    }
                    else
                    {
                        Console.WriteLine("\n===== FILMES =====");

                        int contador = 0;

                        foreach (string filme in filmes)
                        {
                            Console.WriteLine($"{contador} - {filme}");
                            contador++;
                        }
                    }

                    break;

                case 7:
                    Console.WriteLine("Programa encerrado!");
                    break;


                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 7);
    }
}
