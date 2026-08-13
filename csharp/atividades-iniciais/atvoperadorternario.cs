using System;

public class atvoperadorternario
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Você é Assinante? (S/N)");
        char respostaAssinante = char.Parse(Console.ReadLine().ToLower());
        Console.WriteLine ("O gênero do seu Livro é Educativo? (S/N)");
        char respostaEducativo = char.Parse(Console.ReadLine().ToLower());
        int precoLivro = 100;
        double resultado = (respostaAssinante == 's') ? (respostaEducativo == 's' ? precoLivro * 0.70 : (respostaEducativo == 'n' ? precoLivro * 0.85 : -1)) : (respostaAssinante == 'n' ? precoLivro * 0.95: -1); 
        Console.WriteLine(resultado == -1 ? "Erro: Entrada inválida!" : $"Total: {resultado:C}");
    }
}