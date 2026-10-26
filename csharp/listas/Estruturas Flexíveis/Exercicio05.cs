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
    public static void Intercalar(Fila f1, Fila f2, Fila f3)
    {
        while (!f1.Vazia() && !f2.Vazia())
        {
            if (f1.Consultar() <= f2.Consultar())
            {
                f3.Inserir(f1.Remover());
            }
            else
            {
                f3.Inserir(f2.Remover());
            }
        }

        while (!f1.Vazia())
        {
            f3.Inserir(f1.Remover());
        }

        while (!f2.Vazia())
        {
            f3.Inserir(f2.Remover());
        }
    }

    static void PreencherOrdenada(Fila fila, string nome)
    {
        int quantidade = LerQuantidade("Quantidade de elementos de " + nome + ": ");
        int anterior = 0;

        for (int i = 0; i < quantidade; i++)
        {
            int valor = LerInteiro("Elemento " + (i + 1) + " de " + nome + ": ");
            while (i > 0 && valor < anterior)
            {
                valor = LerInteiro("Mantenha a ordem crescente. Digite novamente: ");
            }
            fila.Inserir(valor);
            anterior = valor;
        }
    }

    static void Main()
    {
        Fila f1 = new Fila();
        Fila f2 = new Fila();
        Fila f3 = new Fila();

        PreencherOrdenada(f1, "F1");
        PreencherOrdenada(f2, "F2");
        Intercalar(f1, f2, f3);

        Console.Write("Terceira fila em ordem crescente: ");
        f3.Mostrar();
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
