using System;
class Pilha
{
    private int[] elementos;
    private int topo;

    public Pilha(int tamanho)
    {
        elementos = new int[tamanho];
        topo = 0;
    }

    public void Empilhar(int x)
    {
        if (topo >= elementos.Length)
        {
            throw new Exception("Erro!");
        }

        elementos[topo] = x;
        topo++;
    }

    public int Desempilhar()
    {
        if (Vazia())
        {
            throw new Exception("Erro!");
        }

        topo--;
        return elementos[topo];
    }

    public bool Vazia()
    {
        return topo == 0;
    }

    public void Inverter()
    {
        Pilha auxiliar = new Pilha(elementos.Length);

        while (!Vazia())
        {
            auxiliar.Empilhar(Desempilhar());
        }

        while (!auxiliar.Vazia())
        {
            Empilhar(auxiliar.Desempilhar());
        }
    }

    public void Mostrar()
    {
        Console.Write("[ ");

        for (int i = topo - 1; i >= 0; i--)
        {
            Console.Write(elementos[i] + " ");
        }

        Console.WriteLine("]");
    }
}

class Program
{
    static void Main()
    {
        Pilha P = new Pilha(10);

        P.Empilhar(1);
        P.Empilhar(2);
        P.Empilhar(3);
        P.Empilhar(4);
        P.Empilhar(5);

        Console.WriteLine("Pilha original:");
        P.Mostrar();

        P.Inverter();

        Console.WriteLine("Pilha invertida:");
        P.Mostrar();
    }
}