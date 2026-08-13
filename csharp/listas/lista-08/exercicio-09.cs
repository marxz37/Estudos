using System;

class Program
{
    static string GerarEmail(string nomeCompleto)
    {
        if (nomeCompleto == null)
        {
            return "";
        }

        string nomeTratado = nomeCompleto.Trim();
        
        int primeiroEspaco = nomeTratado.IndexOf(' ');
        int ultimoEspaco = nomeTratado.LastIndexOf(' ');

        if (primeiroEspaco == -1)
        {
            return nomeTratado.ToLower() + "@acme.br";
        }

        string nome = nomeTratado.Substring(0, primeiroEspaco).ToLower();
        string sobrenome = nomeTratado.Substring(ultimoEspaco + 1).ToLower();

        return nome + "." + sobrenome + "@acme.br";
    }

    static void Main()
    {
        Console.Write("Digite seu nome completo: ");
        string entrada = Console.ReadLine();
        if (entrada == null)
        {
            entrada = "";
        }

        string email = GerarEmail(entrada);
        Console.WriteLine("E-mail gerado: " + email);
    }
}