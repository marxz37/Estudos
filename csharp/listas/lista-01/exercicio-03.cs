using System;
namespace ListaATP1
{
    class listatv3
    {
        static void Main2(string[] arg)
        {
            //Entrada do Usuário:
            Console.WriteLine("Escreva o valor do lateral do quadrado:");
            double userNumber = double.Parse(Console.ReadLine());
            double perimetro, area, diagonal, lado;

            //Calculos:
            lado = userNumber;
            perimetro = userNumber * 4;
            area = Math.Pow(userNumber, 2);
            diagonal = lado * Math.Sqrt(2);

            //Bloquear o usuario de digitar número negativo!
            if(userNumber < 0)
            {
                Console.WriteLine("Coloque números positivos!");
            }
            else
            {
            //entrada
            Console.WriteLine("Entrada do Usuario: {0}", userNumber);
            //Resultados:
            Console.WriteLine($"Lado: {lado}");
            Console.WriteLine($"Perimetro: {perimetro}");
            Console.WriteLine($"Área: {area}");
            Console.WriteLine($"Diagonal: {diagonal:F5}");
            }

            string x = (Console.ReadLine());
        }
    }
}