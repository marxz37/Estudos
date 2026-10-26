using System;
class Livro
{
    private string titulo;
    private string autor;
    private int anoPublicação;
    private string genero;

    public string Titulo { get => titulo; set=> titulo = value;}
    public string Autor { get => autor; set=> autor = value;}
    public int AnoPublicacao { get => anoPublicação; set=> anoPublicação = value;}
    public string Genero { get => genero; set=> genero = value;}

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Título: {Titulo} | Autor: {Autor} | Ano de Publicação: {AnoPublicacao} | Gênero: {Genero}");
    }
    public bool EhFiccao()
    {
        return Genero?.ToLower() == "ficção";
    }

    public Livro(string titulo = "Não Informado", string autor = "Desconhecido", int anoPublicacao = 0, string genero = "Indefinido")
    {
        Titulo = titulo;
        Autor = autor;
        AnoPublicacao = anoPublicacao;
        Genero = genero;
    }
}
class Program
{
    static void Main(string[] arg)
    {
        Livro livro1 = new Livro("1984", "George Orwell", 1949, "Ficção");

        Livro livro2 = new Livro("1984", "George Orwell", 1949);

        livro1.ExibirInformacoes();
        Console.WriteLine($"É ficção: {(livro1.EhFiccao() ? "Sim" : "Não")}\n");

        livro2.ExibirInformacoes();
        Console.WriteLine($"É ficção: {(livro2.EhFiccao() ? "Sim" : "Não")}");
    }
}