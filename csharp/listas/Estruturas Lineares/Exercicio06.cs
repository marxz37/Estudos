using System;

class FilaCircular
{
    private string[] elementos;
    private int primeiro;
    private int ultimo;
    private int quantidade;

    public FilaCircular(int tamanho)
    {
        if (tamanho <= 0)
            throw new Exception("O tamanho da fila deve ser positivo.");

        elementos = new string[tamanho];
        primeiro = 0;
        ultimo = 0;
        quantidade = 0;
    }

    public FilaCircular()
    {
        elementos = new string[100];
        primeiro = 0;
        ultimo = 0;
        quantidade = 0;
    }

    public void Inserir(string cliente)
    {
        if (quantidade == elementos.Length)
            throw new Exception("A fila esta cheia.");

        elementos[ultimo] = cliente;
        ultimo = (ultimo + 1) % elementos.Length;
        quantidade++;
    }

    public string Remover()
    {
        if (Vazia())
            throw new Exception("A fila esta vazia.");

        string cliente = elementos[primeiro];
        elementos[primeiro] = null;
        primeiro = (primeiro + 1) % elementos.Length;
        quantidade--;

        return cliente;
    }

    public bool Vazia()
    {
        return quantidade == 0;
    }

    public int Contar()
    {
        return quantidade;
    }

    public string Proximo()
    {
        if (Vazia())
            throw new Exception("A fila esta vazia.");

        return elementos[primeiro];
    }
}

class Program
{
    static void Main()
    {
        FilaCircular fila = new FilaCircular();
        int opcao = 0;

        do
        {
            Console.WriteLine("\n1 - Adicionar cliente a fila");
            Console.WriteLine("2 - Atender cliente");
            Console.WriteLine("3 - Exibir numero de clientes na fila");
            Console.WriteLine("4 - Exibir proximo cliente");
            Console.WriteLine("5 - Encerrar o programa");
            Console.Write("Opcao: ");

            try
            {
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Nome do cliente: ");
                        fila.Inserir(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Cliente atendido: " + fila.Remover());
                        break;
                    case 3:
                        Console.WriteLine("Clientes na fila: " + fila.Contar());
                        break;
                    case 4:
                        Console.WriteLine("Proximo cliente: " + fila.Proximo());
                        break;
                    case 5:
                        Console.WriteLine("Programa encerrado.");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida.");
                        break;
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
        }
        while (opcao != 5);
    }
}
