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
}

class Lista
{
    private Celula primeiro;
    private Celula ultimo;

    public Lista()
    {
        primeiro = new Celula();
        ultimo = primeiro;
    }

    public void Inserir(int x)
    {
        ultimo.Prox = new Celula(x);
        ultimo = ultimo.Prox;
    }

    public bool Pesquisar(int x)
    {
        for (Celula i = primeiro.Prox; i != null; i = i.Prox)
        {
            if (i.Elemento == x)
                return true;
        }

        return false;
    }

    public long Somar()
    {
        long soma = 0;

        for (Celula i = primeiro.Prox; i != null; i = i.Prox)
            soma += i.Elemento;

        return soma;
    }

    public int Maior()
    {
        if (primeiro == ultimo)
            throw new Exception("A lista esta vazia.");

        int maior = primeiro.Prox.Elemento;

        for (Celula i = primeiro.Prox; i != null; i = i.Prox)
        {
            if (i.Elemento > maior)
                maior = i.Elemento;
        }

        return maior;
    }

    public int Menor()
    {
        if (primeiro == ultimo)
            throw new Exception("A lista esta vazia.");

        int menor = primeiro.Prox.Elemento;

        for (Celula i = primeiro.Prox; i != null; i = i.Prox)
        {
            if (i.Elemento < menor)
                menor = i.Elemento;
        }

        return menor;
    }

    public void RemoverPares()
    {
        Celula anterior = primeiro;
        Celula atual = primeiro.Prox;

        while (atual != null)
        {
            if (atual.Elemento % 2 == 0)
            {
                anterior.Prox = atual.Prox;

                if (atual == ultimo)
                    ultimo = anterior;

                atual.Prox = null;
                atual = anterior.Prox;
            }
            else
            {
                anterior = atual;
                atual = atual.Prox;
            }
        }
    }

    public void Inverter()
    {
        if (primeiro == ultimo)
            return;

        Celula anterior = null;
        Celula atual = primeiro.Prox;
        ultimo = atual;

        while (atual != null)
        {
            Celula seguinte = atual.Prox;
            atual.Prox = anterior;
            anterior = atual;
            atual = seguinte;
        }

        primeiro.Prox = anterior;
    }

    public void Mostrar()
    {
        Console.Write("[ ");

        for (Celula i = primeiro.Prox; i != null; i = i.Prox)
            Console.Write(i.Elemento + " ");

        Console.WriteLine("]");
    }
}

class Program
{
    static void Main()
    {
        Lista lista = new Lista();
        int opcao = 0;

        do
        {
            Console.WriteLine("\n1 - Inserir um numero na lista");
            Console.WriteLine("2 - Pesquisar um numero na lista");
            Console.WriteLine("3 - Exibir a soma dos numeros");
            Console.WriteLine("4 - Exibir o maior numero");
            Console.WriteLine("5 - Exibir o menor numero");
            Console.WriteLine("6 - Remover todos os numeros pares");
            Console.WriteLine("7 - Exibir os numeros da lista");
            Console.WriteLine("8 - Inverter os elementos da lista");
            Console.WriteLine("9 - Encerrar o programa");
            Console.Write("Opcao: ");

            try
            {
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Numero: ");
                        lista.Inserir(int.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        Console.Write("Numero: ");

                        if (lista.Pesquisar(int.Parse(Console.ReadLine())))
                            Console.WriteLine("Numero encontrado.");
                        else
                            Console.WriteLine("Numero nao encontrado.");

                        break;
                    case 3:
                        Console.WriteLine("Soma: " + lista.Somar());
                        break;
                    case 4:
                        Console.WriteLine("Maior: " + lista.Maior());
                        break;
                    case 5:
                        Console.WriteLine("Menor: " + lista.Menor());
                        break;
                    case 6:
                        lista.RemoverPares();
                        Console.WriteLine("Numeros pares removidos.");
                        break;
                    case 7:
                        lista.Mostrar();
                        break;
                    case 8:
                        lista.Inverter();
                        Console.WriteLine("Lista invertida.");
                        break;
                    case 9:
                        Console.WriteLine("Programa encerrado.");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida.");
                        break;
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
        }
        while (opcao != 9);
    }
}
