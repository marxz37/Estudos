using System;

public class Fila
{
    private string[] elementos;

    private int quantidade;

    private int inicio;

    private int capacidade;

    public Fila(int capacidade)
    {
        this.capacidade = capacidade;

        elementos = new string[capacidade];

        quantidade = 0;
        inicio = 0;
    }

    public int Quantidade
    {
        get
        {
            return quantidade;
        }
    }

    public bool EstaVazia()
    {
        return quantidade == 0;
    }

    public bool EstaCheia()
    {
        return quantidade == capacidade;
    }

    public bool Enfileirar(string elemento)
    {
        if (EstaCheia())
        {
            return false;
        }

        int posicao = (inicio + quantidade) % capacidade;

        elementos[posicao] = elemento;

        quantidade++;

        return true;
    }

    public string Desenfileirar()
    {
        if (EstaVazia())
        {
            return null;
        }

        string elemento = elementos[inicio];

        elementos[inicio] = null;

        inicio = (inicio + 1) % capacidade;

        quantidade--;

        return elemento;
    }

    public string Primeiro()
    {
        if (EstaVazia())
        {
            return null;
        }

        return elementos[inicio];
    }

    public void Exibir()
    {
        if (EstaVazia())
        {
            Console.WriteLine("A fila está vazia.");
            return;
        }

        for (int i = 0; i < quantidade; i++)
        {
            int posicao = (inicio + i) % capacidade;

            Console.WriteLine(elementos[posicao]);
        }
    }
}

public class HistoricoLimitado
{
    private Fila fila;

    private const int CAPACIDADE = 4;

    public HistoricoLimitado()
    {
        fila = new Fila(CAPACIDADE);
    }

    public void AdicionarUrl(string url)
    {
        if (fila.EstaCheia())
        {
            fila.Desenfileirar();
        }

        fila.Enfileirar(url);
    }

    public void ExibirHistorico()
    {
        Console.WriteLine();
        Console.WriteLine("===== HISTÓRICO =====");

        if (fila.EstaVazia())
        {
            Console.WriteLine("O histórico está vazio.");
            return;
        }

        fila.Exibir();
    }
}

class Program
{
    static void Main()
    {
        HistoricoLimitado historico = new HistoricoLimitado();

        int opcao;

        do
        {
            Console.WriteLine();
            Console.WriteLine("========== MENU ==========");
            Console.WriteLine("1 - Adicionar URL");
            Console.WriteLine("2 - Exibir histórico");
            Console.WriteLine("3 - Encerrar");
            Console.WriteLine("==========================");

            Console.Write("Digite uma opção: ");

            opcao = int.Parse(Console.ReadLine());


            switch (opcao)
            {
                case 1:

                    Console.Write("Digite a URL: ");

                    string url = Console.ReadLine();

                    historico.AdicionarUrl(url);

                    Console.WriteLine("URL adicionada com sucesso!");

                    break;


                case 2:

                    historico.ExibirHistorico();

                    break;


                case 3:

                    Console.WriteLine("Programa encerrado.");

                    break;


                default:

                    Console.WriteLine("Opção inválida.");

                    break;
            }

        } while (opcao != 3);
    }
}
