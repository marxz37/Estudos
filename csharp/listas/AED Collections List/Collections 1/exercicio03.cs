using System;
using System.Collections.Generic;

class Contato
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
}

class Program
{
    static void Main()
    {
        List<Contato> contatos = new List<Contato>();
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
                    Contato novoContato = new Contato();

                    Console.Write("Nome: ");
                    novoContato.Nome = Console.ReadLine();

                    Console.Write("Telefone: ");
                    novoContato.Telefone = Console.ReadLine();

                    Console.Write("E-mail: ");
                    novoContato.Email = Console.ReadLine();

                    contatos.Add(novoContato);
                    Console.WriteLine("Contato adicionado.");
                    break;

                case 2:
                    Console.Write("Digite o nome do contato: ");
                    string nome = Console.ReadLine();
                    Contato contatoEncontrado = null;

                    foreach (Contato contato in contatos)
                    {
                        if (contato.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
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
                        Console.Write("Novo nome: ");
                        contatoEncontrado.Nome = Console.ReadLine();

                        Console.Write("Novo telefone: ");
                        contatoEncontrado.Telefone = Console.ReadLine();

                        Console.Write("Novo e-mail: ");
                        contatoEncontrado.Email = Console.ReadLine();

                        Console.WriteLine("Contato atualizado.");
                    }
                    break;

                case 3:
                    Console.Write("Digite o nome do contato: ");
                    nome = Console.ReadLine();
                    contatoEncontrado = null;

                    foreach (Contato contato in contatos)
                    {
                        if (contato.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
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
                    break;

                case 4:
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
