using System;
class Exercicio11
{
    static void ConverterSegundos(int totalSegundos, out int hora, out int min, out int seg)
    {
        hora = totalSegundos / 3600;
        min = (totalSegundos % 3600) / 60;
        seg = totalSegundos % 60;
    }

    static void Main(string[] args)
    {
        Console.Write("Digite o total de segundos: ");
        int totalSegundos = int.Parse(Console.ReadLine());

        while (totalSegundos < 0)
        {
            Console.Write("Valor inválido! O tempo em segundos não pode ser negativo. Digite novamente: ");
            totalSegundos = int.Parse(Console.ReadLine());
        }

        int hora, min, seg;
        ConverterSegundos(totalSegundos, out hora, out min, out seg);

        Console.WriteLine($"\nResultado formatado: {hora.ToString("D2")}:{min.ToString("D2")}:{seg.ToString("D2")}");
    }
}