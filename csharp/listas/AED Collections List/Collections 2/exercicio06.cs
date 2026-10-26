using System;
using System.Collections.Generic;

class Contato
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }

    public Contato(string nome, string telefone, string email)
    {
        Nome = nome;
        Telefone = telefone;
        Email = email;
    }
}

class Program
{
    static void Main()
    {
        LinkedList<Contato> contatos = new LinkedList<Contato>();
        int opcao = 0;

        while (opcao != 5)
        {
            Console.WriteLine("\n1 - Adicionar contato");
            Console.WriteLine("2 - Atualizar contato");
            Console.WriteLine("3 - Excluir contato");
            Console.WriteLine("4 - Listar contatos");
            Console.WriteLine("5 - Encerrar o programa");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    AdicionarContato(contatos);
                    break;

                case 2:
                    AtualizarContato(contatos);
                    break;

                case 3:
                    ExcluirContato(contatos);
                    break;

                case 4:
                    ListarContatos(contatos);
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

    static void AdicionarContato(LinkedList<Contato> contatos)
    {
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();
        Console.Write("Digite o telefone: ");
        string telefone = Console.ReadLine();
        Console.Write("Digite o e-mail: ");
        string email = Console.ReadLine();

        Contato contato = new Contato(nome, telefone, email);
        contatos.AddLast(contato);
        Console.WriteLine("Contato adicionado.");
    }

    static void AtualizarContato(LinkedList<Contato> contatos)
    {
        Console.Write("Digite o nome do contato que deseja atualizar: ");
        string nome = Console.ReadLine();
        bool encontrado = false;

        foreach (Contato contato in contatos)
        {
            if (contato.Nome.ToLower() == nome.ToLower())
            {
                Console.Write("Digite o novo nome: ");
                contato.Nome = Console.ReadLine();
                Console.Write("Digite o novo telefone: ");
                contato.Telefone = Console.ReadLine();
                Console.Write("Digite o novo e-mail: ");
                contato.Email = Console.ReadLine();
                encontrado = true;
                Console.WriteLine("Contato atualizado.");
                break;
            }
        }

        if (!encontrado)
            Console.WriteLine("Contato não encontrado.");
    }

    static void ExcluirContato(LinkedList<Contato> contatos)
    {
        Console.Write("Digite o nome do contato que deseja excluir: ");
        string nome = Console.ReadLine();
        Contato contatoEncontrado = null;

        foreach (Contato contato in contatos)
        {
            if (contato.Nome.ToLower() == nome.ToLower())
            {
                contatoEncontrado = contato;
                break;
            }
        }

        if (contatoEncontrado == null)
        {
            Console.WriteLine("Contato não encontrado.");
        }
        else
        {
            contatos.Remove(contatoEncontrado);
            Console.WriteLine("Contato excluído.");
        }
    }

    static void ListarContatos(LinkedList<Contato> contatos)
    {
        if (contatos.Count == 0)
        {
            Console.WriteLine("A agenda está vazia.");
        }
        else
        {
            foreach (Contato contato in contatos)
            {
                Console.WriteLine("\nNome: " + contato.Nome);
                Console.WriteLine("Telefone: " + contato.Telefone);
                Console.WriteLine("E-mail: " + contato.Email);
            }
        }
    }
}
