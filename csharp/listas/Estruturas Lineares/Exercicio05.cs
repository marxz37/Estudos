using System;

class Celula
{
    private int elemento;
    private Celula prox;

    public Celula(int elemento)
    {
        this.elemento = elemento;
        this.prox = null;
    }

    public Celula()
    {
        this.elemento = 0;
        this.prox = null;
    }

    public int Elemento
    {
        get { return elemento; }
        set { elemento = value; }
    }

    public Celula Prox
    {
        get { return prox; }
        set { prox = value; }
    }
}

class Fila
{
    private Celula primeiro;
    private Celula ultimo;

    public Fila()
    {
        primeiro = new Celula();
        ultimo = primeiro;
    }

    public void Inserir(int x)
    {
        if (Pesquisar(x))
            throw new Exception("O aluno ja esta nesta fila.");

        ultimo.Prox = new Celula(x);
        ultimo = ultimo.Prox;
    }

    public int Remover()
    {
        if (Vazia())
            throw new Exception("A fila esta vazia.");

        Celula tmp = primeiro;
        primeiro = primeiro.Prox;
        int elemento = primeiro.Elemento;
        tmp.Prox = null;

        return elemento;
    }

    public bool Vazia()
    {
        return primeiro == ultimo;
    }

    public int Proximo()
    {
        if (Vazia())
            throw new Exception("A fila esta vazia.");

        return primeiro.Prox.Elemento;
    }

    public bool Pesquisar(int x)
    {
        for (Celula i = primeiro.Prox; i != null; i = i.Prox)
        {
            if (i.Elemento == x)
                return true;
        }

        return false;
    }

    public void Mostrar()
    {
        Console.Write("[ ");

        for (Celula i = primeiro.Prox; i != null; i = i.Prox)
            Console.Write(i.Elemento + " ");

        Console.WriteLine("]");
    }
}

class Program
{
    static void Main()
    {
        Fila iniciacaoCientifica = new Fila();
        Fila mestrado = new Fila();
        int opcao = 0;

        do
        {
            Console.WriteLine("\n1 - Inserir aluno na fila de Iniciacao Cientifica");
            Console.WriteLine("2 - Inserir aluno na fila de Mestrado");
            Console.WriteLine("3 - Remover aluno da fila de Iniciacao Cientifica");
            Console.WriteLine("4 - Remover aluno da fila de Mestrado");
            Console.WriteLine("5 - Mostrar fila de Iniciacao Cientifica");
            Console.WriteLine("6 - Mostrar fila de Mestrado");
            Console.WriteLine("7 - Pesquisar aluno na fila de Iniciacao Cientifica");
            Console.WriteLine("8 - Pesquisar aluno na fila de Mestrado");
            Console.WriteLine("9 - Mostrar primeiro aluno da fila de Iniciacao Cientifica");
            Console.WriteLine("10 - Mostrar primeiro aluno da fila de Mestrado");
            Console.WriteLine("11 - Encerrar o programa");
            Console.Write("Opcao: ");

            try
            {
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Codigo do aluno: ");
                        iniciacaoCientifica.Inserir(int.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        Console.Write("Codigo do aluno: ");
                        mestrado.Inserir(int.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine("Aluno removido: " + iniciacaoCientifica.Remover());
                        break;
                    case 4:
                        Console.WriteLine("Aluno removido: " + mestrado.Remover());
                        break;
                    case 5:
                        iniciacaoCientifica.Mostrar();
                        break;
                    case 6:
                        mestrado.Mostrar();
                        break;
                    case 7:
                        Console.Write("Codigo do aluno: ");

                        if (iniciacaoCientifica.Pesquisar(int.Parse(Console.ReadLine())))
                            Console.WriteLine("Aluno encontrado.");
                        else
                            Console.WriteLine("Aluno nao encontrado.");

                        break;
                    case 8:
                        Console.Write("Codigo do aluno: ");

                        if (mestrado.Pesquisar(int.Parse(Console.ReadLine())))
                            Console.WriteLine("Aluno encontrado.");
                        else
                            Console.WriteLine("Aluno nao encontrado.");

                        break;
                    case 9:
                        Console.WriteLine("Primeiro aluno: " + iniciacaoCientifica.Proximo());
                        break;
                    case 10:
                        Console.WriteLine("Primeiro aluno: " + mestrado.Proximo());
                        break;
                    case 11:
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
        while (opcao != 11);
    }
}
