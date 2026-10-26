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

class Pilha
{
    private Celula topo;

    public Pilha()
    {
        topo = null;
    }

    public bool Vazia()
    {
        return topo == null;
    }

    public void Inserir(int elemento)
    {
        Celula nova = new Celula(elemento);
        nova.Prox = topo;
        topo = nova;
    }

    public int Remover()
    {
        if (Vazia())
        {
            throw new Exception("A pilha está vazia.");
        }

        Celula removida = topo;
        int elemento = removida.Elemento;
        topo = removida.Prox;
        removida.Prox = null;
        return elemento;
    }

    public void Mostrar()
    {
        Console.Write("[ ");
        for (Celula atual = topo; atual != null; atual = atual.Prox)
        {
            Console.Write(atual.Elemento + " ");
        }
        Console.WriteLine("]");
    }
}

class Program
{
    public static void Inverter(Fila f, Pilha p)
    {
        if (!p.Vazia())
        {
            throw new Exception("A pilha auxiliar deve estar vazia.");
        }

        while (!f.Vazia())
        {
            p.Inserir(f.Remover());
        }

        while (!p.Vazia())
        {
            f.Inserir(p.Remover());
        }
    }

    static void Main()
    {
        Fila f = new Fila();
        Pilha p = new Pilha();
        int quantidade = LerQuantidade("Quantidade de elementos da fila: ");

        for (int i = 0; i < quantidade; i++)
        {
            f.Inserir(LerInteiro("Elemento " + (i + 1) + ": "));
        }

        Console.Write("Fila original: ");
        f.Mostrar();
        Inverter(f, p);
        Console.Write("Fila invertida: ");
        f.Mostrar();
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
