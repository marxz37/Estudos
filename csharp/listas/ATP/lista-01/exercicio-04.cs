using System;
namespace ListaATP1
{
    class listatv4
    {
        static void Main2(string[] arg)
        {    
            //Declaração das variaveis:
            double altura, baseRetangulo;

            //Entrada do Usuário:
            Console.WriteLine("Escreva o valor da Base:");
            baseRetangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o valor da Altura:");
            altura = double.Parse(Console.ReadLine());

            //Declaração das variaveis:
            double perimetro, area, diagonalPotenciacao, diagonalPotenciacao2, diagonalRaiz, diagonalTotal;

            //Calculos:
            perimetro = 2 * (baseRetangulo + altura);
            area = baseRetangulo * altura;
            
            diagonalTotal = Math.Sqrt(Math.Pow(baseRetangulo, 2) + Math.Pow(altura, 2));
            
            //Bloquear o usuario de digitar número negativo!
            if(baseRetangulo < 0 || altura < 0)
            {
                Console.WriteLine("Coloque números positivos!");
            }
            else
            {
            //entrada
            Console.WriteLine("Entrada do usuário 1:{0}", baseRetangulo);
            Console.WriteLine("Entrada do usuário 2:{0}", altura);
            //Resultados:
            Console.WriteLine($"Base: {baseRetangulo}");
            Console.WriteLine($"Altura:{altura}");
            Console.WriteLine($"Perímetro: {perimetro}");
            Console.WriteLine($"Área: {area}");
            Console.WriteLine($"Diagonal: {diagonalTotal}");
            }

            string x = (Console.ReadLine());
        }
    }
}