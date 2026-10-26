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


    public void InserirOrdenado(int elemento)
    {
        CelulaSimples anterior = primeiro;
        while (anterior.Prox != null && anterior.Prox.Elemento <= elemento)
        {
            anterior = anterior.Prox;
        }

        CelulaSimples nova = new CelulaSimples(elemento);
        nova.Prox = anterior.Prox;
        anterior.Prox = nova;

        if (nova.Prox == null)
        {
            ultimo = nova;
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


    public void InserirOrdenado(int elemento)
    {
        CelulaDupla anterior = primeiro;
        while (anterior.Prox != null && anterior.Prox.Elemento <= elemento)
        {
            anterior = anterior.Prox;
        }

        CelulaDupla nova = new CelulaDupla(elemento);
        nova.Prox = anterior.Prox;
        nova.Ant = anterior;

        if (nova.Prox != null)
        {
            nova.Prox.Ant = nova;
        }
        else
        {
            ultimo = nova;
        }
        anterior.Prox = nova;
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
        ListaSimples simples = new ListaSimples();
        ListaDupla dupla = new ListaDupla();
        int quantidade = LerQuantidade("Quantidade de valores a inserir: ");

        for (int i = 0; i < quantidade; i++)
        {
            int valor = LerInteiro("Valor " + (i + 1) + ": ");
            simples.InserirOrdenado(valor);
            dupla.InserirOrdenado(valor);
        }

        Console.Write("Lista simples em ordem crescente: ");
        simples.Mostrar();
        Console.Write("Lista dupla em ordem crescente: ");
        dupla.Mostrar();
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
