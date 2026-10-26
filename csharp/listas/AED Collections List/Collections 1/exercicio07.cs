using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> fila = new Queue<string>();
        int opcao = 0;

        while (opcao != 5)
        {
            Console.WriteLine("\n1 - Adicionar cliente à fila");
            Console.WriteLine("2 - Atender cliente");
            Console.WriteLine("3 - Exibir o número de clientes na fila");
            Console.WriteLine("4 - Exibir o próximo cliente");
            Console.WriteLine("5 - Encerrar o programa");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Nome do cliente: ");
                    string cliente = Console.ReadLine();
                    fila.Enqueue(cliente);
                    Console.WriteLine("Cliente adicionado à fila.");
                    break;

                case 2:
                    if (fila.Count == 0)
                    {
                        Console.WriteLine("A fila está vazia.");
                    }
                    else
                    {
                        cliente = fila.Dequeue();
                        Console.WriteLine("Cliente atendido: " + cliente);
                    }
                    break;

                case 3:
                    Console.WriteLine("Número de clientes na fila: " + fila.Count);
                    break;

                case 4:
                    if (fila.Count == 0)
                        Console.WriteLine("A fila está vazia.");
                    else
                        Console.WriteLine("Próximo cliente: " + fila.Peek());
                    break;

                case 5:
                    Console.WriteLine("Programa encerrado.");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
