using System;

class Celula
{
    private char elemento;
    private Celula prox;

    public Celula(char elemento)
    {
        this.elemento = elemento;
        this.prox = null;
    }

    public Celula()
    {
        this.elemento = '\0';
        this.prox = null;
    }

    public char Elemento
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

    public void Inserir(char x)
    {
        Celula nova = new Celula(x);
        nova.Prox = topo;
        topo = nova;
    }

    public char Remover()
    {
        if (Vazia())
            throw new Exception("A pilha esta vazia.");

        Celula tmp = topo;
        char elemento = topo.Elemento;
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
        Pilha pilha = new Pilha();

        Console.Write("Digite uma string: ");
        string texto = Console.ReadLine();

        for (int i = 0; i < texto.Length; i++)
            pilha.Inserir(texto[i]);

        string invertida = "";

        while (!pilha.Vazia())
            invertida += pilha.Remover();

        Console.WriteLine("String invertida: " + invertida);
    }
}
