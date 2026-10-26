using System;

class CelulaDupla
{
    private int elemento;
    private CelulaDupla prox;
    private CelulaDupla ant;

    public int Elemento
    {
        get { return elemento; }
        set { elemento = value; }
    }

    public CelulaDupla Prox
    {
        get { return prox; }
        set { prox = value; }
    }

    public CelulaDupla Ant
    {
        get { return ant; }
        set { ant = value; }
    }

    public CelulaDupla(int elemento)
    {
        this.elemento = elemento;
        prox = null;
        ant = null;
    }

    public CelulaDupla()
    {
        elemento = 0;
        prox = null;
        ant = null;
    }
}

class ListaDupla
{
    private CelulaDupla primeiro;
    private CelulaDupla ultimo;

    public ListaDupla()
    {
        primeiro = new CelulaDupla();
        ultimo = primeiro;
    }

    public bool Vazia()
    {
        return primeiro == ultimo;
    }

    public int Tamanho()
    {
        int tamanho = 0;
        for (CelulaDupla atual = primeiro.Prox; atual != null; atual = atual.Prox)
        {
            tamanho++;
        }
        return tamanho;
    }

    public void InserirInicio(int elemento)
    {
        CelulaDupla nova = new CelulaDupla(elemento);
        nova.Prox = primeiro.Prox;
        nova.Ant = primeiro;

        if (primeiro.Prox != null)
        {
            primeiro.Prox.Ant = nova;
        }
        else
        {
            ultimo = nova;
        }
        primeiro.Prox = nova;
    }

    public void InserirFim(int elemento)
    {
        CelulaDupla nova = new CelulaDupla(elemento);
        nova.Ant = ultimo;
        ultimo.Prox = nova;
        ultimo = nova;
    }

    public void Inserir(int elemento, int posicao)
    {
        int tamanho = Tamanho();
        if (posicao < 0 || posicao > tamanho)
        {
            throw new Exception("Posição inválida.");
        }

        if (posicao == 0)
        {
            InserirInicio(elemento);
        }
        else if (posicao == tamanho)
        {
            InserirFim(elemento);
        }
        else
        {
            CelulaDupla anterior = primeiro;
            for (int i = 0; i < posicao; i++)
            {
                anterior = anterior.Prox;
            }

            CelulaDupla nova = new CelulaDupla(elemento);
            nova.Prox = anterior.Prox;
            nova.Ant = anterior;
            anterior.Prox.Ant = nova;
            anterior.Prox = nova;
        }
    }

    public int RemoverInicio()
    {
        if (Vazia())
        {
            throw new Exception("A lista está vazia.");
        }

        CelulaDupla removida = primeiro.Prox;
        int elemento = removida.Elemento;
        primeiro.Prox = removida.Prox;
        if (primeiro.Prox != null)
        {
            primeiro.Prox.Ant = primeiro;
        }
        else
        {
            ultimo = primeiro;
        }
        removida.Prox = null;
        removida.Ant = null;
        return elemento;
    }

    public int RemoverFim()
    {
        if (Vazia())
        {
            throw new Exception("A lista está vazia.");
        }

        CelulaDupla removida = ultimo;
        int elemento = removida.Elemento;
        ultimo = removida.Ant;
        ultimo.Prox = null;
        removida.Ant = null;
        removida.Prox = null;
        return elemento;
    }

    public int Remover(int posicao)
    {
        int tamanho = Tamanho();
        if (posicao < 0 || posicao >= tamanho)
        {
            throw new Exception("Posição inválida.");
        }

        CelulaDupla removida = primeiro.Prox;
        for (int i = 0; i < posicao; i++)
        {
            removida = removida.Prox;
        }

        int elemento = removida.Elemento;
        removida.Ant.Prox = removida.Prox;
        if (removida.Prox != null)
        {
            removida.Prox.Ant = removida.Ant;
        }
        else
        {
            ultimo = removida.Ant;
        }
        removida.Ant = null;
        removida.Prox = null;
        return elemento;
    }


    public void Inverter()
    {
        CelulaDupla antigoPrimeiro = primeiro.Prox;
        CelulaDupla anterior = null;
        CelulaDupla atual = primeiro.Prox;

        while (atual != null)
        {
            CelulaDupla proxima = atual.Prox;
            atual.Prox = anterior;
            atual.Ant = proxima;
            anterior = atual;
            atual = proxima;
        }

        primeiro.Prox = anterior;
        if (anterior == null)
        {
            ultimo = primeiro;
        }
        else
        {
            anterior.Ant = primeiro;
            ultimo = antigoPrimeiro;
        }
    }

    public void Mostrar()
    {
        Console.Write("[ ");
        for (CelulaDupla atual = primeiro.Prox; atual != null; atual = atual.Prox)
        {
            Console.Write(atual.Elemento + " ");
        }
        Console.WriteLine("]");
    }

    public void MostrarInverso()
    {
        Console.Write("[ ");
        for (CelulaDupla atual = ultimo; atual != primeiro; atual = atual.Ant)
        {
            Console.Write(atual.Elemento + " ");
        }
        Console.WriteLine("]");
    }
}

class Program
{
    static void Main()
    {
        ListaDupla lista = new ListaDupla();
        int quantidade = LerQuantidade("Quantidade de elementos: ");

        for (int i = 0; i < quantidade; i++)
        {
            lista.InserirFim(LerInteiro("Elemento " + (i + 1) + ": "));
        }

        Console.Write("Lista original: ");
        lista.Mostrar();
        lista.Inverter();
        Console.Write("Lista invertida: ");
        lista.Mostrar();
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
