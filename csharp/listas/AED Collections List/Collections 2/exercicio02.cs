using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>();
        Dictionary<int, int> frequencias = new Dictionary<int, int>();

        Console.Write("Digite a quantidade de números da lista: ");
        int quantidade = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());
            numeros.Add(numero);
        }

        foreach (int numero in numeros)
        {
            if (frequencias.ContainsKey(numero))
                frequencias[numero]++;
            else
                frequencias.Add(numero, 1);
        }

        int opcao = 0;

        while (opcao != 4)
        {
            Console.WriteLine("\n1 - Verificar se um número consta no dicionário");
            Console.WriteLine("2 - Consultar a quantidade de números distintos");
            Console.WriteLine("3 - Exibir os números e suas frequências");
            Console.WriteLine("4 - Encerrar o programa");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o número que deseja procurar: ");
                    int numero = int.Parse(Console.ReadLine());

                    if (frequencias.ContainsKey(numero))
                        Console.WriteLine("O número consta no dicionário.");
                    else
                        Console.WriteLine("O número não consta no dicionário.");
                    break;

                case 2:
                    Console.WriteLine("Quantidade de números distintos: " + frequencias.Count);
                    break;

                case 3:
                    if (frequencias.Count == 0)
                    {
                        Console.WriteLine("O dicionário está vazio.");
                    }
                    else
                    {
                        foreach (KeyValuePair<int, int> item in frequencias)
                            Console.WriteLine(item.Key + " aparece " + item.Value + " vez(es).");
                    }
                    break;

                case 4:
                    Console.WriteLine("Programa encerrado.");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
