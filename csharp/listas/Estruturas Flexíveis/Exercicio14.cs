using System;

class Contato
{
    private string nome;
    private string telefone;
    private string email;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string Telefone
    {
        get { return telefone; }
        set { telefone = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public Contato(string nome, string telefone, string email)
    {
        this.nome = nome;
        this.telefone = telefone;
        this.email = email;
    }
}

class Celula
{
    private Contato elemento;
    private Celula ant;
    private Celula prox;

    public Contato Elemento
    {
        get { return elemento; }
        set { elemento = value; }
    }

    public Celula Ant
    {
        get { return ant; }
        set { ant = value; }
    }

    public Celula Prox
    {
        get { return prox; }
        set { prox = value; }
    }

    public Celula(Contato elemento)
    {
        this.elemento = elemento;
        ant = null;
        prox = null;
    }

    public Celula()
    {
        elemento = null;
        prox = null;
        ant = null;
    }
}

class ListaDupla
{
    private Celula primeiro;
    private Celula ultimo;

    public ListaDupla()
    {
        primeiro = new Celula();
        ultimo = primeiro;
    }

    private Celula Buscar(string nome)
    {
        if (nome == null)
        {
            return null;
        }

        nome = nome.Trim();
        for (Celula atual = primeiro.Prox; atual != null; atual = atual.Prox)
        {
            if (atual.Elemento.Nome.ToLower() == nome.ToLower())
            {
                return atual;
            }
        }
        return null;
    }

    public bool Existe(string nome)
    {
        return Buscar(nome) != null;
    }

    public bool Adicionar(string nome, string telefone, string email)
    {
        if (nome == null || nome.Trim() == "" ||
            telefone == null || telefone.Trim() == "" ||
            email == null || email.Trim() == "" || Existe(nome))
        {
            return false;
        }

        Contato contato = new Contato(nome.Trim(), telefone.Trim(), email.Trim());
        Celula nova = new Celula(contato);
        nova.Ant = ultimo;
        ultimo.Prox = nova;
        ultimo = nova;
        return true;
    }

    public bool Atualizar(string nome, string novoNome, string telefone, string email)
    {
        Celula atual = Buscar(nome);
        if (atual == null || novoNome == null || novoNome.Trim() == "" ||
            telefone == null || telefone.Trim() == "" ||
            email == null || email.Trim() == "")
        {
            return false;
        }

        Celula outro = Buscar(novoNome);
        if (outro != null && outro != atual)
        {
            return false;
        }

        atual.Elemento.Nome = novoNome.Trim();
        atual.Elemento.Telefone = telefone.Trim();
        atual.Elemento.Email = email.Trim();
        return true;
    }

    public bool Excluir(string nome)
    {
        Celula removida = Buscar(nome);
        if (removida == null)
        {
            return false;
        }

        removida.Ant.Prox = removida.Prox;
        if (removida.Prox != null)
        {
            removida.Prox.Ant = removida.Ant;
        }
        else
        {
            ultimo = removida.Ant;
        }

        removida.Ant = null;
        removida.Prox = null;
        return true;
    }

    public void Listar()
    {
        if (primeiro == ultimo)
        {
            Console.WriteLine("A agenda está vazia.");
            return;
        }

        for (Celula atual = primeiro.Prox; atual != null; atual = atual.Prox)
        {
            Console.WriteLine("Nome: " + atual.Elemento.Nome);
            Console.WriteLine("Telefone: " + atual.Elemento.Telefone);
            Console.WriteLine("E-mail: " + atual.Elemento.Email);
            Console.WriteLine();
        }
    }
}

class Program
{
    static string LerTexto(string mensagem)
    {
        Console.Write(mensagem);
        string texto = Console.ReadLine();
        while (texto != null && texto.Trim() == "")
        {
            Console.Write("O campo não pode ficar vazio. Digite novamente: ");
            texto = Console.ReadLine();
        }
        if (texto == null)
        {
            return null;
        }
        return texto.Trim();
    }

    static void Main()
    {
        ListaDupla agenda = new ListaDupla();

        while (true)
        {
            Console.WriteLine("1 - Adicionar contato");
            Console.WriteLine("2 - Atualizar contato");
            Console.WriteLine("3 - Excluir contato");
            Console.WriteLine("4 - Listar contatos");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha: ");

            string entrada = Console.ReadLine();
            if (entrada == null)
            {
                return;
            }

            switch (entrada)
            {
                case "1":
                {
                    string nome = LerTexto("Nome: ");
                    string telefone = LerTexto("Telefone: ");
                    string email = LerTexto("E-mail: ");
                    if (nome == null || telefone == null || email == null)
                    {
                        return;
                    }

                    if (agenda.Adicionar(nome, telefone, email))
                    {
                        Console.WriteLine("Contato adicionado.");
                    }
                    else
                    {
                        Console.WriteLine("Já existe um contato com esse nome.");
                    }
                    break;
                }
                case "2":
                {
                    string nome = LerTexto("Nome do contato a atualizar: ");
                    if (nome == null)
                    {
                        return;
                    }
                    if (!agenda.Existe(nome))
                    {
                        Console.WriteLine("Contato não encontrado.");
                        break;
                    }

                    string novoNome = LerTexto("Novo nome: ");
                    string telefone = LerTexto("Novo telefone: ");
                    string email = LerTexto("Novo e-mail: ");
                    if (novoNome == null || telefone == null || email == null)
                    {
                        return;
                    }

                    if (agenda.Atualizar(nome, novoNome, telefone, email))
                    {
                        Console.WriteLine("Contato atualizado.");
                    }
                    else
                    {
                        Console.WriteLine("Já existe outro contato com esse nome.");
                    }
                    break;
                }
                case "3":
                {
                    string nome = LerTexto("Nome do contato a excluir: ");
                    if (nome == null)
                    {
                        return;
                    }

                    if (agenda.Excluir(nome))
                    {
                        Console.WriteLine("Contato excluído.");
                    }
                    else
                    {
                        Console.WriteLine("Contato não encontrado.");
                    }
                    break;
                }
                case "4":
                    agenda.Listar();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            Console.WriteLine();
        }
    }
}
