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

class Pilha
{
    private Celula topo;

    public Pilha()
    {
        topo = null;
    }

    public void Inserir(int x)
    {
        Celula nova = new Celula(x);
        nova.Prox = topo;
        topo = nova;
    }

    public int Remover()
    {
        if (Vazia())
            throw new Exception("A pilha esta vazia.");

        Celula tmp = topo;
        int elemento = topo.Elemento;
        topo = topo.Prox;
        tmp.Prox = null;

        return elemento;
    }

    public bool Vazia()
    {
        return topo == null;
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
    public static void Inverter(Fila fila, Pilha pilha)
    {
        while (!fila.Vazia())
            pilha.Inserir(fila.Remover());

        while (!pilha.Vazia())
            fila.Inserir(pilha.Remover());
    }

    static void Main()
    {
        Fila fila = new Fila();
        Pilha pilha = new Pilha();

        Console.Write("Quantidade de elementos: ");
        int quantidade = int.Parse(Console.ReadLine());

        if (quantidade <= 0)
        {
            Console.WriteLine("A fila deve ter pelo menos um elemento.");
            return;
        }

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write("Elemento " + (i + 1) + ": ");
            fila.Inserir(int.Parse(Console.ReadLine()));
        }

        Console.Write("Fila original: ");
        fila.Mostrar();

        Inverter(fila, pilha);

        Console.Write("Fila invertida: ");
        fila.Mostrar();
    }
}
