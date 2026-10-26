using System;

class CelulaSimples
{
    private int elemento;
    private CelulaSimples prox;

    public int Elemento
    {
        get { return elemento; }
        set { elemento = value; }
    }

    public CelulaSimples Prox
    {
        get { return prox; }
        set { prox = value; }
    }

    public CelulaSimples(int elemento)
    {
        this.elemento = elemento;
        prox = null;
    }

    public CelulaSimples()
    {
        elemento = 0;
        prox = null;
    }
}

class ListaSimples
{
    private CelulaSimples primeiro;
    private CelulaSimples ultimo;

    public ListaSimples()
    {
        primeiro = new CelulaSimples();
        ultimo = primeiro;
    }

    public bool Vazia()
    {
        return primeiro == ultimo;
    }

    public int Tamanho()
    {
        int tamanho = 0;
        for (CelulaSimples atual = primeiro.Prox; atual != null; atual = atual.Prox)
        {
            tamanho++;
        }
        return tamanho;
    }

    public void InserirInicio(int elemento)
    {
        CelulaSimples nova = new CelulaSimples(elemento);
        nova.Prox = primeiro.Prox;
        primeiro.Prox = nova;
        if (ultimo == primeiro)
        {
            ultimo = nova;
        }
    }

    public void InserirFim(int elemento)
    {
        ultimo.Prox = new CelulaSimples(elemento);
        ultimo = ultimo.Prox;
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
            CelulaSimples anterior = primeiro;
            for (int i = 0; i < posicao; i++)
            {
                anterior = anterior.Prox;
            }
            CelulaSimples nova = new CelulaSimples(elemento);
            nova.Prox = anterior.Prox;
            anterior.Prox = nova;
        }
    }

    public int RemoverInicio()
    {
        if (Vazia())
        {
            throw new Exception("A lista está vazia.");
        }

        CelulaSimples removida = primeiro.Prox;
        int elemento = removida.Elemento;
        primeiro.Prox = removida.Prox;
        if (removida == ultimo)
        {
            ultimo = primeiro;
        }
        removida.Prox = null;
        return elemento;
    }

    public int RemoverFim()
    {
        if (Vazia())
        {
            throw new Exception("A lista está vazia.");
        }

        CelulaSimples anterior = primeiro;
        while (anterior.Prox != ultimo)
        {
            anterior = anterior.Prox;
        }

        int elemento = ultimo.Elemento;
        anterior.Prox = null;
        ultimo = anterior;
        return elemento;
    }

    public int Remover(int posicao)
    {
        int tamanho = Tamanho();
        if (posicao < 0 || posicao >= tamanho)
        {
            throw new Exception("Posição inválida.");
        }

        CelulaSimples anterior = primeiro;
        for (int i = 0; i < posicao; i++)
        {
            anterior = anterior.Prox;
        }

        CelulaSimples removida = anterior.Prox;
        int elemento = removida.Elemento;
        anterior.Prox = removida.Prox;
        if (removida == ultimo)
        {
            ultimo = anterior;
        }
        removida.Prox = null;
        return elemento;
    }


    public void Inverter()
    {
        CelulaSimples antigoPrimeiro = primeiro.Prox;
        CelulaSimples anterior = null;
        CelulaSimples atual = primeiro.Prox;

        while (atual != null)
        {
            CelulaSimples proxima = atual.Prox;
            atual.Prox = anterior;
            anterior = atual;
            atual = proxima;
        }

        primeiro.Prox = anterior;
        if (antigoPrimeiro == null)
        {
            ultimo = primeiro;
        }
        else
        {
            ultimo = antigoPrimeiro;
        }
    }

    public void Mostrar()
    {
        Console.Write("[ ");
        for (CelulaSimples atual = primeiro.Prox; atual != null; atual = atual.Prox)
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
        ListaSimples lista = new ListaSimples();
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
