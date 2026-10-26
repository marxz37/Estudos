using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>();
        int opcao = 0;

        while (opcao != 9)
        {
            Console.WriteLine("\n1 - Inserir um número na lista");
            Console.WriteLine("2 - Verificar se um número está na lista");
            Console.WriteLine("3 - Exibir a soma dos números");
            Console.WriteLine("4 - Exibir o maior número");
            Console.WriteLine("5 - Exibir o menor número");
            Console.WriteLine("6 - Remover todos os números pares");
            Console.WriteLine("7 - Exibir os números da lista");
            Console.WriteLine("8 - Inverter os elementos da lista");
            Console.WriteLine("9 - Encerrar o programa");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite um número inteiro: ");
                    int numero = int.Parse(Console.ReadLine());
                    numeros.Add(numero);
                    Console.WriteLine("Número inserido.");
                    break;

                case 2:
                    Console.Write("Digite o número que deseja procurar: ");
                    numero = int.Parse(Console.ReadLine());

                    if (numeros.Contains(numero))
                        Console.WriteLine("O número está na lista.");
                    else
                        Console.WriteLine("O número não está na lista.");
                    break;

                case 3:
                    int soma = 0;

                    foreach (int valor in numeros)
                        soma += valor;

                    Console.WriteLine("Soma: " + soma);
                    break;

                case 4:
                    if (numeros.Count == 0)
                    {
                        Console.WriteLine("A lista está vazia.");
                    }
                    else
                    {
                        int maior = numeros[0];

                        foreach (int valor in numeros)
                        {
                            if (valor > maior)
                                maior = valor;
                        }

                        Console.WriteLine("Maior número: " + maior);
                    }
                    break;

                case 5:
                    if (numeros.Count == 0)
                    {
                        Console.WriteLine("A lista está vazia.");
                    }
                    else
                    {
                        int menor = numeros[0];

                        foreach (int valor in numeros)
                        {
                            if (valor < menor)
                                menor = valor;
                        }

                        Console.WriteLine("Menor número: " + menor);
                    }
                    break;

                case 6:
                    numeros.RemoveAll(valor => valor % 2 == 0);
                    Console.WriteLine("Números pares removidos.");
                    break;

                case 7:
                    if (numeros.Count == 0)
                    {
                        Console.WriteLine("A lista está vazia.");
                    }
                    else
                    {
                        Console.WriteLine("Números da lista:");

                        foreach (int valor in numeros)
                            Console.WriteLine(valor);
                    }
                    break;

                case 8:
                    numeros.Reverse();
                    Console.WriteLine("A lista foi invertida.");
                    break;

                case 9:
                    Console.WriteLine("Programa encerrado.");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
