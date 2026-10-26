using System;
class Livro 
{
    private string tituloLivro;
    private string autor;
    private int anoPublicacao;
    private int numeroPaginas;
    private string status;

    public string TituloLivro { get => tituloLivro; set => tituloLivro = value; }
    public string Autor { get => autor; set => autor = value; }
    public int AnoPublicacao { get => anoPublicacao; set => anoPublicacao = value; }
    public int NumeroPaginas { get => numeroPaginas; set => numeroPaginas = value; }
    public string Status { get => status; set => status = value; }

    public Livro(string tituloLivro, string autor, int anoPublicacao, int numeroPaginas)
    {
        TituloLivro = tituloLivro;
        Autor = autor;
        AnoPublicacao = anoPublicacao;
        NumeroPaginas = numeroPaginas;
        Status = "Disponivel";
    }

    public void StatusEmprestado()
    {
        Status = "Emprestado";
        Console.WriteLine("Livro alterado para Emprestado!");
    }

    public void StatusDisponivel()
    {
        Status = "Disponivel";
        Console.WriteLine($"Livro alterado para Disponível!");
    }
    public string InformacoesLivro()
    {
        return $"Titulo: {TituloLivro} | Autor: {Autor} | Ano Publicação: {AnoPublicacao} | Número de Páginas: {NumeroPaginas} | Status: {Status}";
    }
}

class Cliente 
{
    private string nome;
    private int numeroIdentificacao;
    private Livro[] livrosEmprestados = new Livro[50];
    int quantidade = 0;

    public string Nome { get => nome; set => nome = value; }
    public int NumeroIdentificacao { get => numeroIdentificacao; set => numeroIdentificacao = value; }

    public Cliente(string nome, int numeroIdentificacao)
    {
        Nome = nome;
        NumeroIdentificacao = numeroIdentificacao;
    }

    public void EmprestarLivro(Livro livro)
    {
        if(quantidade == 50)
        {
            Console.WriteLine("Limite de livros emprestado alcançado!");
        }
        else
        {
            bool checkEmpretado = false;
            for(int i = 0; i < livrosEmprestados.Length; i++)
            {
                if(livrosEmprestados[i] == null)
                {
                    if(livro.Status == "Emprestado")
                    {
                        Console.WriteLine("Livro já emprestado!");
                        checkEmpretado = true;
                        break;
                    }
                    livrosEmprestados[i] = livro;
                    livro.StatusEmprestado();
                    quantidade++;
                    break;
                }
            }
            if(!checkEmpretado)
            {
                Console.WriteLine("Livro Emprestado!");
            }
        }
    }
    public void DevolverLivro(Livro livro)
    {
        int pos = 0;
        bool verificacao = false;
        
        for (int i = 0; i < livrosEmprestados.Length; i++)
        {
            if(livro == livrosEmprestados[i])
            {
                pos = i;
                verificacao = true;
            }
        }

        if (verificacao)
        {
            Array.Clear(livrosEmprestados, pos, 1);
            livro.StatusDisponivel();
            quantidade--;
            Console.WriteLine("Livro Disponivel!");
        }
        else
            Console.WriteLine("Livro não encontrado!");
    }
    public string InformacoesCliente()
    {
        string texto = $"Cliente: {Nome} | Número de Identificação: {NumeroIdentificacao}\nLivros Emprestados:";
        foreach(var livro in livrosEmprestados)
        {
            if(livro != null)
                texto += $"\n{livro.InformacoesLivro()}";
        }
        return texto;
    }
}

