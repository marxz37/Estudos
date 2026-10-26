using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> listaFilmes = new List<string>();
        int escolha;

        do
        {
            Console.WriteLine("1 - Inserir um filme no final da lista");
            Console.WriteLine("2 - Inserir um filme em uma posição específica da lista");
            Console.WriteLine("3 - Remover um filme da lista");
            Console.WriteLine("4 - Remover um filme em uma posição específica da lista");
            Console.WriteLine("5 - Pesquisar se um filme consta na lista");
            Console.WriteLine("6 - Listar todos os filmes da lista");
            Console.WriteLine("7 - Inverter a ordem dos filmes presentes na lista");
            Console.WriteLine("8 - Ordenar a lista de filmes");
            Console.WriteLine("9 - Encerrar o programa");
            Console.Write("Escolha uma opção: ");

            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.Write("Escreva o nome do filme: ");
                    string filme = Console.ReadLine();

                    listaFilmes.Add(filme);

                    Console.WriteLine("Filme adicionado!");
                    break;

                case 2:
                    Console.Write("Escreva o nome do filme: ");
                    filme = Console.ReadLine();

                    Console.Write("Digite a posição: ");
                    int pos = int.Parse(Console.ReadLine());

                    if (pos >= 0 && pos <= listaFilmes.Count)
                    {
                        listaFilmes.Insert(pos, filme);
                        Console.WriteLine("Filme inserido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Posição inválida!");
                    }

                    break;

                case 3:
                    Console.Write("Escreva o nome do filme: ");
                    filme = Console.ReadLine();

                    if (listaFilmes.Contains(filme))
                    {
                        listaFilmes.Remove(filme);
                        Console.WriteLine("Filme removido!");
                    }
                    else
                    {
                        Console.WriteLine("Filme não encontrado!");
                    }

                    break;

                case 4:
                    Console.Write("Digite a posição: ");
                    pos = int.Parse(Console.ReadLine());

                    if (pos >= 0 && pos < listaFilmes.Count)
                    {
                        Console.WriteLine($"Filme removido: {listaFilmes[pos]}");

                        listaFilmes.RemoveAt(pos);
                    }
                    else
                    {
                        Console.WriteLine("Posição inválida!");
                    }

                    break;

                case 5:
                    Console.Write("Escreva o nome do filme: ");
                    filme = Console.ReadLine();

                    if (listaFilmes.Contains(filme))
                    {
                        Console.WriteLine("Filme encontrado!");
                    }
                    else
                    {
                        Console.WriteLine("Filme não encontrado!");
                    }

                    break;

                case 6:
                    if (listaFilmes.Count == 0)
                    {
                        Console.WriteLine("A lista está vazia!");
                    }
                    else
                    {
                        Console.WriteLine("FILMES");

                        for (int i = 0; i < listaFilmes.Count; i++)
                        {
                            Console.WriteLine($"{i} - {listaFilmes[i]}");
                        }
                    }

                    break;

                case 7:
                    listaFilmes.Reverse();

                    Console.WriteLine("A ordem dos filmes foi invertida!");
                    break;

                case 8:
                    listaFilmes.Sort();

                    Console.WriteLine("A lista foi ordenada!");
                    break;

                case 9:
                    Console.WriteLine("Programa encerrado!");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (escolha != 9);
    }
}
