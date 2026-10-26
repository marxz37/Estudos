using System; 
class Triangulo
{
    private double lado1;
    private double lado2;
    private double lado3;

    public double Lado1 { get => lado1; set => lado1 = value; }
    public double Lado2 { get => lado2; set => lado2 = value; }
    public double Lado3 { get => lado3; set => lado3 = value; }

    public Triangulo(double lado1, double lado2, double lado3)
    {
        Lado1 = lado1;
        Lado2 = lado2;
        Lado3 = lado3;
    }

    public Triangulo()
    {
        Lado1 = 1;
        Lado2 = 2;
        Lado3 = 3;
    }

    public void MostrarValores()
    {
        Console.WriteLine($"Valor do Triângulo: Lado 1: {Lado1} | Lado 2: {Lado2} | Lado 3: {Lado3}");
    }
}

class Program
{
    static void Main(string[] arg)
    {
        Triangulo t1 = new Triangulo(4,5,6);
        Triangulo t2 = new Triangulo();

        t1.MostrarValores();
        t2.MostrarValores();
    }
}