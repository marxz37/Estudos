using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        SortedList<string, List<string>> dicionario = new SortedList<string, List<string>>();
        int opcao = 0;

        while (opcao != 4)
        {
            Console.WriteLine("\n1 - Adicionar uma palavra e seus sinônimos");
            Console.WriteLine("2 - Pesquisar os sinônimos de uma palavra");
            Console.WriteLine("3 - Exibir o dicionário em ordem alfabética");
            Console.WriteLine("4 - Encerrar o programa");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite a palavra: ");
                    string palavra = Console.ReadLine().ToLower();

                    if (dicionario.ContainsKey(palavra))
                    {
                        Console.WriteLine("A palavra já existe no dicionário.");
                    }
                    else
                    {
                        List<string> sinonimos = new List<string>();

                        Console.Write("Digite a quantidade de sinônimos: ");
                        int quantidade = int.Parse(Console.ReadLine());

                        for (int i = 0; i < quantidade; i++)
                        {
                            Console.Write("Digite um sinônimo: ");
                            sinonimos.Add(Console.ReadLine());
                        }

                        dicionario.Add(palavra, sinonimos);
                        Console.WriteLine("Palavra adicionada.");
                    }
                    break;

                case 2:
                    Console.Write("Digite a palavra que deseja pesquisar: ");
                    palavra = Console.ReadLine().ToLower();

                    if (dicionario.ContainsKey(palavra))
                    {
                        Console.WriteLine("Sinônimos de " + palavra + ":");

                        foreach (string sinonimo in dicionario[palavra])
                            Console.WriteLine(sinonimo);
                    }
                    else
                    {
                        Console.WriteLine("A palavra não consta no dicionário.");
                    }
                    break;

                case 3:
                    if (dicionario.Count == 0)
                    {
                        Console.WriteLine("O dicionário está vazio.");
                    }
                    else
                    {
                        foreach (KeyValuePair<string, List<string>> item in dicionario)
                        {
                            Console.WriteLine("\n" + item.Key + ":");

                            foreach (string sinonimo in item.Value)
                                Console.WriteLine(sinonimo);
                        }
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
