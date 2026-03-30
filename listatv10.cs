using System;
class listatv10
{
    static void Main(string[] arg)
    {
        double nota = 112;
        double media = 0;
        double somanota = 0;
        int cont = 0;

        while(nota >= 0)
        {
            Console.WriteLine("Escreva a nota da prova (ou um valor negativo para calcular a média e sair):");
            nota = double.Parse(Console.ReadLine());

            if(nota < 0)
            {
                Console.WriteLine($"Média: {media}");
                break;
            }
            cont++;
            somanota += nota;
            media = somanota / cont;

            Console.WriteLine($"Média: {media}");
        }
    }
}