using System;

class Celula
{
    private long elemento;
    private Celula prox;

    public Celula(long elemento)
    {
        this.elemento = elemento;
        this.prox = null;
    }

    public Celula()
    {
        this.elemento = 0;
        this.prox = null;
    }

    public long Elemento
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

    public void Inserir(long x)
    {
        Celula nova = new Celula(x);
        nova.Prox = topo;
        topo = nova;
    }

    public long Remover()
    {
        if (Vazia())
            throw new Exception("A pilha esta vazia.");

        Celula tmp = topo;
        long elemento = topo.Elemento;
        topo = topo.Prox;
        tmp.Prox = null;

        return elemento;
    }

    public bool Vazia()
    {
        return topo == null;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Digite n (maior ou igual a 3): ");
        int n = int.Parse(Console.ReadLine());

        if (n < 3)
        {
            Console.WriteLine("n deve ser maior ou igual a 3.");
            return;
        }

        if (n > 93)
        {
            Console.WriteLine("O tipo long permite calcular ate 93 elementos sem ultrapassar seu limite.");
            return;
        }

        Pilha pilha = new Pilha();
        long anterior = 0;
        long atual = 1;

        pilha.Inserir(anterior);
        pilha.Inserir(atual);

        for (int i = 2; i < n; i++)
        {
            long proximo = anterior + atual;
            pilha.Inserir(proximo);
            anterior = atual;
            atual = proximo;
        }

        while (!pilha.Vazia())
        {
            Console.Write(pilha.Remover());

            if (!pilha.Vazia())
                Console.Write(", ");
        }

        Console.WriteLine();
    }
}
