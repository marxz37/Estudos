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

    public Celula Prox
    {
        get { return prox; }
        set { prox = value; }
    }

    public int Elemento
    {
        get { return elemento; }
        set { elemento = value; }
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

    public void InserirInicio(int x)
    {
        Celula tmp = new Celula(x);
        tmp.Prox = primeiro.Prox;
        primeiro.Prox = tmp;

        if (primeiro == ultimo)
        {
            ultimo = tmp;
        }

        tmp = null;
    }

    public void InserirFim(int x)
    {
        Celula tmp = new Celula(x);
        ultimo.Prox = tmp;
        ultimo = tmp;
        tmp = null;
    }

    public int RemoverInicio()
    {
        if (primeiro == ultimo)
            throw new Exception("Erro!");

        Celula tmp = primeiro.Prox;
        int elemento = tmp.Elemento;

        primeiro.Prox = tmp.Prox;

        if (tmp == ultimo)
            ultimo = primeiro;

        tmp.Prox = null;
        tmp = null;

        return elemento;
    }

    public int RemoverFim()
    {
        if (primeiro == ultimo)
            throw new Exception("Erro!");

        Celula i;

        for (i = primeiro; i.Prox != ultimo; i = i.Prox) ;

        int elemento = ultimo.Elemento;
        ultimo = i;
        i = ultimo.Prox = null;

        return elemento;
    }

    public void Inserir(int x, int pos)
    {
        int tamanho = Tamanho();

        if (pos < 0 || pos > tamanho)
        {
            throw new Exception("Erro!");
        }
        else if (pos == 0)
        {
            InserirInicio(x);
        }
        else if (pos == tamanho)
        {
            InserirFim(x);
        }
        else
        {
            Celula i = primeiro;

            for (int j = 0; j < pos; j++, i = i.Prox) ;

            Celula tmp = new Celula(x);
            tmp.Prox = i.Prox;
            i.Prox = tmp;

            tmp = i = null;
        }
    }

    public int Remover(int pos)
    {
        int elemento;
        int tamanho = Tamanho();

        if (primeiro == ultimo || pos < 0 || pos >= tamanho)
        {
            throw new Exception("Erro!");
        }
        else if (pos == 0)
        {
            elemento = RemoverInicio();
        }
        else if (pos == tamanho - 1)
        {
            elemento = RemoverFim();
        }
        else
        {
            Celula i = primeiro;

            for (int j = 0; j < pos; j++, i = i.Prox) ;

            Celula tmp = i.Prox;
            elemento = tmp.Elemento;
            i.Prox = tmp.Prox;

            tmp.Prox = null;
            i = tmp = null;
        }

        return elemento;
    }

    public void Particionar(int limite)
    {
        Celula menorInicio = null;
        Celula menorFim = null;
        Celula maiorInicio = null;
        Celula maiorFim = null;
        Celula atual = primeiro.Prox;

        while (atual != null)
        {
            Celula prox = atual.Prox;

            if (atual.Elemento < limite)
            {
                if (menorInicio == null)
                {
                    menorInicio = atual;
                    menorFim = atual;
                }
                else
                {
                    menorFim.Prox = atual;
                    menorFim = atual;
                }
            }
            else
            {
                if (maiorInicio == null)
                {
                    maiorInicio = atual;
                    maiorFim = atual;
                }
                else
                {
                    maiorFim.Prox = atual;
                    maiorFim = atual;
                }
            }

            atual = prox;
        }

        if (menorInicio != null)
        {
            primeiro.Prox = menorInicio;
            menorFim.Prox = maiorInicio;

            if (maiorFim != null)
                ultimo = maiorFim;
            else
                ultimo = menorFim;
        }
        else
        {
            primeiro.Prox = maiorInicio;

            if (maiorFim != null)
                ultimo = maiorFim;
            else
                ultimo = primeiro;
        }

        if (ultimo != primeiro)
            ultimo.Prox = null;
    }

    public int Tamanho()
    {
        int tam = 0;

        for (Celula i = primeiro; i != ultimo; i = i.Prox)
        {
            tam++;
        }

        return tam;
    }

    public void Mostrar()
    {
        Console.Write("[ ");

        for (Celula i = primeiro.Prox; i != null; i = i.Prox)
        {
            Console.Write(i.Elemento + " ");
        }

        Console.WriteLine("]");
    }
}

class Program
{
    static void Main()
    {
        Lista lista = new Lista();

        lista.InserirFim(7);
        lista.InserirFim(2);
        lista.InserirFim(8);
        lista.InserirFim(4);
        lista.InserirFim(15);
        lista.InserirFim(3);
        lista.InserirFim(10);

        Console.WriteLine("Lista original:");
        lista.Mostrar();

        lista.Particionar(8);

        Console.WriteLine("Lista depois de Particionar(8):");
        lista.Mostrar();
    }
}
