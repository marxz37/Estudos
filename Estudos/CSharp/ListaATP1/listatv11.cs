using System;
namespace ListaATP1
{
    public class listatv11
    { 
        public static void Main2(string[] args)
        {
            //Explicação!
            Console.WriteLine("Vamos inverter os números!");

            //Declaração das variaveis
            int numTresDigitos, inversaoUnidade, inversaoDezena, inversaoCentena;
            
            //Entrada do Usuário:
            Console.WriteLine("Escreva um número de até 3 digitos:");
            numTresDigitos = int.Parse(Console.ReadLine());
            
            //Calculos de restos:
            inversaoUnidade = numTresDigitos % 10;
            inversaoCentena = numTresDigitos / 100;
            inversaoDezena = (numTresDigitos / 10) % 10;
            
            //Soma:
            int somaTotal = (inversaoUnidade * 100) + (inversaoDezena * 10) + inversaoCentena;
            
            //Resultados:
            Console.WriteLine($"Entrada do Usuário: {numTresDigitos}");
            Console.WriteLine($"Resultado: {somaTotal}");
            Console.WriteLine($"Resultado dos Números invertidos Unidade: {inversaoUnidade}");
            Console.WriteLine($"Resultado dos Números invertidos Dezena: {inversaoDezena}");
            Console.WriteLine($"Resultado dos Números invertidos Centena: {inversaoCentena}");

            string x = Console.ReadLine();
        }
    }
}  