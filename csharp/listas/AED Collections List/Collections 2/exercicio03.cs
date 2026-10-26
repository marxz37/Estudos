using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        SortedList<int, string> ranking = new SortedList<int, string>();

        int opcao;

        do
        {
            Console.WriteLine("1 - Adicionar jogador");
            Console.WriteLine("2 - Verificar pontuação de um jogador");
            Console.WriteLine("3 - Remover jogador");
            Console.WriteLine("4 - Exibir ranking");
            Console.WriteLine("0 - Sair");
            
            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o nome do jogador: ");
                    string nome = Console.ReadLine()!;

                    Console.Write("Digite a pontuação: ");
                    int pontuacao = int.Parse(Console.ReadLine()!);

                    if (ranking.ContainsKey(pontuacao))
                    {
                        Console.WriteLine("Essa pontuação já está sendo usada!");
                    }
                    else
                    {
                        ranking.Add(pontuacao, nome);
                        Console.WriteLine("Jogador adicionado!");
                    }

                    break;

                case 2:
                    Console.Write("Digite o nome do jogador: ");
                    string jogadorProcurado = Console.ReadLine()!;

                    bool encontrado = false;

                    foreach (KeyValuePair<int, string> jogador in ranking)
                    {
                        if (jogador.Value == jogadorProcurado)
                        {
                            Console.WriteLine(
                                $"O jogador {jogador.Value} tem {jogador.Key} pontos."
                            );

                            encontrado = true;
                            break;
                        }
                    }

                    if (!encontrado)
                    {
                        Console.WriteLine("Jogador não encontrado!");
                    }

                    break;

                case 3:
                    Console.Write("Digite o nome do jogador que deseja remover: ");
                    string jogadorRemover = Console.ReadLine()!;

                    int pontuacaoRemover = -1;

                    foreach (KeyValuePair<int, string> jogador in ranking)
                    {
                        if (jogador.Value == jogadorRemover)
                        {
                            pontuacaoRemover = jogador.Key;
                            break;
                        }
                    }

                    if (pontuacaoRemover != -1)
                    {
                        ranking.Remove(pontuacaoRemover);
                        Console.WriteLine("Jogador removido!");
                    }
                    else
                    {
                        Console.WriteLine("Jogador não encontrado!");
                    }

                    break;

                case 4:
                    Console.WriteLine("\n===== RANKING =====");

                    foreach (KeyValuePair<int, string> jogador in ranking)
                    {
                        Console.WriteLine(
                            $"{jogador.Value} - {jogador.Key} pontos"
                        );
                    }

                    break;

                case 0:
                    Console.WriteLine("Programa encerrado.");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 0);
    }
}
