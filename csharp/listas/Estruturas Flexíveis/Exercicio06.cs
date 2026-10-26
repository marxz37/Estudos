using System;

class Celula
{
    private int elemento;
    private Celula prox;

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

    public Celula(int elemento)
    {
        this.elemento = elemento;
        prox = null;
    }

    public Celula()
    {
        elemento = 0;
        prox = null;
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

    public bool Vazia()
    {
        return primeiro == ultimo;
    }

    public void Inserir(int elemento)
    {
        ultimo.Prox = new Celula(elemento);
        ultimo = ultimo.Prox;
    }

    public int Remover()
    {
        if (Vazia())
        {
            throw new Exception("A fila está vazia.");
        }

        Celula antigaCabeca = primeiro;
        primeiro = primeiro.Prox;
        int elemento = primeiro.Elemento;
        antigaCabeca.Prox = null;
        return elemento;
    }

    public int Consultar()
    {
        if (Vazia())
        {
            throw new Exception("A fila está vazia.");
        }
        return primeiro.Prox.Elemento;
    }

    public void Mostrar()
    {
        Console.Write("[ ");
        for (Celula atual = primeiro.Prox; atual != null; atual = atual.Prox)
        {
            Console.Write(atual.Elemento + " ");
        }
        Console.WriteLine("]");
    }
}

class Program
{
    public static void Concatenar(Fila f1, Fila f2)
    {
        if (f1 == f2)
        {
            throw new Exception("As filas devem ser diferentes.");
        }

        while (!f2.Vazia())
        {
            f1.Inserir(f2.Remover());
        }
    }

    static void Preencher(Fila fila, string nome)
    {
        int quantidade = LerQuantidade("Quantidade de elementos de " + nome + ": ");
        for (int i = 0; i < quantidade; i++)
        {
            fila.Inserir(LerInteiro("Elemento " + (i + 1) + " de " + nome + ": "));
        }
    }

    static void Main()
    {
        Fila f1 = new Fila();
        Fila f2 = new Fila();

        Preencher(f1, "F1");
        Preencher(f2, "F2");
        Concatenar(f1, f2);

        Console.Write("F1 concatenada: ");
        f1.Mostrar();
        Console.Write("F2 após a concatenação: ");
        f2.Mostrar();
    }

    static int LerInteiro(string mensagem)
    {
        Console.Write(mensagem);
        int valor = int.Parse(Console.ReadLine());
        return valor;
    }

    static int LerQuantidade(string mensagem)
    {
        int quantidade = LerInteiro(mensagem);
        while (quantidade < 0)
        {
            quantidade = LerInteiro("Digite uma quantidade maior ou igual a zero: ");
        }
        return quantidade;
    }
}
