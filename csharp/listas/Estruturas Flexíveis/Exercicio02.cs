using System;

class Celula
{
    private int elemento;
    private int frequencia;
    private Celula ant;
    private Celula prox;

    public Celula(int elemento)
    {
        this.elemento = elemento;
        this.frequencia = 1;
        this.ant = null;
        this.prox = null;
    }

    public Celula()
    {
        this.elemento = 0;
        this.frequencia = 0;
        this.ant = null;
        this.prox = null;
    }

    public int Elemento
    {
        get { return elemento; }
        set { elemento = value; }
    }

    public int Frequencia
    {
        get { return frequencia; }
        set { frequencia = value; }
    }

    public Celula Ant
    {
        get { return ant; }
        set { ant = value; }
    }

    public Celula Prox
    {
        get { return prox; }
        set { prox = value; }
    }
}

class Lista
{
    private Celula primeiro, ultimo;

    public Lista()
    {
        primeiro = new Celula();
        ultimo = primeiro;
    }

    public void InserirFim(int x)
    {
        Celula tmp = new Celula(x);

        tmp.Ant = ultimo;
        ultimo.Prox = tmp;
        ultimo = tmp;

        tmp = null;
    }

    public void CompactarSequencias()
    {
        Celula atual = primeiro.Prox;

        while (atual != null)
        {
            Celula prox = atual.Prox;

            while (prox != null && atual.Elemento == prox.Elemento)
            {
                atual.Frequencia++;

                Celula remover = prox;
                prox = prox.Prox;

                atual.Prox = prox;

                if (prox != null)
                {
                    prox.Ant = atual;
                }
                else
                {
                    ultimo = atual;
                }

                remover.Ant = null;
                remover.Prox = null;
            }

            atual = atual.Prox;
        }
    }

    public void Mostrar()
    {
        Celula i = primeiro.Prox;

        Console.Write("[ ");

        while (i != null)
        {
            Console.Write(i.Elemento + "(" + i.Frequencia + ") ");

            i = i.Prox;
        }

        Console.WriteLine("]");
    }
}

class Program
{
    static void Main()
    {
        Lista lista = new Lista();

        lista.InserirFim(5);
        lista.InserirFim(5);
        lista.InserirFim(5);
        lista.InserirFim(8);
        lista.InserirFim(8);
        lista.InserirFim(3);
        lista.InserirFim(3);
        lista.InserirFim(3);
        lista.InserirFim(10);

        Console.WriteLine("Lista original:");
        lista.Mostrar();

        lista.CompactarSequencias();

        Console.WriteLine("Lista compactada:");
        lista.Mostrar();
    }
}
