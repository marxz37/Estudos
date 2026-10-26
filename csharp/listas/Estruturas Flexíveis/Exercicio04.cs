using System;

class Celula
{
    private char elemento;
    private Celula prox;

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

    public Celula(char elemento)
    {
        this.elemento = elemento;
        prox = null;
    }

    public Celula()
    {
        elemento = '\0';
        prox = null;
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

    public void Inserir(char elemento)
    {
        Celula nova = new Celula(elemento);
        nova.Prox = topo;
        topo = nova;
    }

    public char Remover()
    {
        if (Vazia())
        {
            throw new Exception("A pilha está vazia.");
        }

        Celula removida = topo;
        char elemento = removida.Elemento;
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

    public static bool VerificarPalindromo(Pilha p)
    {
        Pilha inversa = new Pilha();

        for (Celula atual = p.topo; atual != null; atual = atual.Prox)
        {
            inversa.Inserir(atual.Elemento);
        }

        for (Celula atual = p.topo; atual != null; atual = atual.Prox)
        {
            if (atual.Elemento != inversa.Remover())
            {
                return false;
            }
        }
        return true;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();
        if (palavra == null)
        {
            palavra = "";
        }
        Pilha p = new Pilha();

        for (int i = 0; i < palavra.Length; i++)
        {
            p.Inserir(palavra[i]);
        }

        Console.Write("Pilha antes (topo para base): ");
        p.Mostrar();
        Console.WriteLine("É palíndromo: " + Pilha.VerificarPalindromo(p));
        Console.Write("Pilha depois (topo para base): ");
        p.Mostrar();
    }
}
