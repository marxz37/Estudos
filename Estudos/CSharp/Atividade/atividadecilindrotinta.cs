using System;
namespace CSharp
{
    public class atividadecilindrotinta
{
    public static void Main3(string[] args)
    {
        // valores
        const double pi = 3.14;
        double r , h;

        Console.WriteLine("Vamos calcular a quantidade de latas de tinta necessárias e o custo para pintar tanques cilíndricos de combustível!");
        Console.WriteLine("Qual é o raio?");
        r = Double.Parse(Console.ReadLine());
        Console.WriteLine("Qual é a altura?");
        h = Double.Parse(Console.ReadLine());

        //exemplos para eu entender:
        //const double r = 2;
        //const double h = 4;
        
        //area da base
        double areaBase;
        double b;
        b = Math.Pow(r,2);
        areaBase = pi * b;
        Console.WriteLine($"Area da Base: {areaBase}m²");
        
        //area da lateral
        double areaLateral;
        areaLateral = 2 * (r * h);
        areaLateral = areaLateral * pi;
        Console.WriteLine($"Area da Lateral: {areaLateral}m²");
        
        //area total
        double d;
        double areaTotal;
        d = areaBase + areaBase;
        areaTotal = d + areaLateral;

        //calculo de gasto
        const double litroMetros = 3;
        const double litrosLata = 5;
        const double tintaPreco = 50;
        double latas , totalPreco , totalLitros;
        double totaLatas;
        
        totaLatas = (areaTotal / litroMetros) / litrosLata;
        double arredondado_Total_Latas = Math.Ceiling(totaLatas);
        totalPreco = arredondado_Total_Latas * tintaPreco;
        totalLitros = arredondado_Total_Latas * litrosLata;

        

        Console.WriteLine($"Area Total: {areaTotal}m²");
        Console.WriteLine($"Total de Latas: {arredondado_Total_Latas}");
        Console.WriteLine($"Total de Litros: {totalLitros}l");
        Console.WriteLine($"Total de Gasto: {totalPreco:C}");

        /* 
           exemplos para eu entender:
           const double r = 2;
           const double h = 4;

           Cada lata de tinta custa R$50,00
           Cada lata contem 5 litros
           Cada litro de tinta pinta 3m

           Total de litros: 30 litros
           Total de gasto: R$300
           Total de Latas: 6 latas de tintas
           Total de metros: 75.36m²
        */
    }
}
}
