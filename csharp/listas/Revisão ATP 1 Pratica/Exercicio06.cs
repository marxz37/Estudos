using System;
class Program
{
    static string Censura(string texto, string[] palavras)
    {
        string textoDiminuido = texto.ToLower();

        foreach(string palavra in palavras)
        {
            textoDiminuido = textoDiminuido.Replace(palavra.ToLower(), "[censurado]");
        }

        return textoDiminuido;
    }
    static void Main(string[] arg)
    {
        string texto;
        
        do
        {
            Console.Write("Escreva o seu texto: ");
            texto = Console.ReadLine();

            if(texto == "" || texto == null)
            {
                Console.WriteLine("Texto Invalido, O seu texto não pode ser vazio!");
            }
        }
        while(string.IsNullOrEmpty(texto));

        string[] palavroes = [
            "idiota", "imbecil", "otario", "porra", "puta", "estupido", "burro",
            "fdp", "canalha", "safado", "arrombado", "escroto", "vai tomar no cu", "filho da puta",
            "fudido", "retardado", "caralho", "Vai se foder", "foder"
        ];

        string censurado = Censura(texto,palavroes);

        Console.WriteLine($"Texto CENSURADO: {censurado}");
    }
}