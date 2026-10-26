using System;
class Retangulo
{
    private double largura;
    private double altura;

    public double Largura { get => largura; set => largura = value; }
    public double Altura { get => altura; set => altura = value; }

    public double CalcularArea()
    {
        return Largura * Altura;
    }

    public double CalcularPerimetro()
    {
        return 2 * (Largura + Altura);
    }

    public Retangulo(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Retangulo r1 = new Retangulo(4, 2);

        double areaR1 = r1.CalcularArea();       
        double perimetroR1 = r1.CalcularPerimetro(); 

        Console.WriteLine($"Área do retângulo: {areaR1} \nPerímetro do retângulo: {perimetroR1}");
    }
}