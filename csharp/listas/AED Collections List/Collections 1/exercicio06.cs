using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<int> filaIniciacaoCientifica = new Queue<int>();
        Queue<int> filaMestrado = new Queue<int>();
        int opcao = 0;

        while (opcao != 11)
        {
            Console.WriteLine("\n1 - Inserir aluno na fila de Iniciação Científica");
            Console.WriteLine("2 - Inserir aluno na fila de Mestrado");
            Console.WriteLine("3 - Remover aluno da fila de Iniciação Científica");
            Console.WriteLine("4 - Remover aluno da fila de Mestrado");
            Console.WriteLine("5 - Mostrar fila de Iniciação Científica");
            Console.WriteLine("6 - Mostrar fila de Mestrado");
            Console.WriteLine("7 - Pesquisar aluno na fila de Iniciação Científica");
            Console.WriteLine("8 - Pesquisar aluno na fila de Mestrado");
            Console.WriteLine("9 - Mostrar o primeiro aluno da fila de Iniciação Científica");
            Console.WriteLine("10 - Mostrar o primeiro aluno da fila de Mestrado");
            Console.WriteLine("11 - Encerrar o programa");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    InserirAluno(filaIniciacaoCientifica, filaMestrado);
                    break;

                case 2:
                    InserirAluno(filaMestrado, filaIniciacaoCientifica);
                    break;

                case 3:
                    RemoverAluno(filaIniciacaoCientifica);
                    break;

                case 4:
                    RemoverAluno(filaMestrado);
                    break;

                case 5:
                    MostrarFila(filaIniciacaoCientifica);
                    break;

                case 6:
                    MostrarFila(filaMestrado);
                    break;

                case 7:
                    PesquisarAluno(filaIniciacaoCientifica);
                    break;

                case 8:
                    PesquisarAluno(filaMestrado);
                    break;

                case 9:
                    MostrarPrimeiroAluno(filaIniciacaoCientifica);
                    break;

                case 10:
                    MostrarPrimeiroAluno(filaMestrado);
                    break;

                case 11:
                    Console.WriteLine("Programa encerrado.");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }

    static void InserirAluno(Queue<int> fila, Queue<int> outraFila)
    {
        Console.Write("Digite o código do aluno: ");
        int codigo = int.Parse(Console.ReadLine());

        if (fila.Contains(codigo) || outraFila.Contains(codigo))
        {
            Console.WriteLine("Esse código já está em uma fila.");
        }
        else
        {
            fila.Enqueue(codigo);
            Console.WriteLine("Aluno inserido na fila.");
        }
    }

    static void RemoverAluno(Queue<int> fila)
    {
        if (fila.Count == 0)
        {
            Console.WriteLine("A fila está vazia.");
        }
        else
        {
            int codigo = fila.Dequeue();
            Console.WriteLine("Aluno removido: " + codigo);
        }
    }

    static void MostrarFila(Queue<int> fila)
    {
        if (fila.Count == 0)
        {
            Console.WriteLine("A fila está vazia.");
        }
        else
        {
            Console.WriteLine("Alunos na fila:");

            foreach (int codigo in fila)
                Console.WriteLine(codigo);
        }
    }

    static void PesquisarAluno(Queue<int> fila)
    {
        Console.Write("Digite o código do aluno: ");
        int codigo = int.Parse(Console.ReadLine());

        if (fila.Contains(codigo))
            Console.WriteLine("O aluno está na fila.");
        else
            Console.WriteLine("O aluno não está na fila.");
    }

    static void MostrarPrimeiroAluno(Queue<int> fila)
    {
        if (fila.Count == 0)
            Console.WriteLine("A fila está vazia.");
        else
            Console.WriteLine("Primeiro aluno: " + fila.Peek());
    }
}
