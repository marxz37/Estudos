using System;
class Aluno
{
    private string nome;
    private int matricula;
    private double[] notas;

    public string Nome { get => nome; set=> nome = value;}
    public int Matricula { get => matricula; set=> matricula = value;}

    public double CalcularMedia()
    {
        if (notas.Length == 0)
        {
            Console.WriteLine("Vetor de notas vazio!");
            return 0;
        }

        double soma = 0;

        for(int i = 0; i < notas.Length; i++)
        {
            soma += notas[i];
        }

        return soma / notas.Length;
    }

    public Aluno(string nome, int matricula, double[] notas)
    {
        Nome = nome;
        Matricula = matricula;
        this.notas = notas;
    }
}
class Program
{
    static void Main(string[] arg)
    {
        Console.WriteLine("Digite seu nome: ");
        string? nome = Console.ReadLine();

        Console.WriteLine("Digite sua matrícula: ");
        int matricula = int.Parse(Console.ReadLine());

        Console.WriteLine("Quantidade de provas: ");
        int quantidadeProvas = int.Parse(Console.ReadLine());

        double[] notas = new double[quantidadeProvas];

        for(int i = 0; i < quantidadeProvas; i++)
        {
            Console.WriteLine($"Valor da nota {i+1}: ");
            notas[i] = double.Parse(Console.ReadLine());
        }

        Aluno aluno = new Aluno(nome,matricula,notas);

        double media = aluno.CalcularMedia();

        Console.WriteLine($"Aluno: {aluno.Nome} | Matrícula: {aluno.Matricula} | obteve a média: {media}");
    }
}