class Biblioteca  
{
    private Livro[] listaLivros = new Livro[50];
    private Cliente[] listaCliente = new Cliente[50];
    int quantidadeLivros = 0;
    int quantidadeCliente = 0;
    public void NovoLivroALista(Livro livro)
    {
        if(quantidadeLivros == 50)
        {
            Console.WriteLine("Limite de livros emprestado alcançado!");
        }
        else
        {
            for(int i = 0; i < listaLivros.Length; i++)
            {
                if(listaLivros[i] == null)
                {
                    listaLivros[i] = livro;
                    Console.WriteLine("Livro adicionado a lista!");
                    quantidadeLivros++;
                    break;
                }
            }
        }
    }
    public void RemoverLivroDaLista(Livro livro)
    {
        bool verif = false;
        for(int i = 0; i < listaLivros.Length; i++)
        {
            if(listaLivros[i] == livro)
            {
                verif = true;
                Console.WriteLine("Livro removido da lista!");
                quantidadeLivros--;
                Array.Clear(listaLivros, i, 1);
                break;
            }
        }
        if(!verif)
        {
            Console.WriteLine("Livros não encontrado!");
        }
    }
    public void RegistrarNovoCliente(Cliente cliente)
    {
        if(quantidadeCliente == 50)
        {
            Console.WriteLine("Limite de cliente alcançado!");
        }
        else
        {
            for(int i = 0; i < listaCliente.Length; i++)
            {
                if(listaCliente[i] == null)
                {
                    Console.WriteLine("Cliente adicionado!");
                    quantidadeCliente++;
                    listaCliente[i] = cliente;
                    break;
                }
            }
        }
    }
    public void RemoverCliente(Cliente cliente)
    {
        bool verif = false;
        for(int i = 0; i < listaCliente.Length; i++)
        {
            if(listaCliente[i] == cliente)
            {
                verif = true;
                Console.WriteLine("Cliente removido!");
                quantidadeCliente--;
                Array.Clear(listaCliente, i, 1);
                break;
            }
        }
        if(!verif)
        {
            Console.WriteLine("Cliente não encontrado!");
        }
    }
    public void ExibirLivrosDisponiveis()
    {
        foreach(var livro in listaLivros)
        {
            if(livro != null)
                Console.WriteLine($"{livro.InformacoesLivro()}");
        }
    }

    public void ExibirListaClientes()
    {
        foreach(var cliente in listaCliente)
        {
            if(cliente != null)
                Console.WriteLine($"{cliente.InformacoesCliente()}");
        }
    }

    public Biblioteca()
    {
        
    }
}

class Program
{
    static void Main(string[] arg)
    {
        Biblioteca biblioteca = new Biblioteca();

        Console.WriteLine("=== SIMULAÇÃO DO SISTEMA DE BIBLIOTECA ===\n");

        Livro l1 = new Livro("O Senhor dos Anéis", "J.R.R. Tolkien", 1954, 1200);
        Livro l2 = new Livro("1984", "George Orwell", 1949, 328);
        Livro l3 = new Livro("Dom Casmurro", "Machado de Assis", 1899, 256);

        biblioteca.NovoLivroALista(l1);
        biblioteca.NovoLivroALista(l2);
        biblioteca.NovoLivroALista(l3);

        Cliente c1 = new Cliente("Marx Bento", 101);
        Cliente c2 = new Cliente("Maria Silva", 102);

        Console.WriteLine();
        biblioteca.RegistrarNovoCliente(c1);
        biblioteca.RegistrarNovoCliente(c2);

        biblioteca.ExibirLivrosDisponiveis();

        Console.WriteLine("\n--- SIMULANDO EMPRÉSTIMOS ---");
        c1.EmprestarLivro(l1); 
        c2.EmprestarLivro(l2); 
        c2.EmprestarLivro(l1); 

        Console.WriteLine("\n--- LISTA DA BIBLIOTECA ---");
        biblioteca.ExibirListaClientes();
        biblioteca.ExibirLivrosDisponiveis();

        Console.WriteLine("\n--- SIMULANDO DEVOLUÇÃO ---");
        c1.DevolverLivro(l1); 

        biblioteca.ExibirLivrosDisponiveis();

        Console.WriteLine("\n--- REMOÇÃO DE REGISTROS ---");
        biblioteca.RemoverLivroDaLista(l3);
        biblioteca.RemoverCliente(c2);

        biblioteca.ExibirListaClientes();
    }
}