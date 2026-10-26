using System; 
class Funcionario
{
    public string Nome { get; private set; }
    public string Cargo { get; private set; }
    public decimal Salario { get; private set; }

    public Funcionario(string nome, string cargo, decimal salario = 1412.00m)
    {
        Nome = nome;
        Cargo = cargo;
        Salario = salario;
    }

    public void MostrarInformacao()
    {
        Console.WriteLine($"Nome: {Nome} | Cargo: {Cargo} | Salario: R${Salario:N2}");
    }
}

class Program
{
    static void Main(string[] arg)
    {
        Funcionario f1 = new Funcionario("João","Pedreiro");
        f1.MostrarInformacao();

        Funcionario f2 = new Funcionario("Maria","Gerente de Obras",40000m);
        f2.MostrarInformacao();
    }
}