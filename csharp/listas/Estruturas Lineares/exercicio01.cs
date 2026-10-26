using System;

public class Lista
{
    private string[] elementos;
    private int quantidade;

    public int Quantidade
    {
        get { return quantidade; }
    }

    public Lista(int capacidade)
    {
        elementos = new string[capacidade];
        quantidade = 0;
    }

    public void Adicionar(string filme)
    {
        if (quantidade == elementos.Length)
        {
            Console.WriteLine("A lista está cheia.");
            return;
        }

        elementos[quantidade] = filme;
        quantidade++;
    }

    public void Inserir(int posicao, string filme)
    {
        if (quantidade == elementos.Length)
        {
            Console.WriteLine("A lista está cheia.");
            return;
        }

        if (posicao < 0 || posicao > quantidade)
        {
            Console.WriteLine("Posição inválida.");
            return;
        }

        for (int i = quantidade; i > posicao; i--)
        {
            elementos[i] = elementos[i - 1];
        }

        elementos[posicao] = filme;
        quantidade++;
    }

    public bool Remover(string filme)
    {
        int posicao = Pesquisar(filme);

        if (posicao == -1)
        {
            return false;
        }

        Remover(posicao);

        return true;
    }

    public void Remover(int posicao)
    {
        if (posicao < 0 || posicao >= quantidade)
        {
            Console.WriteLine("Posição inválida.");
            return;
        }

        for (int i = posicao; i < quantidade - 1; i++)
        {
            elementos[i] = elementos[i + 1];
        }

        elementos[quantidade - 1] = null;

        quantidade--;
    }
    public int Pesquisar(string filme)
    {
        for (int i = 0; i < quantidade; i++)
        {
            if (elementos[i] == filme)
            {
                return i;
            }
        }

        return -1;
    }

    public string Obter(int posicao)
    {
        if (posicao < 0 || posicao >= quantidade)
        {
            return null;
        }

        return elementos[posicao];
    }

    public void Listar()
    {
        if (quantidade == 0)
        {
            Console.WriteLine("A lista está vazia.");
            return;
        }

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine(i + " - " + elementos[i]);
        }
    }

    public void Inverter()
    {
        int inicio = 0;
        int fim = quantidade - 1;

        while (inicio < fim)
        {
            string temporario = elementos[inicio];

            elementos[inicio] = elementos[fim];
            elementos[fim] = temporario;

            inicio++;
            fim--;
        }
    }
}

class Program
{
    static void Main()
    {
        Lista lista = new Lista(100);

        int opcao;

        do
        {
            Console.WriteLine();
            Console.WriteLine("========== MENU ==========");
            Console.WriteLine("1 - Inserir um filme no final da lista");
            Console.WriteLine("2 - Inserir um filme em uma posição específica da lista");
            Console.WriteLine("3 - Remover um filme da lista");
            Console.WriteLine("4 - Remover um filme em uma posição específica da lista");
            Console.WriteLine("5 - Pesquisar se um filme consta na lista");
            Console.WriteLine("6 - Listar todos os filmes da lista");
            Console.WriteLine("7 - Inverter a ordem dos filmes presentes na lista");
            Console.WriteLine("8 - Encerrar o programa");
            Console.WriteLine("===========================");
            Console.Write("Digite uma opção: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o nome do filme: ");

                    string filme = Console.ReadLine();

                    lista.Adicionar(filme);

                    Console.WriteLine("Filme adicionado!");
                    break;


                case 2:
                    Console.Write("Digite o nome do filme: ");

                    filme = Console.ReadLine();

                    Console.Write("Digite a posição: ");

                    int posicao = int.Parse(Console.ReadLine());

                    lista.Inserir(posicao, filme);

                    break;


                case 3:
                    Console.Write("Digite o nome do filme que deseja remover: ");

                    filme = Console.ReadLine();

                    if (lista.Remover(filme))
                    {
                        Console.WriteLine("Filme removido!");
                    }
                    else
                    {
                        Console.WriteLine("Filme não encontrado.");
                    }

                    break;


                case 4:
                    Console.Write("Digite a posição do filme: ");

                    posicao = int.Parse(Console.ReadLine());

                    lista.Remover(posicao);

                    break;


                case 5:
                    Console.Write("Digite o nome do filme que deseja pesquisar: ");

                    filme = Console.ReadLine();

                    posicao = lista.Pesquisar(filme);

                    if (posicao != -1)
                    {
                        Console.WriteLine(
                            "O filme está na lista na posição " + posicao
                        );
                    }
                    else
                    {
                        Console.WriteLine("O filme não está na lista.");
                    }

                    break;


                case 6:
                    Console.WriteLine();
                    Console.WriteLine("===== FILMES =====");

                    lista.Listar();

                    break;


                case 7:
                    lista.Inverter();

                    Console.WriteLine("Lista invertida!");

                    break;


                case 8:
                    Console.WriteLine("Programa encerrado.");
                    break;


                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != 8);
    }
}
