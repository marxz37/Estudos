using System;

class Program
{
    static void Main()
    {
        string[] pronomes = { "eu", "tu", "ele", "nós", "vós", "eles" };
        string[] termPresente = { "o", "as", "a", "amos", "ais", "am" };
        string[] termPreterito = { "ei", "aste", "ou", "amos", "astes", "aram" };
        string[] termFuturo = { "arei", "arás", "ará", "aremos", "areis", "arão" };

        bool continuar = true;

        while (continuar)
        {
            Console.Write("Digite um verbo terminado em -ar: ");
            string verbo = Console.ReadLine();

            if (verbo.Length > 2 && verbo.Substring(verbo.Length - 2).ToUpper() == "AR")
            {
                string radical = verbo.Substring(0, verbo.Length - 2).ToLower();

                Console.WriteLine("Presente");
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(pronomes[i] + " " + radical + termPresente[i]);
                }

                Console.WriteLine("\nPretérito Perfeito");
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(pronomes[i] + " " + radical + termPreterito[i]);
                }

                Console.WriteLine("\nFuturo do Presente");
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(pronomes[i] + " " + radical + termFuturo[i]);
                }
            }
            else
            {
                Console.WriteLine("Erro");
            }

            Console.Write("Deseja continuar? (sim/nao): ");
            string resposta = Console.ReadLine();
            if (resposta.ToLower() == "não" || resposta.ToLower() == "nao")
            {
                continuar = false;
            }
        }
    }
}